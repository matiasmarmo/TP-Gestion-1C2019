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
        String estado;

        public ListadoRecorrido(String rol)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
            puerto.ResetText();
            precio.ResetText();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaRecorrido.Rows.Clear();
            if (idRecorrido.Text == "" && puerto.Text == "" && precio.Text == "")
            {
                string query = "select t.RECORRIDO_CODIGO, ORDEN_TRAMOS, p.NOMBRE_PUERTO, p2.NOMBRE_PUERTO, RECORRIDO_PRECIO_BASE, ESTADO_RECORRIDO from ZAFFA_TEAM.Tramo t JOIN ZAFFA_TEAM.Puerto p ON (t.PUERTO_DESDE_ID = p.PUERTO_ID) JOIN ZAFFA_TEAM.Puerto p2 ON (t.PUERTO_HASTA_ID = p2.PUERTO_ID) JOIN ZAFFA_TEAM.Recorrido_Unico ru ON (t.RECORRIDO_CODIGO = ru.RECORRIDO_CODIGO) WHERE t.RECORRIDO_CODIGO LIKE '" + idRecorrido.Text + "%'" + " and (p.NOMBRE_PUERTO like" + "'%" + puerto.Text + "%'" + " or p2.NOMBRE_PUERTO LIKE '%" + puerto.Text + "%'" + ") and RECORRIDO_PRECIO_BASE LIKE '" + precio.Text + "%'";

                cargarRecorridos(ClaseConexion.ResolverConsulta(query));
         
            }
            else 
            {
                string query2 = "select t.RECORRIDO_CODIGO, ORDEN_TRAMOS, p.NOMBRE_PUERTO, p2.NOMBRE_PUERTO, RECORRIDO_PRECIO_BASE, ESTADO_RECORRIDO from ZAFFA_TEAM.Tramo t JOIN ZAFFA_TEAM.Puerto p ON (t.PUERTO_DESDE_ID = p.PUERTO_ID) JOIN ZAFFA_TEAM.Puerto p2 ON (t.PUERTO_HASTA_ID = p2.PUERTO_ID) JOIN ZAFFA_TEAM.Recorrido_Unico ru ON (t.RECORRIDO_CODIGO = ru.RECORRIDO_CODIGO) WHERE t.RECORRIDO_CODIGO LIKE '" + idRecorrido.Text + "%'" + " and (p.NOMBRE_PUERTO like" + "'" + puerto.Text + "%'" + " or p2.NOMBRE_PUERTO LIKE '" + puerto.Text + "%'" + ") and RECORRIDO_PRECIO_BASE LIKE '" + precio.Text + "%'";

                cargarRecorridos(ClaseConexion.ResolverConsulta(query2));
            }
           
        }

        private void cargarRecorridos(SqlDataReader reader)
        {

            while (reader.Read())
            {

                listaRecorrido.Rows.Add(reader.GetDecimal(0).ToString(), reader.GetInt32(1).ToString(), reader.GetString(2).Trim(), reader.GetString(3).Trim(), reader.GetDecimal(4).ToString(),reader.GetString(5).Trim());

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
                     estado = row.Cells[5].Value.ToString();

                     if (estado == "I")
                     {
                         MessageBox.Show("El recorrido esta inhabilitado");
                         DarAlta darAlta = new DarAlta(rolSelecionado, recID);
                         darAlta.Visible = true;
                         this.Dispose(false);
                     }
                     else
                     {

                         ModificarRecorrido modificarRecorrido = new ModificarRecorrido(recID, ordenTramos, puertoD, puertoH, precioBase, 1, rolSelecionado);
                         modificarRecorrido.Visible = true;
                         this.Dispose(false);
                     }
                 }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Por favor seleccione alguna fila válida", "Ok");
            }
  

             
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }//


    }
}