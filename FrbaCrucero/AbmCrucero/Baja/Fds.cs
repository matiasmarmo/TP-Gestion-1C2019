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
    public partial class Fds : Form
    {
        string rolSeleccionado;
        string id;

        public Fds(string unRol, string unID)
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
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_upteEstadoViaje", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@crucero_id", id);
            cmd.Parameters.AddWithValue("@nuevo_estado", "FUERA DE SERVICIO");
            cmd.Parameters.AddWithValue("@motivo", textBox1.Text);

            cmd.ExecuteReader().Close();
        }

        private void cancelarPasajes()
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_cancelarPasajes", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@crucero_id", id);

            cmd.ExecuteReader().Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
            else
            {
                try
                {
                    this.darBaja();
                    if (string.Compare(comboBox1.Text, "Reprogramarlos para cuando el crucero vuelva") == 0) // selecciono cant dias
                    {
                        SeleccionarCorrimiento corr = new SeleccionarCorrimiento(rolSeleccionado, id);
                        corr.Visible = true;
                        this.Dispose(false);
                    }
                    else // cancelo pasajes
                    {
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
                catch (SqlException)
                {
                    MessageBox.Show("Error al dar de baja crucero", "Error");
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
