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
    public partial class PuertoListado : Form
    {
        public PuertoListado()
        {
            InitializeComponent();
            gD1C2019DataSet1.Puerto.Rows.Clear();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            seleccionarID.ResetText();
            seleccionarNombre.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbmPuerto abmPuerto = new AbmPuerto();
            abmPuerto.Visible = true;
            this.Dispose(false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModificarPuerto modPuerto = new ModificarPuerto();
            modPuerto.Visible = true;
            this.Dispose(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {


            gD1C2019DataSet1.Puerto.Clear();
            //.Rows.Clear();

            string query = "SELECT * FROM ZAFFA_TEAM.Puerto WHERE puerto_id LIKE '%" + seleccionarID.Text + "%'" + "and nombre_puerto LIKE '%" + seleccionarNombre.Text + "%'";

            cargarPuertos(ClaseConexion.ResolverConsulta(query));
        
        }

        private void cargarPuertos(SqlDataReader reader)
        {
            while (reader.Read())
            {
                                
                //listadoPuertos.Rows.Add(reader.GetInt32(0).ToString(), reader.GetString(1).Trim(), reader.GetString(2).Trim());

            }

            reader.Close();
        }

        private void PuertoListado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2019DataSet1.Puerto' table. You can move, or remove it, as needed.
            this.puertoTableAdapter.Fill(this.gD1C2019DataSet1.Puerto);

        }

        private void listadoPuertos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
