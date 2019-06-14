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

        string coll1;

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
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
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

        private void transladarViajes(SqlDataReader reader)
        {
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader.GetInt32(0));
            }

            reader.Close();

            string query2;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                query2 = "declare @crucero_viejo  nvarchar(50); declare @viaje_id int; declare  @cabLibres  int; set @crucero_viejo = '" + cruID + "'; set @viaje_id = '" + coll1 + "'; SELECT TOP 1 c.CRUCERO_ID, @crucero_viejo, @viaje_id FROM ZAFFA_TEAM.Crucero c JOIN ZAFFA_TEAM.Viaje v ON c.CRUCERO_ID = v.CRUCERO_ID WHERE ( SELECT ZAFFA_TEAM.LibreEnF( (SELECT CRUCERO_ID FROM ZAFFA_TEAM.Crucero WHERE CRUCERO_ID = c.CRUCERO_ID),  (SELECT FECHA_LLEGADA FROM ZAFFA_TEAM.Viaje WHERE VIAJE_ID = @viaje_id), (SELECT FECHA_SALIDA FROM ZAFFA_TEAM.Viaje WHERE VIAJE_ID = @viaje_id) ) AS ZAFFA_TEAM) = 1 AND ( SELECT ZAFFA_TEAM.ContieneCab( (SELECT CRUCERO_ID FROM ZAFFA_TEAM.Crucero WHERE CRUCERO_ID = c.CRUCERO_ID), @crucero_viejo ) AS ZAFFA_TEAM) = 1 ";
                    
                coll1 = row.Cells[0].Value.ToString();
                try
                {
                    while (reader.Read())
                    {
                        dataGridView2.Rows.Add(coll1, reader.GetString(0).Trim());
                    }

                    reader.Close();
                }
                catch (SqlException)
                {
                    MessageBox.Show("No se reprogramaron todos los viajes", "Error");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
            else {
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
                    /*
                    string query = "SELECT VIAJE_ID FROM ZAFFA_TEAM.Viaje WHERE CRUCERO_ID = '" + cruID + "'";

                    try
                    {
                        transladarViajes(ClaseConexion.ResolverConsulta(query));
                    }
                    catch (SqlException)
                    {*/
                        MessageBox.Show("No se pudieron transferir los viajes a otr crucero", "Crear nuevo crucero");
                        NuevoCrucero baja = new NuevoCrucero(rolSeleccionado, cruID, cruModeloDesc, cruModelo, cruMarcaID, estadoCrucero, cantCabinas);
                        baja.Visible = true;
                        this.Dispose(false);
                    //}
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
