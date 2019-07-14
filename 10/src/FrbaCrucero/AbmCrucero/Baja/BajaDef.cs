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
    public partial class BajaDef : Form
    {
        string rolSeleccionado;
        string cruID;
        string cruModeloDesc;
        string cruModelo;
        string cruMarcaID;
        string estadoCrucero;
        string cantCabinas;
        string nuevoCrucero;

        public BajaDef(string unRol, string unID, string unModeloDesc, string unModelo, string unaMarca, string unEstado, string unasCabinas)
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fueraServicio_Click(object sender, EventArgs e)
        {

        }

        private void darBaja()
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_upteEstadoViaje", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@crucero_id", cruID);
            cmd.Parameters.AddWithValue("@nuevo_estado", "BAJA DEFINITIVA");
            cmd.Parameters.AddWithValue("@motivo", textBox1.Text);

            cmd.ExecuteReader().Close();
        }

        private void cancelarPasajes()
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_cancelarPasajes", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@crucero_id", cruID);

            cmd.ExecuteReader().Close();
        }

        private void transladarViajes()
        {
            MessageBox.Show("Se comenzaran a buscar alternativas, por favor aguarde entre 10 y 20 segundos. Según nuestras políticas, un crucero podrá suplir a otro si está libre en la fecha de todos los viajes que tenía el anterior y posee igual o mayor cantidad de cabinas que el anterior.", "Continuar...");

            //SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_Crutrasladar", ClaseConexion.conexion);

            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@crucero_viejo", cruID);
            //cmd.ExecuteReader().Close();

            try
            {
                string query2 = "DROP TABLE [ZAFFA_TEAM].[VISTACRUCERO2]";
                borrarVista(ClaseConexion.ResolverConsulta(query2));
            }
            catch (SqlException)
            {

            }

            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_Crutrasladar4", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@crucero_viejo", cruID);
            cmd.ExecuteReader().Close();
                //string query3 = "execute ZAFFA_TEAM.sp_Crutrasladar @crucero_viejo = '" + cruID + "'";
                //procedure(ClaseConexion.ResolverConsulta(query3));

            string query = "SELECT TOP 1 cruceroNuevo FROM ZAFFA_TEAM.VISTACRUCERO2 GROUP BY cruceroNuevo, cruceroViejo HAVING count(cruceroNuevo) = (SELECT count(*) FROM ZAFFA_TEAM.Viaje WHERE CRUCERO_ID = cruceroViejo)";
            buscarResultados(ClaseConexion.ResolverConsulta(query));

            try
            {
                string query2 = "DROP TABLE [ZAFFA_TEAM].[VISTACRUCERO2]";
                borrarVista(ClaseConexion.ResolverConsulta(query2));
            }
            catch (SqlException)
            {

            }
                
            if (String.Compare(nuevoCrucero, "") == 0) // DUDA
            {
                MessageBox.Show(nuevoCrucero, "Aceptar");
                SqlCommand cmd2 = new SqlCommand("ZAFFA_TEAM.sp_modificarPas", ClaseConexion.conexion);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@crucero_viejo", cruID);
                cmd2.Parameters.AddWithValue("@crucero_nuevo", nuevoCrucero);
                cmd2.ExecuteReader().Close();
                MessageBox.Show("El nuevo crucero al que se le agregaron todos los viejes es " + nuevoCrucero, "Aceptar");
                Crucero cru = new Crucero(rolSeleccionado);
                cru.Visible = true;
                this.Dispose(false);
            }
            else {
                MessageBox.Show("No se pudieron transferir los viajes a otro crucero!", "Crear nuevo crucero");
                NuevoCrucero baja = new NuevoCrucero(rolSeleccionado, cruID, cruModeloDesc, cruModelo, cruMarcaID, estadoCrucero, cantCabinas);

                baja.Visible = true;
                this.Dispose(false);
            }
        }

        private void procedure(SqlDataReader reader)
        {
            while (reader.Read())
            {

            }
            reader.Close();
        }

        private void buscarResultados(SqlDataReader reader)
        {
            while (reader.Read())
            {
                try
                {
                    nuevoCrucero = reader.GetString(0).Trim();
                }
                catch (InvalidCastException) {
                    MessageBox.Show("Por favor actualice script", "Error");
                }
            }
            reader.Close();
        }

        private void borrarVista(SqlDataReader reader)
        {
            while (reader.Read())
            {

            }
            reader.Close();
        }
        private void button1_Click(object sender, EventArgs e)
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
                }
                catch (SqlException)
                {
                    //MessageBox.Show("Error al dar de baja crucero", "Error");
                }
                if (string.Compare("Intentar asignarlos a otro crucero", comboBox1.Text) == 0)
                {
                    // consulto si hay otro crucero que pueda

                    try
                    {
                        this.transladarViajes();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("No se pudieron transferir los viajes a otro crucero", "Crear nuevo crucero");
                        NuevoCrucero baja = new NuevoCrucero(rolSeleccionado, cruID, cruModeloDesc, cruModelo, cruMarcaID, estadoCrucero, cantCabinas);

                        baja.Visible = true;
                        this.Dispose(false);
                    }

                }
                else
                {
                    // cancelo pasajes
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            comboBox1.ResetText();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
