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
    public partial class CruceroListado : Form
    {
        private bool unListado;
        private bool seleccionCorrecta = false;

        public CruceroListado(bool tipoListado)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            unListado = tipoListado;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CruceroListado_Load(object sender, EventArgs e)
        {

        }

        private void limpiarListado_Click(object sender, EventArgs e)
        {
            seleccionarID.ResetText();
            seleccionarFabricante.ResetText();
            seleccionarModelo.ResetText();
        }

        private void buscarListado_Click(object sender, EventArgs e)
        {
            // EJECUTO LAS LINEAS QUE LLENAN MI TABLA
            // listadoDePosibles.
            listadoCruceros.Rows.Clear();

            string query = "SELECT * FROM ZAFFA_TEAM.Crucero WHERE crucero_id LIKE '%" + seleccionarID.Text + "%'" + "and crucero_modelo LIKE '%" + seleccionarModelo.Text + "%'";
            
            if (seleccionarFabricante.SelectedItem != null)
                query += " and crucero_marca_id LIKE '%" + seleccionarFabricante.SelectedItem.ToString() + "%'";  //para evitar un NullPointerExc

            cargarCruceros(ClaseConexion.ResolverConsulta(query));
        }

        private void cargarCruceros(SqlDataReader reader)
        {
            //MessageBox.Show("Crucero guardado correctamente", "Ok");
            while (reader.Read())
            {
                //String bajaMod;

                //if (reader.GetBoolean(4))
                //    bajaMod = "Baja";
                //else
                //    bajaMod = "Habilitar";

                listadoCruceros.Rows.Add(reader.GetString(0).Trim(), reader.GetString(1).Trim(), reader.GetInt32(2).ToString(), reader.GetString(3).Trim(), reader.GetInt32(4).ToString());

            }

            reader.Close();
        }

        private void atrasListado_Click(object sender, EventArgs e)
        {
            Crucero modificar = new Crucero();
            modificar.Visible = true;
            this.Dispose(false);
        }

        private void modificarListado_Click(object sender, EventArgs e)
        {
            if (!seleccionCorrecta)
            {
                if (unListado)
                {
                    ModificarCrucero modificar = new ModificarCrucero();
                    modificar.Visible = true;
                    this.Dispose(false);
                }
                else
                {
                    BajaCrucero baja = new BajaCrucero();
                    baja.Visible = true;
                    this.Dispose(false);
                }
            }
            else {
                ModificarError error = new ModificarError();
                error.Visible = true;
                this.Dispose(false);
            } 
        }
    }
}
