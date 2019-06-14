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
    public partial class BajaDef : Form
    {
        string rolSeleccionado;
        string cruID;
        string cruModeloDesc;
        string cruModelo;
        string cruMarcaID;
        string estadoCrucero;
        string cantCabinas;

        public BajaDef(string unRol, string unID, string unModeloDesc, string unModelo, string unaMarca, string unEstado, string unasCabinas)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            rolSeleccionado = unRol;
            cruID = unID;
            cruModeloDesc = unModeloDesc;
            cruModelo = unModelo;
            cruMarcaID = unaMarca;
            estadoCrucero = unEstado;
            cantCabinas = unasCabinas;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fueraServicio_Click(object sender, EventArgs e)
        {
            //BajaCrucero baja = new BajaCrucero(rolSeleccionado);
            //baja.Visible = true;
            //this.Dispose(false);
        }

        private void darBaja()
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_upteEstadoViaje", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@crucero_id", cruID);
            cmd.Parameters.AddWithValue("@nuevo_estado", "BAJA DEFINITIVA");
            cmd.Parameters.AddWithValue("@motivo", textBox1.Text);

            cmd.ExecuteReader().Close();
        }

        private void cancelarPasajes()
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_cancelarPasajes", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@crucero_id", cruID);

            cmd.ExecuteReader().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
            else {
                try
                {
                    this.darBaja();
                }
                catch (SqlException)
                {
                    //MessageBox.Show("Error al dar de baja crucero", "Error");
                }
                if (string.Compare("Intentar asignarlos a otro crucero", comboBox1.Text) == 0)
                {
                    // consulto si hay otro crucero que pueda
                    NuevoCrucero baja = new NuevoCrucero(rolSeleccionado, cruID, cruModeloDesc, cruModelo, cruMarcaID, estadoCrucero, cantCabinas);
                    baja.Visible = true;
                    this.Dispose(false);
                }
                else
                {
                    // cancelo pasajes
                    try
                    {
                        this.cancelarPasajes();
                        MessageBox.Show("Pasajes cancelados correctamente", "Volver al menú");
                        Crucero cru = new Crucero(rolSeleccionado);
                        cru.Visible = true;
                        this.Dispose(false);
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error al cancelar los pasajes viejos", "Error");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            comboBox1.ResetText();
        }
    }
}
