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
using System.Text.RegularExpressions;

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
        int coincidencias = 0;
        int posicionActual = 0;
        List<String> Personas = new List<String>();
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
            String fechaProceso = ConfigurationManager.AppSettings["current_date"].ToString().TrimEnd();
            DateTime date = DateTime.ParseExact(fechaProceso, "dd-MM-yyyy", null);
            label18.Text = "FECHA ACTUAL: " + date.ToString().Substring(0,10);
            monthCalendar1.MaxDate = date;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text.Length == 8)
            {
                textBox14.Text = "";    textBox11.Text = "";    textBox10.Text = "";
                textBox13.Text = "";    textBox5.Text = "";     textBox4.Text = "";
                textBox15.Text = "";
                Personas.Clear();
                String query = "select count(*) from ZAFFA_TEAM.Cliente where cli_dni like '" + textBox12.Text + "%'";
                SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
                while (reader.Read())
                {
                    coincidencias = reader.GetInt32(0);
                    label17.Text = "Se encontraron " + coincidencias.ToString() + " coincidencias:"; 
                }
                reader.Close();
                
                query = "select cli_nombre,cli_apellido,cli_direccion,cli_telefono,cli_mail,cli_fecha_nac from ZAFFA_TEAM.Cliente where cli_dni like '" + textBox12.Text + "%'";
                SqlDataReader reader2 = ClaseConexion.ResolverConsulta(query);
                while (reader2.Read())
                {
                    Personas.Add(reader2.GetString(0));
                    Personas.Add(reader2.GetString(1));
                    Personas.Add(reader2.GetString(2));
                    Personas.Add(reader2.GetInt32(3).ToString());
                    Personas.Add(reader2.GetString(4));
                    if (reader2.IsDBNull(5)) { Personas.Add(""); }
                    else { Personas.Add(reader2.GetDateTime(5).ToString()); }
                }
                reader2.Close();
            }
            textBox14.Text = ""; textBox11.Text = ""; textBox10.Text = "";
            textBox13.Text = ""; textBox5.Text = ""; textBox4.Text = "";
            textBox15.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean cliente_existente = false;
            String dni = textBox12.Text;
            String nombre = textBox13.Text;
            String apellido = textBox14.Text;
            String direccion = textBox4.Text + " " + textBox15.Text;
            String telefono = textBox11.Text;
            String mail = textBox10.Text;
            if (textBox5.Text == "") 
            {
                MessageBox.Show("Faltaron completar campos");
                return;
            }
            String fecha_nac = Convert.ToDateTime(textBox5.Text).ToString("yyyy-MM-dd");
            String ID = "";
            Decimal precio = 0;
            if (dni == "" || apellido == "" || nombre == "" || telefono == "" || direccion == "" || mail == "" || fecha_nac == "")
            {
                MessageBox.Show("Faltaron completar campos");
                return;
            }
            String query = "select cli_id from ZAFFA_TEAM.Cliente where cli_dni like '" + dni + "%' and cli_apellido = '" + apellido + "' and cli_nombre = '" + nombre + "'";
            SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
            while (reader.Read())
            {
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
                cmd.Parameters.AddWithValue("@FECHA_NAC", fecha_nac);
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
                cmd.Parameters.AddWithValue("@FECHA_NAC", fecha_nac);
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

            String fechaProceso = ConfigurationManager.AppSettings["current_date"].ToString().TrimEnd();
            DateTime date = DateTime.ParseExact(fechaProceso, "dd-MM-yyyy", null);
            SqlCommand cmd2 = new SqlCommand("ZAFFA_TEAM.sp_borrarReservas", ClaseConexion.conexion);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@fecha_actual", date);
            cmd2.ExecuteReader().Close();

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
            String nombre = textBox13.Text;
            String apellido = textBox14.Text;
            String direccion = textBox4.Text + " " + textBox15.Text;
            String telefono = textBox11.Text;
            String mail = textBox10.Text;
            if (textBox5.Text == "")
            {
                MessageBox.Show("Faltaron completar campos");
                return;
            }
            String fecha_nac = Convert.ToDateTime(textBox5.Text).ToString("yyyy-MM-dd");
            String ID = "";
            Decimal precio = 0;
            if (dni == "" || apellido == "" || nombre == "" || telefono == "" || direccion == "" || mail == "" || fecha_nac == "")
            {
                MessageBox.Show("Faltaron completar campos");
                return;
            }
            String query = "select cli_id from ZAFFA_TEAM.Cliente where cli_dni like '" + dni + "%' and cli_apellido = '" + apellido + "' and cli_nombre = '" + nombre + "'";
            SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
            while (reader.Read())
            {
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
                cmd.Parameters.AddWithValue("@FECHA_NAC", fecha_nac);
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
                cmd.Parameters.AddWithValue("@FECHA_NAC", fecha_nac);
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

            String fechaProceso = ConfigurationManager.AppSettings["current_date"].ToString().TrimEnd();
            DateTime date = DateTime.ParseExact(fechaProceso, "dd-MM-yyyy", null);
            SqlCommand cmd2 = new SqlCommand("ZAFFA_TEAM.sp_borrarReservas", ClaseConexion.conexion);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@fecha_actual", date);
            cmd2.ExecuteReader().Close();

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

        private void button4_Click(object sender, EventArgs e)
        {
            if (coincidencias != 0)
            {
                textBox13.Text = Personas.ElementAt(0 + posicionActual);
                textBox14.Text = Personas.ElementAt(1 + posicionActual);
                textBox4.Text = this.ObtenerCalle(Personas.ElementAt(2 + posicionActual));
                textBox15.Text = this.OtenerAltura(Personas.ElementAt(2 + posicionActual));
                textBox11.Text = Personas.ElementAt(3 + posicionActual);
                textBox10.Text = Personas.ElementAt(4 + posicionActual);
                textBox5.Text = Personas.ElementAt(5 + posicionActual);
                posicionActual += 6;
                if (posicionActual >= coincidencias * 6) { posicionActual = 0; }
            }
        }

        private string ObtenerCalle(string p)
        {
            int aux = 0;
            Match match = Regex.Match(p, "([0-9][0-9][0-9][0-9])");
            if (match.Success) { aux = 4; }
            else
            {
                Match match2 = Regex.Match(p, "([0-9][0-9][0-9])");
                if (match2.Success) { aux = 3; }
            }
            int largo = p.Length;
            p = p.Substring(0, largo-aux );
            return p;
        }

        private string OtenerAltura(string p)
        {
            string aux = "";
            Match match = Regex.Match(p, "([0-9][0-9][0-9][0-9])|([0-9][0-9][0-9])|([0-9][0-9][0-9])");
            if (match.Success) {
                aux = match.Captures[0].Value; // Will output "#item3#"
            }
            return aux;
        }

        private void BTN_LIMPIAR_Click(object sender, EventArgs e)
        {
            textBox14.Text = ""; textBox11.Text = ""; textBox10.Text = ""; textBox13.Text = ""; 
            textBox5.Text = "";  textBox4.Text = "";  textBox15.Text = ""; textBox12.Text = "";
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BTN_ATRAS_Click(object sender, EventArgs e)
        {
            CabinasDisponibles cabi = new CabinasDisponibles(viaje_id, fecha_salida, fecha_llegada, crucero_id, this.rolSeleccionado);
            cabi.Visible = true;
            this.Dispose(false);
            this.Close();
        }

        private void RegistroViajeCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
