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
    public partial class ListadoEstadistico : Form
    {
        string fechaInicial;
        string fechaFinal;

        public ListadoEstadistico()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ListadoEstadistico_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ResolverListado(SqlDataReader reader)
        {
            while (reader.Read())
            {

                dataGridView1.Rows.Add(reader.GetDecimal(0).ToString(), reader.GetInt32(1).ToString());

            }

            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            if (String.IsNullOrWhiteSpace(comboBox1.Text) || String.IsNullOrWhiteSpace(comboBox2.Text) || String.IsNullOrWhiteSpace(comboBox3.Text))
            {
                MessageBox.Show("Por favor complete todos los campos", "Error");
            }
            else
            {
                if(string.Compare("Primer Semestre", comboBox2.Text)==0){
                    fechaInicial = comboBox1.Text + "-01-01 00:00:00.000";
                    fechaFinal = comboBox1.Text + "-07-01 00:00:00.000";
                } else {
                    fechaInicial = comboBox1.Text + "-07-01 00:00:00.000";
                    fechaFinal = comboBox1.Text + "-12-31 00:00:00.000";
                }

                if(string.Compare("Recorridos con más pasajes comprados", comboBox3.Text)==0){
                   
                    string query = "SELECT TOP 5 via.RECORRIDO_CODIGO, COUNT(pas.PASAJE_CODIGO) pasajesComprados FROM ZAFFA_TEAM.Pasaje pas JOIN ZAFFA_TEAM.Viaje via ON pas.VIAJE_ID = via.VIAJE_ID WHERE via.FECHA_SALIDA BETWEEN '" + fechaInicial +"' AND +'"+ fechaFinal +"' AND via.FECHA_LLEGADA BETWEEN '"+ fechaInicial +"' AND '"+ fechaFinal +"' group by via.RECORRIDO_CODIGO order by pasajesComprados desc";
                   
                    try
                    {
                        ResolverListado(ClaseConexion.ResolverConsulta(query));
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("No se encontraron viajes en determinada fecha", "Error");
                    }
                }
                if (string.Compare("Recorridos con más cabinas libres", comboBox3.Text) == 0)
                {
                   
                    string query = "SELECT TOP 5 via.RECORRIDO_CODIGO, COUNT(pas.PASAJE_CODIGO) pasajesComprados FROM ZAFFA_TEAM.Pasaje pas JOIN ZAFFA_TEAM.Viaje via ON pas.VIAJE_ID = via.VIAJE_ID WHERE via.FECHA_SALIDA BETWEEN '" + fechaInicial +"' AND +'"+ fechaFinal +"' AND via.FECHA_LLEGADA BETWEEN '"+ fechaInicial +"' AND '"+ fechaFinal +"' group by via.RECORRIDO_CODIGO order by pasajesComprados desc";
                   
                    try
                    {
                        ResolverListado(ClaseConexion.ResolverConsulta(query));
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("No se encontraron viajes en determinada fecha", "Error");
                    }
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
