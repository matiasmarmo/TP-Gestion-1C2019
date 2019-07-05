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
    public partial class SacarPasaje : Form
    {
        int seleccionado = 1;
        String fecha_salida;
        String fecha_llegada;
        DateTime StartDate;
        DateTime EndDate;
        String rolSeleccionado;
        public SacarPasaje(String rolSeleccionado)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.rolSeleccionado = rolSeleccionado;
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.Visible = false;
            PUERTO_ORIGEN.Items.Add("");
            PUERTO_DESTINO.Items.Add("");
            string query = "select NOMBRE_PUERTO from ZAFFA_TEAM.Puerto where ESTADO_PUERTO = 'A' ORDER BY NOMBRE_PUERTO";
            SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
            while (reader.Read())
            {
                PUERTO_ORIGEN.Items.Add(reader.GetString(0));
                PUERTO_DESTINO.Items.Add(reader.GetString(0));
            }
            reader.Close();
            
        }

        private void BTN_SELEC1_Click(object sender, EventArgs e)
        {
            btnConfirmar.Visible = true;
            monthCalendar1.Visible = true;
            seleccionado = 1;
            DateTime inicial = new DateTime(2000, 7, 15);
            monthCalendar1.MinDate = inicial;
            textBox2.Text = "";
        }

        private void BTN_SELEC2_Click(object sender, EventArgs e)
        {
            btnConfirmar.Visible = true;
            monthCalendar1.Visible = true;
            seleccionado = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            
            String fechaProceso = ConfigurationManager.AppSettings["current_date"].ToString().TrimEnd();
            DateTime date = DateTime.ParseExact(fechaProceso, "dd-MM-yyyy", null);
            DateTime fech_salida = date;
            DateTime fech_llegada = date;
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                fech_salida = Convert.ToDateTime(textBox1.Text);
                fech_llegada = Convert.ToDateTime(textBox2.Text);
                fecha_salida = fech_salida.ToString("yyyy-MM-dd");
                fecha_llegada = fech_llegada.ToString("yyyy-MM-dd");
            }
            else if (textBox1.Text == "" && textBox2.Text != "")
            {
                fech_salida = date;
                fech_llegada = Convert.ToDateTime(textBox2.Text);
                fecha_salida = fech_salida.ToString("yyyy-MM-dd");
                fecha_llegada = fech_llegada.ToString("yyyy-MM-dd");
            }
            else if (textBox1.Text != "" && textBox2.Text == "")
            {
                fech_salida = Convert.ToDateTime(textBox1.Text);
                fech_llegada = date;
                fecha_salida = fech_salida.ToString("yyyy-MM-dd");
                fecha_llegada = "";
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                fech_salida = date;
                //fech_llegada = Convert.ToDateTime(textBox2.Text);
                fecha_salida = "";
                fecha_llegada = "";
            }

            if (fech_salida >= date)
            {
                
                String a = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where a.FECHA_SALIDA like '"+ fecha_salida +"%' and a.FECHA_LLEGADA like '"+ fecha_llegada +"%')";
                String b = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where c.NOMBRE_PUERTO like '" + PUERTO_ORIGEN.Text +"%' and b.ORDEN_TRAMOS = 1)";
                String c = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where d.NOMBRE_PUERTO like '" + PUERTO_DESTINO.Text +"%')";
                String d = " order by VIAJE_ID ";

                String query = " ( " + a + " intersect " + b + " ) " + " intersect " + " ( " + a + " intersect " + c + " ) " + d ;
                SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetInt32(0).ToString(), reader.GetString(1));

                }
                reader.Close();
            }
            /*----------------------------*/
            else
            {
                MessageBox.Show("La fecha de salida ya paso","ERROR");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 &&  dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() != "")
            {
                dataGridView1.CurrentRow.Selected = true;
                String viaje_Id = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                String crucero_Id = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();

                string query = "select FECHA_SALIDA,FECHA_LLEGADA from ZAFFA_TEAM.Viaje where VIAJE_ID = " + viaje_Id;
                SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
                reader.Read();
                fecha_salida = reader.GetDateTime(0).ToString();
                fecha_llegada = reader.GetDateTime(1).ToString();
                reader.Close();

                CabinasDisponibles cabi = new CabinasDisponibles(viaje_Id,fecha_salida,fecha_llegada, crucero_Id,this.rolSeleccionado);
                cabi.Visible = true;
                this.Dispose(false);
                this.Close();
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            btnConfirmar.Visible = true;
            if (seleccionado == 1)
            {
                textBox1.Text = monthCalendar1.SelectionEnd.ToShortDateString();
                StartDate = monthCalendar1.SelectionEnd;
            }
            else
            {
                textBox2.Text = monthCalendar1.SelectionEnd.ToShortDateString();
                EndDate = monthCalendar1.SelectionEnd;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            PUERTO_ORIGEN.Text = "";
            PUERTO_DESTINO.Text = "";
        }

        private void BTN_ATRAS_Click(object sender, EventArgs e)
        {
            Funcionalidades func = new Funcionalidades(this.rolSeleccionado);
            func.Visible = true;
            this.Dispose(false);
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            btnConfirmar.Visible = false;
            monthCalendar1.MinDate = StartDate;
        }
    }

}
