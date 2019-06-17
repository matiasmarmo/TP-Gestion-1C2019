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
    public partial class NuevoCrucero : Form
    {
        string rolSeleccionado;
        string cruID;
        string cruModeloDesc;
        string cruModelo;
        string cruMarcaID;
        string estadoCrucero;
        string cantCabinas;

        //string stringCruID;
        //decimal stringCabNro;
        //decimal stringCabPiso;
        //int stringCabTipoID;

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
            dataGridView1.Visible = false;
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
            //Funcionalidades listado = new Funcionalidades();
            //listado.Visible = true;
            //this.Dispose(false);
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            nombreID.ResetText();
        }

        private void guardarCrucero()
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_guardarCrucero", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@crucero_id", nombreID.Text);
            cmd.Parameters.AddWithValue("@crucero_modelo", cruModelo);
            cmd.Parameters.AddWithValue("@crucero_marca_id", cruMarcaID);
            cmd.Parameters.AddWithValue("@estado_crucero", "ALTA");
            cmd.Parameters.AddWithValue("@cantidad_cabinas", cantCabinas);

            cmd.ExecuteReader().Close();
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

                    //MessageBox.Show(coll1, coll2);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@crucero_id", nombreID.Text);
                    cmd.Parameters.AddWithValue("@cabina_nro", System.Convert.ToDecimal(coll2));//System.Convert.ToDecimal(stringCabNro));
                    cmd.Parameters.AddWithValue("@cabina_piso", System.Convert.ToDecimal(coll3));//System.Convert.ToDecimal(stringCabPiso));
                    cmd.Parameters.AddWithValue("@cabina_tipo_id", System.Convert.ToInt32(coll4));//System.Convert.ToInt32(stringCabTipoID));
                    cmd.ExecuteReader().Close();
                }
                catch (NullReferenceException) 
                {
                    MessageBox.Show("Se cargaron todas las cabinas", "Ok");
                }
            }
            //cmd.ExecuteReader().Close();
        }

        private void cargar_cabinas_Click(object sender, EventArgs e)
        {
            try
            {
                this.guardarCrucero();

                string query = "SELECT * FROM ZAFFA_TEAM.Cabina WHERE crucero_id LIKE '%" + cruID + "%'";

                correrCrucero(ClaseConexion.ResolverConsulta(query));
                MessageBox.Show("Crucero nuevo creado!", "Volver al menú");
                Crucero cru = new Crucero(rolSeleccionado);
                cru.Visible = true;
                this.Dispose(false);
            }
            catch (SqlException)
            {
                MessageBox.Show("Ya existe un crucero con el mismo ID", "Error");
            }
        }
    }
}
