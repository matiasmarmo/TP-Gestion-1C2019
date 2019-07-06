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

        String recID;
        String ordenTramos;
        String puertoD;
        String puertoH;
        String precioBase;
        String rolSelecionado;

        private bool unListado;

        public ListadoRecorrido(bool tipoListado,String rol)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            unListado = tipoListado;
            rolSelecionado = rol;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            AbmRecorrido abmRecorrido = new AbmRecorrido(rolSelecionado);
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
            listaRecorrido.Rows.Clear();
            if (idRecorrido.Text == "" && idPuerto.Text == "" && precio.Text == "")
            {
                string query = "SELECT RECORRIDO_CODIGO, ORDEN_TRAMOS, PUERTO_DESDE_ID, PUERTO_HASTA_ID, RECORRIDO_PRECIO_BASE FROM ZAFFA_TEAM.Tramo WHERE RECORRIDO_CODIGO LIKE '" + idRecorrido.Text + "%'" + " and (PUERTO_DESDE_ID like" + "'%" + idPuerto.Text + "%'" + " or PUERTO_HASTA_ID LIKE '%" + idPuerto.Text + "%'" + ") and RECORRIDO_PRECIO_BASE LIKE '" + precio.Text + "%'";

                cargarRecorridos(ClaseConexion.ResolverConsulta(query));
         
            }
            else 
            {
                string query2 = "SELECT RECORRIDO_CODIGO, ORDEN_TRAMOS, PUERTO_DESDE_ID, PUERTO_HASTA_ID, RECORRIDO_PRECIO_BASE FROM ZAFFA_TEAM.Tramo WHERE RECORRIDO_CODIGO LIKE '" + idRecorrido.Text + "%'" + " and (PUERTO_DESDE_ID like" + "'" + idPuerto.Text + "%'" + " or PUERTO_HASTA_ID LIKE '" + idPuerto.Text + "%'" + ") and RECORRIDO_PRECIO_BASE LIKE '" + precio.Text + "%'";

                cargarRecorridos(ClaseConexion.ResolverConsulta(query2));
            }
           
        }

        private void cargarRecorridos(SqlDataReader reader)
        {

            while (reader.Read())
            {

                listaRecorrido.Rows.Add(reader.GetDecimal(0).ToString(), reader.GetInt32(1).ToString(), reader.GetInt32(2).ToString(), reader.GetInt32(3).ToString(), reader.GetDecimal(4).ToString());

            }

            reader.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           try
             {
                 foreach (DataGridViewRow row in listaRecorrido.SelectedRows)
                 {
                     recID = row.Cells[0].Value.ToString();
                     ordenTramos = row.Cells[1].Value.ToString();
                     puertoD = row.Cells[2].Value.ToString();
                     puertoH = row.Cells[3].Value.ToString();
                     precioBase = row.Cells[4].Value.ToString();

                         ModificarRecorrido modificarRecorrido = new ModificarRecorrido(recID, ordenTramos, puertoD, puertoH, precioBase,1 ,rolSelecionado);
                         modificarRecorrido.Visible = true;
                         this.Dispose(false);
                     
                 }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Por favor seleccione alguna fila válida", "Ok");
            }
  

             
        }//


    }
}