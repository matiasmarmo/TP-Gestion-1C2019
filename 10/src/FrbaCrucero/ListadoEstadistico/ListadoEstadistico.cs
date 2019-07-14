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
        string rolSeleccionado;

        public ListadoEstadistico(string unRol)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            rolSeleccionado = unRol;
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

        private void ResolverListado2(SqlDataReader reader)
        {
            while (reader.Read())
            {

                dataGridView2.Rows.Add(reader.GetDecimal(0).ToString(), reader.GetInt32(1).ToString());

            }

            reader.Close();
        }

        private void ResolverListado3(SqlDataReader reader)
        {
            while (reader.Read())
            {
                dataGridView3.Rows.Add(reader.GetString(0).Trim(), reader.GetInt32(1).ToString());
            }

            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;

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

                    dataGridView1.Rows.Clear();
                    dataGridView1.Visible = true;
                    dataGridView2.Visible = false;
                    dataGridView3.Visible = false;

                    string query = "SELECT TOP 5 via.RECORRIDO_CODIGO, COUNT(pas.PASAJE_CODIGO) pasajesComprados FROM ZAFFA_TEAM.Pasaje pas JOIN ZAFFA_TEAM.Viaje via ON pas.VIAJE_ID = via.VIAJE_ID WHERE via.FECHA_SALIDA BETWEEN '" + fechaInicial +"' AND +'"+ fechaFinal +"' AND via.FECHA_LLEGADA BETWEEN '"+ fechaInicial +"' AND '"+ fechaFinal +"' group by via.RECORRIDO_CODIGO order by pasajesComprados desc";
                   
                    try
                    {
                        ResolverListado(ClaseConexion.ResolverConsulta(query));
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error al realizar la consulta", "Error");
                    }
                }

                if (string.Compare("Recorridos con más cabinas libres", comboBox3.Text) == 0)
                {
                    dataGridView2.Rows.Clear();
                    dataGridView1.Visible = false;
                    dataGridView2.Visible = true;
                    dataGridView3.Visible = false;

                    string query = "SELECT TOP 5 via.RECORRIDO_CODIGO CodigoDeRecorrido, ((select CANTIDAD_CABINAS from ZAFFA_TEAM.Crucero cru where cru.CRUCERO_ID = via.CRUCERO_ID) - (select count(*) from ZAFFA_TEAM.Pasaje pas where pas.VIAJE_ID = via.VIAJE_ID)) cabinasLibres FROM ZAFFA_TEAM.Pasaje pas JOIN ZAFFA_TEAM.Viaje via ON pas.VIAJE_ID = via.VIAJE_ID JOIN ZAFFA_TEAM.Crucero cru ON cru.CRUCERO_ID = pas.CRUCERO_ID WHERE via.FECHA_SALIDA BETWEEN '"+ fechaInicial +"' and '"+ fechaFinal +"' group by via.RECORRIDO_CODIGO, pas.VIAJE_ID, via.CRUCERO_ID, via.VIAJE_ID order by cabinasLibres desc";

                    try
                    {
                        ResolverListado2(ClaseConexion.ResolverConsulta(query));
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error al realizar la consulta", "Error");
                    }
                }



                if (string.Compare("Cruceros con mayor cantidad de días fuera de servicio", comboBox3.Text) == 0){

                    dataGridView3.Rows.Clear();
                    dataGridView1.Visible = false;
                    dataGridView2.Visible = false;
                    dataGridView3.Visible = true;

                    string query = "declare  @comienzoSemestre datetime2(3); declare  @finSemestre datetime2(3); set @comienzoSemestre='" + fechaInicial + "'; set @finSemestre='" + fechaFinal + "'; SELECT top 5 est.CRUCERO_ID Crucero, SUM(DATEDIFF(DAY, case when est.ESTADO_ACTUAL = 'REINICIO DE SERVICIO' and est.FECHA_ANTERIOR < @comienzoSemestre then @comienzoSemestre when est.ESTADO_ACTUAL = 'REINICIO DE SERVICIO' then est.FECHA_ANTERIOR when est.ESTADO_ACTUAL = 'FUERA DE SERVICIO' then est.FECHA_ACTUAL end, case when est.ESTADO_ACTUAL = 'REINICIO DE SERVICIO' then est.FECHA_ACTUAL when est.ESTADO_ACTUAL = 'FUERA DE SERVICIO' then  @finSemestre end )) DiasFueraDeServicio FROM ZAFFA_TEAM.Auditoria_estado_cruceros est left join  ZAFFA_TEAM.Auditoria_estado_cruceros estSig on estSig.CRUCERO_ID = est.CRUCERO_ID and estSig.ESTADO_ACTUAL = 'REINICIO DE SERVICIO' and est.FECHA_ACTUAL = estSig.FECHA_ANTERIOR WHERE (est.ESTADO_ACTUAL = 'REINICIO DE SERVICIO' and est.FECHA_ACTUAL >= @comienzoSemestre and est.FECHA_ACTUAL <= @finSemestre) or (est.ESTADO_ACTUAL = 'FUERA DE SERVICIO' and est.FECHA_ACTUAL >= @comienzoSemestre  and est.FECHA_ACTUAL <= @finSemestre AND (estSig.FECHA_ACTUAL is null or estSig.FECHA_ACTUAL > @finSemestre)) group by est.CRUCERO_ID ORDER BY 2 DESC";
                   
                    try
                    {
                        ResolverListado3(ClaseConexion.ResolverConsulta(query));
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error al realizar la consulta", "Error");
                    }
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Funcionalidades listado = new Funcionalidades(rolSeleccionado);
            listado.Visible = true;
            this.Dispose(false);
        }
    }
}
