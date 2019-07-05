using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace FrbaCrucero
{
    public partial class RegistroViajeCliente : Form
    {
        String viaje_id;
        String fecha_salida; 
        String fecha_llegada; 
        String crucero_id;
        String cabina_nro; 
        String cabina_piso;
        String tipo_cabina;
        String rolSeleccionado;
        String fecha_nacimiento;

        public RegistroViajeCliente(String viaje_id, String fecha_salida, String fecha_llegada, String crucero_id,
                                    String cabina_nro, String cabina_piso, String tipo_cabina,String rolSeleccionado)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.rolSeleccionado = rolSeleccionado;
            this.viaje_id = viaje_id;
            this.fecha_salida = fecha_salida;
            this.fecha_llegada = fecha_llegada;
            this.crucero_id = crucero_id;
            this.cabina_nro = cabina_nro;
            this.cabina_piso = cabina_piso;
            this.tipo_cabina = tipo_cabina;
            this.init();
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.Visible = false;
            button3.Visible = false;
        }

        private void init()
        {
            textBox1.Text = viaje_id;
            textBox2.Text = fecha_salida;
            textBox3.Text = fecha_llegada;
            textBox6.Text = crucero_id;
            textBox7.Text = cabina_nro;
            textBox8.Text = cabina_piso;
            textBox9.Text = tipo_cabina;
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text.Length == 8)
            {
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                textBox14.Text = "";
                textBox11.Text = "";
                textBox10.Text = "";
                textBox5.Text = "";
                String query = "select cli_nombre,cli_apellido from ZAFFA_TEAM.Cliente where cli_dni like '" + textBox12.Text + "%'";
                SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
                while (reader.Read())
                {
                    comboBox2.Items.Add(reader.GetString(1) + "," + reader.GetString(0));
                }
                reader.Close();
                if (comboBox2.Items.Count == 0)
                {
                    comboBox2.Items.Add("");
                }
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox14.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
            textBox5.Text = "";
            String apellido = "", nombre = "";
            if (comboBox2.Text.Contains(" "))
            {
                return;
            }
            try
            {
                apellido = comboBox2.Text.Substring(0, comboBox2.Text.IndexOf(","));
                nombre = comboBox2.Text.Substring(comboBox2.Text.IndexOf(",") + 1);
            }
            catch
            {
                return;
            }
            String query = "select cli_dni,cli_nombre,cli_apellido,cli_direccion,cli_telefono,cli_mail,coalesce(cli_fecha_nac,'2010-06-01') from ZAFFA_TEAM.Cliente where cli_dni like '" + textBox12.Text + "%' and cli_apellido = '"+ apellido + "' and cli_nombre = '" + nombre + "'";
            SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
            while (reader.Read())
            {
                textBox14.Text = reader.GetString(3);
                textBox11.Text = reader.GetInt32(4).ToString();
                textBox10.Text = reader.GetString(5);
                textBox5.Text = reader.GetDateTime(6).ToString();
               // if (reader.GetDateTime(6).ToString() == "0") { textBox5.Text = ""; }
              //  else { textBox5.Text = reader.GetDateTime(6).ToString(); }
            }
            reader.Close();
        }

        private void comboBox2_TextUpdate(object sender, EventArgs e)
        {
            textBox14.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
            textBox5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean cliente_existente = false;
            String dni = textBox12.Text;
            String direccion = textBox14.Text;
            String telefono = textBox11.Text;
            String mail = textBox10.Text;
            String fecha_nac = textBox5.Text;
            String ID = "";
            Decimal precio = 0;
            if (dni == "" || comboBox2.Text == "" || telefono == "" || direccion == "" || mail == "")
            {
                MessageBox.Show("Faltaron completar campos");
                return;
            }
            String apellido = "", nombre = "";
            if (comboBox2.Text.Contains(" "))
            {
                MessageBox.Show("Los datos ingresados como nombre y apellido no respetan el formato Apellido,Nombre");
                return;
            }
            try
            {
                apellido = comboBox2.Text.Substring(0, comboBox2.Text.IndexOf(","));
                nombre = comboBox2.Text.Substring(comboBox2.Text.IndexOf(",") + 1);
            }
            catch
            {
                MessageBox.Show("Los datos ingresados como nombre y apellido no respetan el formato Apellido,Nombre");
                return;
            }
            String query = "select cli_id, cli_dni from ZAFFA_TEAM.Cliente where cli_dni like '" + textBox12.Text + "%' and cli_apellido = '" + apellido + "' and cli_nombre = '" + nombre + "'";
            SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
            while (reader.Read())
            {
                dni = reader.GetDecimal(1).ToString();
                ID = reader.GetInt32(0).ToString();               
                cliente_existente = true;
            }
            reader.Close();
            if (cliente_existente)
            {
                SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_actualizarCliente", ClaseConexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CLI_ID", ID);
                cmd.Parameters.AddWithValue("@CLI_NOMBRE", nombre);
                cmd.Parameters.AddWithValue("@CLI_APELLIDO", apellido);
                cmd.Parameters.AddWithValue("@CLI_DNI", dni);
                cmd.Parameters.AddWithValue("@CLI_DIRECCION", direccion);
                cmd.Parameters.AddWithValue("@CLI_TELEFONO", telefono);
                cmd.Parameters.AddWithValue("@CLI_MAIL", mail);
                cmd.ExecuteReader().Close();
            }
            if (!cliente_existente)
            {
                dni = textBox12.Text;
                telefono = textBox11.Text;
                SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_guardarCliente", ClaseConexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CLI_NOMBRE", nombre);
                cmd.Parameters.AddWithValue("@CLI_APELLIDO", apellido);
                cmd.Parameters.AddWithValue("@CLI_DNI", dni);
                cmd.Parameters.AddWithValue("@CLI_DIRECCION", direccion);
                cmd.Parameters.AddWithValue("@CLI_TELEFONO", telefono);
                cmd.Parameters.AddWithValue("@CLI_MAIL", mail);
                cmd.ExecuteReader().Close();
            }

            query = "select cli_id from ZAFFA_TEAM.Cliente where cli_dni = " + dni + " and cli_apellido = '" + apellido + "' and cli_nombre = '" + nombre + "'";
            SqlDataReader reader2 = ClaseConexion.ResolverConsulta(query);
            while (reader2.Read())
            {
                ID = reader2.GetInt32(0).ToString();
            }
            reader2.Close();

            string query3 = "select c.NOMBRE_PUERTO, d.NOMBRE_PUERTO, b.RECORRIDO_PRECIO_BASE from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID WHERE VIAJE_ID=" + viaje_id;
            SqlDataReader reader3 = ClaseConexion.ResolverConsulta(query3);
            while (reader3.Read())
            {
               // comboBox1.Items.Add(reader3.GetString(0) + " - " + reader3.GetString(1));
                precio += reader3.GetDecimal(2);
            }
            reader3.Close();
        

            string query4 = "select b.CABINA_TIPO_RECARGO from ZAFFA_TEAM.Cabina a join ZAFFA_TEAM.Tipo_Cabina b on a.CABINA_TIPO_ID = b.CABINA_TIPO_ID where a.CRUCERO_ID = '" + this.crucero_id + "' and a.CABINA_NRO = " + this.cabina_nro + "and a.CABINA_PISO = " + this.cabina_piso;
            SqlDataReader reader4 = ClaseConexion.ResolverConsulta(query4);
            reader4.Read();
            precio *= reader4.GetDecimal(0);
            reader4.Close();

            MedioPago pago = new MedioPago("", viaje_id, fecha_salida, fecha_llegada,
                                         precio, crucero_id, ID, cabina_nro, cabina_piso,rolSeleccionado);
            pago.Visible = true;
            this.Dispose(false);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean cliente_existente = false;
            String dni = textBox12.Text;
            String direccion = textBox14.Text;
            String telefono = textBox11.Text;
            String mail = textBox10.Text;
            String fecha_nac = textBox5.Text;
            String ID = "";
            Decimal precio = 0;
            if(dni =="" || comboBox2.Text == "" || telefono =="" ||direccion==""||mail=="") 
            {
                MessageBox.Show("Faltaron completar campos");
                return;
            }
            String apellido = "", nombre = "";
            if (comboBox2.Text.Contains(" "))
            {
                MessageBox.Show("Los datos ingresados como nombre y apellido no respetan el formato Apellido,Nombre");
                return;
            }
            try
            {
                apellido = comboBox2.Text.Substring(0, comboBox2.Text.IndexOf(","));
                nombre = comboBox2.Text.Substring(comboBox2.Text.IndexOf(",") + 1);
            }
            catch
            {
                MessageBox.Show("Los datos ingresados como nombre y apellido no respetan el formato Apellido,Nombre");
                return;
            }
            String query = "select cli_id, cli_dni from ZAFFA_TEAM.Cliente where cli_dni like '" + textBox12.Text + "%' and cli_apellido = '" + apellido + "' and cli_nombre = '" + nombre + "'";
            SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
            while (reader.Read())
            {
                dni = reader.GetDecimal(1).ToString();
                ID = reader.GetInt32(0).ToString();
                cliente_existente = true;
            }
            reader.Close();
            if (cliente_existente)
            {
                SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_actualizarCliente", ClaseConexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CLI_ID", ID);
                cmd.Parameters.AddWithValue("@CLI_NOMBRE", nombre);
                cmd.Parameters.AddWithValue("@CLI_APELLIDO", apellido);
                cmd.Parameters.AddWithValue("@CLI_DNI", dni);
                cmd.Parameters.AddWithValue("@CLI_DIRECCION", direccion);
                cmd.Parameters.AddWithValue("@CLI_TELEFONO", telefono);
                cmd.Parameters.AddWithValue("@CLI_MAIL", mail);
                cmd.ExecuteReader().Close();
            }
            if (!cliente_existente)
            {
                dni = textBox12.Text;
                telefono = textBox11.Text;
                SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_guardarCliente", ClaseConexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CLI_NOMBRE", nombre);
                cmd.Parameters.AddWithValue("@CLI_APELLIDO", apellido);
                cmd.Parameters.AddWithValue("@CLI_DNI", dni);
                cmd.Parameters.AddWithValue("@CLI_DIRECCION", direccion);
                cmd.Parameters.AddWithValue("@CLI_TELEFONO", telefono);
                cmd.Parameters.AddWithValue("@CLI_MAIL", mail);
                cmd.ExecuteReader().Close();
            }

            query = "select cli_id from ZAFFA_TEAM.Cliente where cli_dni = " + dni + " and cli_apellido = '" + apellido + "' and cli_nombre = '" + nombre + "'";
            SqlDataReader reader2 = ClaseConexion.ResolverConsulta(query);
            while (reader2.Read())
            {
                ID = reader2.GetInt32(0).ToString();
            }
            reader2.Close();

            string query3 = "select c.NOMBRE_PUERTO, d.NOMBRE_PUERTO, b.RECORRIDO_PRECIO_BASE from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID WHERE VIAJE_ID=" + viaje_id;
            SqlDataReader reader3 = ClaseConexion.ResolverConsulta(query3);
            while (reader3.Read())
            {
                precio += reader3.GetDecimal(2);
            }
            reader3.Close();

            string query4 = "select b.CABINA_TIPO_RECARGO from ZAFFA_TEAM.Cabina a join ZAFFA_TEAM.Tipo_Cabina b on a.CABINA_TIPO_ID = b.CABINA_TIPO_ID where a.CRUCERO_ID = '" + this.crucero_id + "' and a.CABINA_NRO = " + this.cabina_nro + "and a.CABINA_PISO = " + this.cabina_piso;
            SqlDataReader reader4 = ClaseConexion.ResolverConsulta(query4);
            reader4.Read();
            precio *= reader4.GetDecimal(0);
            reader4.Close();

            VoucherReserva res = new VoucherReserva(viaje_id, fecha_salida, fecha_llegada, precio, crucero_id,
                                                         nombre, apellido, ID, dni, cabina_nro, cabina_piso,rolSeleccionado);
            res.Visible = true;
            this.Dispose(false);
            this.Close();
        }

        private void BTN_TRAMOS_Click(object sender, EventArgs e)
        {
            string query3 = "select c.NOMBRE_PUERTO, d.NOMBRE_PUERTO from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID WHERE VIAJE_ID=" + viaje_id;
            SqlDataReader reader3 = ClaseConexion.ResolverConsulta(query3);
            string tramos = "";
            while (reader3.Read())
            {
                tramos = tramos + "   > " + reader3.GetString(0) + " - " + reader3.GetString(1) + " \n";
            }
            reader3.Close();
            MessageBox.Show("Los tramos del viaje seleccionado son: \n" + tramos);
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SELEC_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            monthCalendar1.Visible = true;
        }
        public void set_fecha_nacimiento(String fecha)
        {
            fecha_nacimiento = fecha;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            button3.Visible = false;
            textBox5.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            DateTime fecha_nac = Convert.ToDateTime(textBox5.Text);
            fecha_nacimiento = fecha_nac.ToString("yyyy-MM-dd");
        }
    }
}
