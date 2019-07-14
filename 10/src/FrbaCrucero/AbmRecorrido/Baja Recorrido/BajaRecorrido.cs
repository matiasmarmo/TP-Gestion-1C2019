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
    public partial class BajaRecorrido : Form
    {

        String codRecorrido;
        String rolSeleccionado;

        public BajaRecorrido(String idRecorrido,String rol)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            codRecorrido = idRecorrido;//
            rolSeleccionado = rol;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListadoBaja listadoBaja = new ListadoBaja(rolSeleccionado);
            listadoBaja.Visible = true;
            this.Dispose(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                try
                {
                    String query = "select coalesce(ESTADO_RECORRIDO,'A') from ZAFFA_TEAM.Recorrido_Unico where RECORRIDO_CODIGO = " + Decimal.Parse(codRecorrido).ToString();
                    SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
                    reader.Read();
                   
                        if (String.Compare(reader.GetString(0), "I") == 0)
                        {
                            MessageBox.Show("Ya se encuentra inhabilitado");
                             reader.Close();
                             return;
                         }
                        reader.Close();
                       
                    this.darDeBajaRecorrido();
                    MessageBox.Show("Se dio de baja corretamente");
                    AbmRecorrido abmRecorrido = new AbmRecorrido(rolSeleccionado);
                    abmRecorrido.Visible = true;
                    this.Dispose(false);
                }
                catch (SqlException) 
                {
                    MessageBox.Show("Volver a intentar", "Error");
                }           

        }


        private void darDeBajaRecorrido()
        {

            String fechaProceso = ConfigurationManager.AppSettings["current_date"].ToString().TrimEnd();
            DateTime date = DateTime.ParseExact(fechaProceso, "dd-MM-yyyy", null);

            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_borrarTramo", ClaseConexion.conexion);

            String fecha = date.ToString("yyyy-MM-dd");
            String id_recorrido = Decimal.Parse(codRecorrido).ToString();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_recorrido", id_recorrido);
            cmd.Parameters.AddWithValue("@fecha", fecha);

            cmd.ExecuteReader().Close();
            MessageBox.Show("Inhabilitando recorrido", "loading");


        }


    }
}
