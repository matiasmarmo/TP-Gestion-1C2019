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
        String nroTramo;
        String puertoDesdeID;
        String puertoHastaID;
        String precioBase;
        String rolSeleccionado;
        String fechaActual;

        public BajaRecorrido(String idRecorrido, String nTramo, String puertoD, String puertoH, String precio,String rol)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            codRecorrido = idRecorrido;//
            nroTramo = nTramo;
            puertoDesdeID = puertoD;
            puertoHastaID = puertoH;
            precioBase = precio;
            rolSeleccionado = rol;

            String fechaProceso = ConfigurationManager.AppSettings["current_date"].ToString().TrimEnd();
            DateTime date = DateTime.ParseExact(fechaProceso, "dd-MM-yyyy", null);

            fechaActual = date.ToString("yyyy-MM-dd h:mm:ss.000");
            MessageBox.Show(fechaActual.ToString(),"Fecha actual");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListadoRecorrido listadoRecorrido = new ListadoRecorrido(false,rolSeleccionado);
            listadoRecorrido.Visible = true;
            this.Dispose(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                try
                {
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
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_borrarTramo", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_recorrido", Decimal.Parse(codRecorrido));

            cmd.ExecuteReader().Close();
            MessageBox.Show("Borrando recorrido", "loading");


        }


    }
}
