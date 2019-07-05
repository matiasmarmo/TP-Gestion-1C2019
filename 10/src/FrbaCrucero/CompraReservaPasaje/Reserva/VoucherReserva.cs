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

namespace FrbaCrucero
{
    public partial class VoucherReserva : Form
    {
        String viajeID;
        String fecha_salida;
        String fecha_llegada;
        Decimal precio = 0;
        String crucero_id;
        String cli_nombre;
        String cli_apellido;
        String cli_dni;
        String cabina_nro;
        String cabina_piso;
        String cli_id;
        String rolSeleccionado;

        public VoucherReserva(String viajeID, String fecha_salida, String fecha_llegada, Decimal precio, String crucero_id,
                                 String cli_nombre, String cli_apellido, String cli_id, String cli_dni, 
                                    String cabina_nro, String cabina_piso, String rolSeleccionado)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.rolSeleccionado = rolSeleccionado;
            this.viajeID = viajeID;
            this.fecha_salida = fecha_salida;
            this.fecha_llegada = fecha_llegada;
            this.cli_nombre = cli_nombre;
            this.cli_apellido = cli_apellido;
            this.cli_dni = cli_dni;
            this.precio = precio;
            this.cli_id = cli_id;
            this.crucero_id = crucero_id;
            this.cabina_nro = cabina_nro;
            this.cabina_piso = cabina_piso;
            this.init();
        }
        private void init()
        {
            textBox2.Text = viajeID;
            textBox3.Text = fecha_salida;
            textBox4.Text = fecha_llegada;

            textBox5.Text = cli_apellido + ", " + cli_nombre;
            textBox6.Text = cli_dni;
            textBox7.Text = crucero_id;
            textBox8.Text = cabina_nro;
            textBox9.Text = cabina_piso;

            textBox11.Text = precio.ToString();

            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_crearReserva", ClaseConexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CLI_ID",      this.cli_id);
            cmd.Parameters.AddWithValue("@VIAJE_ID",    this.viajeID);
            cmd.Parameters.AddWithValue("@CRUCERO_ID",  this.crucero_id);
            cmd.Parameters.AddWithValue("@CABINA_NRO",  this.cabina_nro);
            cmd.Parameters.AddWithValue("@CABINA_PISO", this.cabina_piso);
            cmd.ExecuteReader().Close();

            string query = "Select Reserva_codigo from ZAFFA_TEAM.Reserva where CLI_ID = " + this.cli_id + " and viaje_id = " + this.viajeID + " and crucero_id = '" + crucero_id + "'";
            SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
            reader.Read();
            textBox1.Text = reader.GetDecimal(0).ToString();
            reader.Close();

            query = "select cabina_tipo_descripcion from ZAFFA_TEAM.Cabina a join ZAFFA_TEAM.Tipo_Cabina b on a.CABINA_TIPO_ID = b.CABINA_TIPO_ID where CABINA_NRO = " + this.cabina_nro + " and CABINA_PISO = " + this.cabina_piso + " and CRUCERO_ID = '" + this.crucero_id + "'";
            SqlDataReader reader2 = ClaseConexion.ResolverConsulta(query);
            reader2.Read();
            textBox10.Text = reader2.GetString(0);
            reader2.Close();    
        }

        private void BTN_MENU_PRINCIPAL_Click(object sender, EventArgs e)
        {
            Funcionalidades func = new Funcionalidades(rolSeleccionado);
            func.Visible = true;
            this.Dispose(false);
            this.Close();
        }

        private void BTN_TRAMOS_Click(object sender, EventArgs e)
        {
            String query = "select c.NOMBRE_PUERTO, d.NOMBRE_PUERTO from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID WHERE VIAJE_ID=" + viajeID;
            SqlDataReader reader3 = ClaseConexion.ResolverConsulta(query);
            string tramos = "";
            while (reader3.Read())
            {
                tramos = tramos + "   > " + reader3.GetString(0) + " - " + reader3.GetString(1) + " \n";
            }
            reader3.Close();
            MessageBox.Show("Los tramos del viaje seleccionado son: \n" + tramos);
        }      
    }
}
