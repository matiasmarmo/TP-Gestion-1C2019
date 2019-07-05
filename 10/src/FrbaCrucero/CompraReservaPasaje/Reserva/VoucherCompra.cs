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
    public partial class VoucherCompra : Form
    {
        String viajeID;
        String fecha_salida;
        String fecha_llegada;
        Decimal precio = 0;
        String crucero_id;
        String formaPago;
        String cuotas;
        String cli_id;
        String cabina_nro;
        String cabina_piso;
        String rolSeleccionado;

        public VoucherCompra(String viajeID, String fecha_salida, String fecha_llegada, Decimal precio, String crucero_id,
                                 String formaPago, String cuotas, String cli_id, String cabina_nro, String cabina_piso,String rolSeleccionado)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.rolSeleccionado = rolSeleccionado;
            this.viajeID = viajeID;
            this.fecha_salida = fecha_salida;
            this.fecha_llegada = fecha_llegada;
            this.precio = precio;
            this.crucero_id = crucero_id;
            this.formaPago = formaPago;
            this.cuotas = cuotas;
            this.cli_id = cli_id;
            this.cabina_nro = cabina_nro;
            this.cabina_piso = cabina_piso;
            this.init();
        }
        private void init()
        {
            textBox1.Text = viajeID;
            textBox2.Text = fecha_salida;
            textBox3.Text = fecha_llegada;

            textBox6.Text = crucero_id;
            textBox7.Text = cabina_nro;
            textBox8.Text = cabina_piso;

            textBox11.Text = precio.ToString();
            textBox12.Text = formaPago;
            textBox13.Text = cuotas;

            string query = "Select b.CLI_NOMBRE,b.CLI_APELLIDO,b.CLI_DNI from ZAFFA_TEAM.Pasaje a join ZAFFA_TEAM.Cliente b on a.CLI_ID = b.CLI_ID where b.CLI_ID = " + this.cli_id;
            SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
            reader.Read();
            textBox4.Text = reader.GetString(0) + ", " + reader.GetString(1);
            textBox5.Text = reader.GetDecimal(2).ToString();
            reader.Close();

            query = "select cabina_tipo_descripcion from ZAFFA_TEAM.Cabina a join ZAFFA_TEAM.Tipo_Cabina b on a.CABINA_TIPO_ID = b.CABINA_TIPO_ID where CABINA_NRO = " + this.cabina_nro + " and CABINA_PISO = " + this.cabina_piso + " and CRUCERO_ID = '" + this.crucero_id + "'";
            SqlDataReader reader2 = ClaseConexion.ResolverConsulta(query);
            reader2.Read();
            textBox9.Text = reader2.GetString(0);
            reader2.Close();

            query = "select max(PASAJE_CODIGO) from ZAFFA_TEAM.Pasaje";
            SqlDataReader reader4 = ClaseConexion.ResolverConsulta(query);
            while (reader4.Read())
            {
                textBox10.Text = reader4.GetDecimal(0).ToString();
            }
            reader4.Close();
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
