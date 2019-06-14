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
    public partial class BajaRecorrido : Form
    {

        String codRecorrido;
        String nroTramo;
        String puertoDesdeID;
        String puertoHastaID;
        String precioBase;
        String rolSeleccionado;

        public BajaRecorrido(String idRecorrido, String nTramo, String puertoD, String puertoH, String precio,String rol)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            codRecorrido = idRecorrido;
            nroTramo = nTramo;
            puertoDesdeID = puertoD;
            puertoHastaID = puertoH;
            precioBase = precio;
            rolSeleccionado = rol;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListadoRecorrido listadoRecorrido = new ListadoRecorrido(false,rolSeleccionado);
            listadoRecorrido.Visible = true;
            this.Dispose(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(HayPasajesVendidosSinRealizarViaje()){
                
                MessageBox.Show("No se puede dar de baja el recorrido porque existen pasajes vendidos","Error");
                ListadoRecorrido listRecorrido = new ListadoRecorrido(false,rolSeleccionado);
                listRecorrido.Visible = true;
                this.Dispose(false);
            
            }else{

                try
                {
                    this.darDeBajaRecorrido();
                    MessageBox.Show("Se dio de baja corretamente");
                }
                catch (SqlException) 
                {
                    MessageBox.Show("Volver a intentar", "Error");
                }
            }

        }


        private void darDeBajaRecorrido()
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_borrarTramo", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_recorrido", Decimal.Parse(codRecorrido));

            cmd.ExecuteReader().Close();
            MessageBox.Show("Borrando recorrido", "loading");


        }

        private bool HayPasajesVendidosSinRealizarViaje()
        {
            //Si ese viaje_id esta en la tabla de pasajes 
            //entonces y..

            string viaje_id;
            string query = "SELECT viaje_id FROM ZAFFA_TEAM.Viaje WHERE RECORRIDO_CODIGO = " + Decimal.Parse(codRecorrido);
            SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
            while (reader.Read())
            {
                viaje_id = reader.GetInt32(0).ToString();
            }
            reader.Close();

            string query2 = "SELECT VIAJE_ID FROM ZAFFA_TEAM.Pasaje WHERE VIAJE_ID = ";
            SqlDataReader reader2 = ClaseConexion.ResolverConsulta(query2);
            while (reader2.Read())
            {
                string  a = reader.GetString(0).Trim();
            }
            reader.Close();


            //.. Ver si esa fecha es menor que la fecha actual
            //Entonces devolver true
            String query3 = "SELECT fecha_llegada FROM ZAFFA_TEAM.Viaje WHERE RECORRIDO_CODIGO" + Decimal.Parse(codRecorrido);

            return false;
        }


    }
}
