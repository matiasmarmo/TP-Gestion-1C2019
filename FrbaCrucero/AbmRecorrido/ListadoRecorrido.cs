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
    public partial class ListadoRecorrido : Form
    {
        public ListadoRecorrido()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            AbmRecorrido abmRecorrido = new AbmRecorrido();
            abmRecorrido.Visible = true;
            this.Dispose(false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            idRecorrido.ResetText();
            idPuerto.ResetText();
            precio.ResetText();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listRecorrido.Rows.Clear();

            string query = "SELECT RECORRIDO_CODIGO, ORDEN_TRAMOS, PUERTO_DESDE_ID, PUERTO_HASTA_ID, RECORRIDO_PRECIO_BASE FROM ZAFFA_TEAM.Tramo WHERE RECORRIDO_CODIGO LIKE '%" + idRecorrido.Text + "%'" + "and PUERTO_DESDE_ID LIKE '%" + idPuerto.Text + "%'" + "OR PUERTO_HASTA_ID LIKE '%" + idPuerto.Text + "%'" + "and RECORRIDO_PRECIO_BASE LIKE '%" + precio.Text + "%'";

            cargarRecorridos(ClaseConexion.ResolverConsulta(query));
        }

        private void cargarRecorridos(SqlDataReader reader)
        {

            while (reader.Read())
            {

                listRecorrido.Rows.Add(reader.GetDecimal(0).ToString(), reader.GetInt32(1).ToString(), reader.GetInt32(2).ToString(),reader.GetInt32(3).ToString(), reader.GetDecimal(4).ToString());

            }

            reader.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

    }
}
