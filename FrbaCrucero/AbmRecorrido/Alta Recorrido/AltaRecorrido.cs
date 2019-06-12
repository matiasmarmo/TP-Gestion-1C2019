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
    public partial class AltaRecorrido : Form
    {
        //indice para indicar el nro de tramo
        int indiceNroRecorrido = 1;


        public AltaRecorrido(int indiceActualizado)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            indiceNroRecorrido = indiceActualizado;
            this.Llenar_ComboBox1();
            this.Llenar_ComboBox2();
            
        }

        private void Llenar_ComboBox1()
        {
            string query = "select NOMBRE_PUERTO from ZAFFA_TEAM.Puerto";
            SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
            while (reader.Read())
            {
                string puerto = reader.GetString(0).Trim();
                puertoDesde.Items.Add(puerto);
            }
            reader.Close();
        }

        private void Llenar_ComboBox2()
        {
            string query = "select NOMBRE_PUERTO from ZAFFA_TEAM.Puerto";
            SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
            while (reader.Read())
            {
                string puerto = reader.GetString(0).Trim();
                puertoHasta.Items.Add(puerto);
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbmRecorrido abmRecorrido = new AbmRecorrido();
            abmRecorrido.Visible = true;
            this.Dispose(false);
        }

        private void AltaRecorrido_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2019DataSet1.Puerto' table. You can move, or remove it, as needed.
            //this.puertoTableAdapter.Fill(this.gD1C2019DataSet1.Puerto);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(idRecorrido.Text) || String.IsNullOrWhiteSpace(precio.Text) || (puertoDesde.Text == puertoHasta.Text))
            {
                MessageBox.Show("Debe completar todos los campos y los puertos deben ser distintos", "Error");
            }
            else
            {
                try
                {
                    
                    this.guardarRecorrido();
                    MessageBox.Show("Recorrido guardado correctamente", "Ok");
                    AgregarOtroRecorrido agregarOtroRecorrido = new AgregarOtroRecorrido(indiceNroRecorrido);
                    agregarOtroRecorrido.Visible = true;
                    this.Dispose(false);

                }
                catch (SqlException)
                {
                    MessageBox.Show("Ya existe un crucero con el mismo ID", "Error");
                }
            }
        }

        private void guardarRecorrido()
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_guardarRecorrido", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_recorrido", idRecorrido.Text);
            cmd.Parameters.AddWithValue("@orden_tramo", indiceNroRecorrido);
            cmd.Parameters.AddWithValue("@puerto_desde", puertoDesde.Text);
            cmd.Parameters.AddWithValue("@puerto_hasta", puertoHasta.Text);
            cmd.Parameters.AddWithValue("@precio_recorrido", precio.Text);

            cmd.ExecuteReader().Close();
            MessageBox.Show("guardando recorrido", "loading");
        }


    }
}
