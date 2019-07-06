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
    public partial class ListadoBaja : Form
    {

        String rolSeleccionado;
        String recID;
        String estado;

        public ListadoBaja(String rol)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            rolSeleccionado = rol;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in listaBaja.SelectedRows)
                {
                    recID = row.Cells[0].Value.ToString();
                    estado = row.Cells[1].Value.ToString();

                    BajaRecorrido bajaRecorrido = new BajaRecorrido(recID, rolSeleccionado);
                    bajaRecorrido.Visible = true;
                    this.Dispose(false);

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Por favor seleccione alguna fila válida", "Ok");
            }
        }


        private void cargarRecorridos(SqlDataReader reader)
        {

            while (reader.Read())
            {

                listaBaja.Rows.Add(reader.GetDecimal(0).ToString(), reader.GetString(1).ToString());

            }

            reader.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            idRecorrido.ResetText();
        }

        private void atras_Click(object sender, EventArgs e)
        {
            AbmRecorrido abmRecorrido = new AbmRecorrido(rolSeleccionado);
            abmRecorrido.Visible = true;
            this.Dispose(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaBaja.Rows.Clear();

                string query = "SELECT RECORRIDO_CODIGO, ESTADO_RECORRIDO FROM ZAFFA_TEAM.Recorrido_unico WHERE RECORRIDO_CODIGO LIKE '" + idRecorrido.Text + "%'";

                cargarRecorridos(ClaseConexion.ResolverConsulta(query));

        }
    }
}
