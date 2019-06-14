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
    public partial class SeleccionarCorrimiento : Form
    {
        string rolSeleccionado;
        string id;
           
        public SeleccionarCorrimiento(string unRol, string unID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            rolSeleccionado = unRol;
            id = unID;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BajaCrucero baja = new BajaCrucero(rolSeleccionado);
            //baja.Visible = true;
            //this.Dispose(false);
        }

        private void darBaja()
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_reinicioServicioYCorrimiento", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dias_corrimiento", System.Convert.ToInt32(dias.Text));
            cmd.Parameters.AddWithValue("@crucero_id", id);

            cmd.ExecuteReader().Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(dias.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
            else {
                try
                {
                    this.darBaja();
                    MessageBox.Show("Viajes reprogramados correctamente", "Volver al menú");
                    Crucero listado = new Crucero(rolSeleccionado);
                    listado.Visible = true;
                    this.Dispose(false);
                   
                }
                catch (SqlException)
                {
                    MessageBox.Show("Error al dar de baja crucero", "Error");
                }          
            }
        }
    }
}
