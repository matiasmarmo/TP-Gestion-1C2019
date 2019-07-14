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
using System.Configuration;

namespace FrbaCrucero
{
    public partial class NuevoCrucero : Form
    {
        string rolSeleccionado;
        string cruID;
        string cruModeloDesc;
        string cruModelo;
        string cruMarcaID;
        string estadoCrucero;
        string cantCabinas;

        string coll1;
        string coll2;
        string coll3;
        string coll4;

        public NuevoCrucero(string unRol, string unID, string unModeloDesc, string unModelo, string unaMarca, string unEstado, string unasCabinas)
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
           // dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            nombreID.ResetText();
        }

        private void guardarCrucero()
        {
            String fechaProceso = ConfigurationManager.AppSettings["current_date"].ToString().TrimEnd();
            DateTime date = DateTime.ParseExact(fechaProceso, "dd-MM-yyyy", null);
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_guardarCrucero", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@crucero_id", nombreID.Text);
            cmd.Parameters.AddWithValue("@crucero_modelo", cruModelo);
            cmd.Parameters.AddWithValue("@crucero_marca_id", cruMarcaID);
            cmd.Parameters.AddWithValue("@estado_crucero", "ALTA");
            cmd.Parameters.AddWithValue("@cantidad_cabinas", cantCabinas);
            cmd.Parameters.AddWithValue("@fecha_actual", date);

            cmd.ExecuteReader().Close();
        }

        private void updatePasajeYCab()
        {
            SqlCommand cmd2 = new SqlCommand("ZAFFA_TEAM.sp_modificarPasaje_", ClaseConexion.conexion);

            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@crucero_viejo", cruID);
            cmd2.Parameters.AddWithValue("@crucero_nuevo", nombreID.Text);
            cmd2.ExecuteReader().Close();
        }

        private void correrCrucero(SqlDataReader reader)
        {
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader.GetString(0).Trim(), reader.GetDecimal(1), reader.GetDecimal(2), reader.GetInt32(3));
            }
            reader.Close();

            SqlCommand cmd;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    coll1 = row.Cells[0].Value.ToString();
                    coll2 = row.Cells[1].Value.ToString();
                    coll3 = row.Cells[2].Value.ToString();
                    coll4 = row.Cells[3].Value.ToString();

                    cmd = new SqlCommand("ZAFFA_TEAM.sp_crearCabina", ClaseConexion.conexion);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@crucero_id", nombreID.Text);
                    cmd.Parameters.AddWithValue("@cabina_nro", System.Convert.ToDecimal(coll2));
                    cmd.Parameters.AddWithValue("@cabina_piso", System.Convert.ToDecimal(coll3));
                    cmd.Parameters.AddWithValue("@cabina_tipo_id", System.Convert.ToInt32(coll4));
                    cmd.ExecuteReader().Close();
                }
                catch (NullReferenceException) 
                {
                    MessageBox.Show("Crucero nuevo creado! Se cargaron todas las cabinas", "Ok");
                }
            }
        }

        private void cargar_cabinas_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nombreID.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
            else
            {
                try
                {
                    this.guardarCrucero();
                    this.updatePasajeYCab();

                    string query = "SELECT * FROM ZAFFA_TEAM.Cabina WHERE crucero_id LIKE '" + cruID + "'";

                    correrCrucero(ClaseConexion.ResolverConsulta(query));
                    MessageBox.Show("Se actualizaron viajes con el nuevo crucero en base de datos", "Volver al menú");
                    
                }
                catch (SqlException)
                {
                    MessageBox.Show("Error al actualizar viajes", "Error");
                }
                Crucero cru = new Crucero(rolSeleccionado);
                cru.Visible = true;
                this.Dispose(false);
            }
        }
    }
}
