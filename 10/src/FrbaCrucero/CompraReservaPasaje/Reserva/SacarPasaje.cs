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
        Boolean flag=false;
        public SacarPasaje(String rolSeleccionado)
        {
            InitializeComponent();
            String fechaProceso = ConfigurationManager.AppSettings["current_date"].ToString().TrimEnd();
            DateTime date = DateTime.ParseExact(fechaProceso, "dd-MM-yyyy", null);
            label18.Text = "FECHA ACTUAL: " + date.ToString().Substring(0, 10);
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
            MessageBox.Show("Aclaración: Solo se mostrarán pasajes para comprar/reservar a partir de la fecha actual. \n\nSi se desea ver pasajes mas antiguos se deberá cambiar la fecha desde el archivo de configuración y volver a correr la App");
        }

        private void BTN_SELEC1_Click(object sender, EventArgs e)
        {
            btnConfirmar.Visible = true;
            monthCalendar1.Visible = true;
            seleccionado = 1;
            String fechaProceso = ConfigurationManager.AppSettings["current_date"].ToString().TrimEnd();
            monthCalendar1.MinDate = DateTime.ParseExact(fechaProceso, "dd-MM-yyyy", null);
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
            btnConfirmar.Visible = false;
            monthCalendar1.Visible = false;
            String fechaProceso = ConfigurationManager.AppSettings["current_date"].ToString().TrimEnd();
            DateTime date = DateTime.ParseExact(fechaProceso, "dd-MM-yyyy", null);
            DateTime fech_salida = date;
            DateTime fech_llegada = date;
            String fecha_actual = date.ToString("yyyy-MM-dd");
            fecha_salida = textBox1.Text;
            fecha_llegada = textBox2.Text;
            /*--------CASO A-------*/
            if (fecha_salida != "" && fecha_llegada == "" && PUERTO_ORIGEN.Text == "" && PUERTO_DESTINO.Text == "")
            {
                fecha_salida = Convert.ToDateTime(fecha_salida).ToString("yyyy-MM-dd");
                String a = "select distinct a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where a.FECHA_SALIDA like '" + fecha_salida + "%'";
                String b = " order by VIAJE_ID ";

                String query = a + b;
                SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetInt32(0).ToString(), reader.GetString(1));
                }
                reader.Close();
                return;
            }
            /*--------CASO B-------*/
            if (fecha_salida == "" && fecha_llegada != "" && PUERTO_ORIGEN.Text == "" && PUERTO_DESTINO.Text == "")
            {
                fecha_llegada = Convert.ToDateTime(fecha_llegada).ToString("yyyy-MM-dd");
                String a = "select distinct a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where a.FECHA_SALIDA > '" + date.ToString("yyyy-MM-dd") + "' and a.FECHA_LLEGADA LIKE '" + fecha_llegada + "%'";
                String b = " order by VIAJE_ID ";

                String query = a + b;
                SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetInt32(0).ToString(), reader.GetString(1));
                }
                reader.Close();
                return;
            }
            /*--------CASO C-------*/
            if (fecha_salida == "" && fecha_llegada == "" && PUERTO_ORIGEN.Text == "" && PUERTO_DESTINO.Text == "")
            {
                String a = "select distinct a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where a.FECHA_SALIDA > '" + date.ToString("yyyy-MM-dd")+ "'";
                String b = " order by VIAJE_ID ";

                String query = a + b;
                SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetInt32(0).ToString(), reader.GetString(1));
                }
                reader.Close();
                return;
            }
            /*--------CASO D-------*/
            if (fecha_salida != "" && fecha_llegada != "" && PUERTO_ORIGEN.Text == "" && PUERTO_DESTINO.Text == "")
            {
                fecha_salida = Convert.ToDateTime(fecha_salida).ToString("yyyy-MM-dd");
                fecha_llegada = Convert.ToDateTime(fecha_llegada).ToString("yyyy-MM-dd");
                String a = "select distinct a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where a.FECHA_SALIDA like '" + fecha_salida + "%' and a.FECHA_LLEGADA like '" + fecha_llegada + "%'";
                String b = " order by VIAJE_ID ";

                String query = a + b;
                SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetInt32(0).ToString(), reader.GetString(1));
                }
                reader.Close();
                return;
            }
            /*--------CASO E-------*/
            if (fecha_salida == "" && fecha_llegada == "" && PUERTO_ORIGEN.Text != "" && PUERTO_DESTINO.Text == "")
            {
                String a = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where a.FECHA_SALIDA >= '" + fecha_actual + "')";
                String b = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where c.NOMBRE_PUERTO like '" + PUERTO_ORIGEN.Text + "%' and b.ORDEN_TRAMOS = 1)";
                String c = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where d.NOMBRE_PUERTO like '" + PUERTO_DESTINO.Text + "%')";
                String d = " order by VIAJE_ID ";

                String query = " ( " + a + " intersect " + b + " ) " + " intersect " + " ( " + a + " intersect " + c + " ) " + d;
                SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetInt32(0).ToString(), reader.GetString(1));
                }
                reader.Close();
                return;
            }
            /*--------CASO F-------*/
            if (fecha_salida == "" && fecha_llegada != "" && PUERTO_ORIGEN.Text != "" && PUERTO_DESTINO.Text == "")
            {
                fecha_llegada = Convert.ToDateTime(fecha_llegada).ToString("yyyy-MM-dd");
                String a = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where a.FECHA_SALIDA >= '" + fecha_actual + "' and a.FECHA_LLEGADA like '" + fecha_llegada + "%')";
                String b = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where c.NOMBRE_PUERTO like '" + PUERTO_ORIGEN.Text + "%' and b.ORDEN_TRAMOS = 1)";
                String c = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where d.NOMBRE_PUERTO like '" + PUERTO_DESTINO.Text + "%')";
                String d = " order by VIAJE_ID ";

                String query = " ( " + a + " intersect " + b + " ) " + " intersect " + " ( " + a + " intersect " + c + " ) " + d;
                SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetInt32(0).ToString(), reader.GetString(1));
                }
                reader.Close();
                return;
            }
            /*--------CASO G-------*/
            if (fecha_salida != "" && fecha_llegada == "" && PUERTO_ORIGEN.Text != "" && PUERTO_DESTINO.Text == "")
            {
                fecha_salida = Convert.ToDateTime(fecha_salida).ToString("yyyy-MM-dd");
                String a = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where a.FECHA_SALIDA LIKE '" + fecha_salida + "%')";
                String b = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where c.NOMBRE_PUERTO like '" + PUERTO_ORIGEN.Text + "%' and b.ORDEN_TRAMOS = 1)";
                String c = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where d.NOMBRE_PUERTO like '" + PUERTO_DESTINO.Text + "%')";
                String d = " order by VIAJE_ID ";

                String query = " ( " + a + " intersect " + b + " ) " + " intersect " + " ( " + a + " intersect " + c + " ) " + d;
                SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetInt32(0).ToString(), reader.GetString(1));
                }
                reader.Close();
                return;
            }
            /*--------CASO H-------*/
            if (fecha_salida != "" && fecha_llegada != "" && PUERTO_ORIGEN.Text != "" && PUERTO_DESTINO.Text == "")
            {
                fecha_salida = Convert.ToDateTime(fecha_salida).ToString("yyyy-MM-dd");
                fecha_llegada = Convert.ToDateTime(fecha_llegada).ToString("yyyy-MM-dd");
                String a = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where a.FECHA_SALIDA LIKE '" + fecha_salida + "%' and a.FECHA_LLEGADA like '" + fecha_llegada + "%')";
                String b = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where c.NOMBRE_PUERTO like '" + PUERTO_ORIGEN.Text + "%' and b.ORDEN_TRAMOS = 1)";
                String c = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where d.NOMBRE_PUERTO like '" + PUERTO_DESTINO.Text + "%')";
                String d = " order by VIAJE_ID ";

                String query = " ( " + a + " intersect " + b + " ) " + " intersect " + " ( " + a + " intersect " + c + " ) " + d;
                SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetInt32(0).ToString(), reader.GetString(1));
                }
                reader.Close();
                return;
            }
            /*--------CASO I-------*/
            if (fecha_salida == "" && fecha_llegada == "" && PUERTO_ORIGEN.Text == "" && PUERTO_DESTINO.Text != "")
            {
                String a = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where a.FECHA_SALIDA >= '" + fecha_actual + "')";
                String b = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where c.NOMBRE_PUERTO like '" + PUERTO_ORIGEN.Text + "%' and b.ORDEN_TRAMOS = 1)";
                String c = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where d.NOMBRE_PUERTO like '" + PUERTO_DESTINO.Text + "%')";
                String d = " order by VIAJE_ID ";

                String query = " ( " + a + " intersect " + b + " ) " + " intersect " + " ( " + a + " intersect " + c + " ) " + d;
                SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetInt32(0).ToString(), reader.GetString(1));
                }
                reader.Close();
                return;
            }
            /*--------CASO J-------*/
            if (fecha_salida == "" && fecha_llegada != "" && PUERTO_ORIGEN.Text == "" && PUERTO_DESTINO.Text != "")
            {
                fecha_llegada = Convert.ToDateTime(fecha_llegada).ToString("yyyy-MM-dd");
                String a = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where a.FECHA_SALIDA >= '" + fecha_actual + "' and a.FECHA_LLEGADA like '" + fecha_llegada + "%')";
                String b = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where c.NOMBRE_PUERTO like '" + PUERTO_ORIGEN.Text + "%' and b.ORDEN_TRAMOS = 1)";
                String c = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where d.NOMBRE_PUERTO like '" + PUERTO_DESTINO.Text + "%')";
                String d = " order by VIAJE_ID ";

                String query = " ( " + a + " intersect " + b + " ) " + " intersect " + " ( " + a + " intersect " + c + " ) " + d;
                SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetInt32(0).ToString(), reader.GetString(1));
                }
                reader.Close();
                return;
            }
            /*--------CASO K-------*/
            if (fecha_salida != "" && fecha_llegada == "" && PUERTO_ORIGEN.Text == "" && PUERTO_DESTINO.Text != "")
            {
                fecha_salida = Convert.ToDateTime(fecha_salida).ToString("yyyy-MM-dd");
                String a = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where a.FECHA_SALIDA LIKE '" + fecha_salida + "%')";
                String b = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where c.NOMBRE_PUERTO like '" + PUERTO_ORIGEN.Text + "%' and b.ORDEN_TRAMOS = 1)";
                String c = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where d.NOMBRE_PUERTO like '" + PUERTO_DESTINO.Text + "%')";
                String d = " order by VIAJE_ID ";

                String query = " ( " + a + " intersect " + b + " ) " + " intersect " + " ( " + a + " intersect " + c + " ) " + d;
                SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetInt32(0).ToString(), reader.GetString(1));
                }
                reader.Close();
                return;
            }
            /*--------CASO L-------*/
            if (fecha_salida != "" && fecha_llegada != "" && PUERTO_ORIGEN.Text == "" && PUERTO_DESTINO.Text != "")
            {
                fecha_salida = Convert.ToDateTime(fecha_salida).ToString("yyyy-MM-dd");
                fecha_llegada = Convert.ToDateTime(fecha_llegada).ToString("yyyy-MM-dd");
                String a = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where a.FECHA_SALIDA LIKE '" + fecha_salida + "%' and a.FECHA_LLEGADA like '" + fecha_llegada + "%')";
                String b = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where c.NOMBRE_PUERTO like '" + PUERTO_ORIGEN.Text + "%' and b.ORDEN_TRAMOS = 1)";
                String c = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where d.NOMBRE_PUERTO like '" + PUERTO_DESTINO.Text + "%')";
                String d = " order by VIAJE_ID ";

                String query = " ( " + a + " intersect " + b + " ) " + " intersect " + " ( " + a + " intersect " + c + " ) " + d;
                SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetInt32(0).ToString(), reader.GetString(1));
                }
                reader.Close();
                return;
            }
            /*--------CASO M-------*/
            if (fecha_salida == "" && fecha_llegada == "" && PUERTO_ORIGEN.Text != "" && PUERTO_DESTINO.Text != "")
            {
                String a = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where a.FECHA_SALIDA >= '" + fecha_actual + "')";
                String b = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where c.NOMBRE_PUERTO like '" + PUERTO_ORIGEN.Text + "%' and b.ORDEN_TRAMOS = 1)";
                String c = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where d.NOMBRE_PUERTO like '" + PUERTO_DESTINO.Text + "%')";
                String d = " order by VIAJE_ID ";

                String query = " ( " + a + " intersect " + b + " ) " + " intersect " + " ( " + a + " intersect " + c + " ) " + d;
                SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetInt32(0).ToString(), reader.GetString(1));
                }
                reader.Close();
                return;
            }
            /*--------CASO N-------*/
            if (fecha_salida == "" && fecha_llegada != "" && PUERTO_ORIGEN.Text != "" && PUERTO_DESTINO.Text != "")
            {
                fecha_llegada = Convert.ToDateTime(fecha_llegada).ToString("yyyy-MM-dd");
                String a = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where a.FECHA_SALIDA >= '" + fecha_actual + "' and a.FECHA_LLEGADA like '" + fecha_llegada + "%')";
                String b = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where c.NOMBRE_PUERTO like '" + PUERTO_ORIGEN.Text + "%' and b.ORDEN_TRAMOS = 1)";
                String c = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where d.NOMBRE_PUERTO like '" + PUERTO_DESTINO.Text + "%')";
                String d = " order by VIAJE_ID ";

                String query = " ( " + a + " intersect " + b + " ) " + " intersect " + " ( " + a + " intersect " + c + " ) " + d;
                SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetInt32(0).ToString(), reader.GetString(1));
                }
                reader.Close();
                return;
            }
            /*--------CASO O-------*/
            if (fecha_salida != "" && fecha_llegada == "" && PUERTO_ORIGEN.Text != "" && PUERTO_DESTINO.Text != "")
            {
                fecha_salida = Convert.ToDateTime(fecha_salida).ToString("yyyy-MM-dd");
                String a = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where a.FECHA_SALIDA LIKE '" + fecha_salida + "%')";
                String b = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where c.NOMBRE_PUERTO like '" + PUERTO_ORIGEN.Text + "%' and b.ORDEN_TRAMOS = 1)";
                String c = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where d.NOMBRE_PUERTO like '" + PUERTO_DESTINO.Text + "%')";
                String d = " order by VIAJE_ID ";

                String query = " ( " + a + " intersect " + b + " ) " + " intersect " + " ( " + a + " intersect " + c + " ) " + d;
                SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetInt32(0).ToString(), reader.GetString(1));
                }
                reader.Close();
                return;
            }
            /*--------CASO P-------*/
            if (fecha_salida != "" && fecha_llegada != "" && PUERTO_ORIGEN.Text != "" && PUERTO_DESTINO.Text != "")
            {
                fecha_salida = Convert.ToDateTime(fecha_salida).ToString("yyyy-MM-dd");
                fecha_llegada = Convert.ToDateTime(fecha_llegada).ToString("yyyy-MM-dd");
                String a = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where a.FECHA_SALIDA LIKE '" + fecha_salida + "%' and a.FECHA_LLEGADA like '" + fecha_llegada + "%')";
                String b = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where c.NOMBRE_PUERTO like '" + PUERTO_ORIGEN.Text + "%' and b.ORDEN_TRAMOS = 1)";
                String c = "(select a.VIAJE_ID, a.Crucero_ID from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID where d.NOMBRE_PUERTO like '" + PUERTO_DESTINO.Text + "%')";
                String d = " order by VIAJE_ID ";

                String query = " ( " + a + " intersect " + b + " ) " + " intersect " + " ( " + a + " intersect " + c + " ) " + d;
                SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetInt32(0).ToString(), reader.GetString(1));
                }
                reader.Close();
                return;
            }
            /*----------------------------*/
            else
            {
                MessageBox.Show("La fecha de salida ya paso","ERROR");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 &&  dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() != "")
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
            if (e.ColumnIndex == 2 && dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() != "")
            {
                dataGridView1.CurrentRow.Selected = true;
                String viaje_Id = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();

                string query3 = "select c.NOMBRE_PUERTO, d.NOMBRE_PUERTO from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID WHERE VIAJE_ID=" + viaje_Id;
                SqlDataReader reader3 = ClaseConexion.ResolverConsulta(query3);
                string tramos = "";
                while (reader3.Read())
                {
                    tramos = tramos + "   > " + reader3.GetString(0) + " - " + reader3.GetString(1) + " \n";
                }
                reader3.Close();
                MessageBox.Show("Los tramos del viaje seleccionado son: \n" + tramos);
                dataGridView1.CurrentRow.Selected = false;
            }
            if (e.ColumnIndex == 3 && dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() != "")
            {
                dataGridView1.CurrentRow.Selected = true;
                String viaje_Id = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();

                string query3 = "SELECT FECHA_SALIDA, FECHA_LLEGADA FROM ZAFFA_TEAM.Viaje WHERE VIAJE_ID = " + viaje_Id;
                SqlDataReader reader3 = ClaseConexion.ResolverConsulta(query3);
                string fechas_viaje = "";
                reader3.Read();
                fechas_viaje = "El viaje posee las siguientes fechas: \n" + "   > FECHA SALIDA: " + reader3.GetDateTime(0).ToString("yyyy-MM-dd") + " \n" + "   > FECHA LLEGADA: " + reader3.GetDateTime(1).ToString("yyyy-MM-dd");
                reader3.Close();
                MessageBox.Show(fechas_viaje);
                dataGridView1.CurrentRow.Selected = false;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            flag = true;
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
            dataGridView1.Rows.Clear();
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
            if (flag == true)
            {
                monthCalendar1.Visible = false;
                btnConfirmar.Visible = false;
                monthCalendar1.MinDate = StartDate;
                flag = false;
                return;
            }
            MessageBox.Show("Seleccione una fecha antes de confirmar.");
            flag = false;
        }

        private void SacarPasaje_Load(object sender, EventArgs e)
        {

        }
    }

}
