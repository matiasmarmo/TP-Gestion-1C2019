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
    public partial class ReservaPrincipal : Form
    {
        String reserva_fecha;
        String viajeID;
        String fecha_salida;
        String fecha_llegada;
        Decimal precio = 0;
        String crucero_id;
        String cli_id;
        String cabina_nro;
        String cabina_piso;
        Boolean ok = false;
        String rolSeleccionado;

        public ReservaPrincipal(String rolSeleccionado)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.rolSeleccionado = rolSeleccionado;
        }

        private void BTN_CONFIRMAR_Click(object sender, EventArgs e)
        {
            if (CODIGO_RESERVA_TEXT.Text == "")
            {
                return;
            }
            string query = "select CRUCERO_ID,RESERVA_FECHA,VIAJE_ID,CLI_ID,CABINA_NRO,CABINA_PISO from ZAFFA_TEAM.Reserva WHERE reserva_codigo = "+ CODIGO_RESERVA_TEXT.Text ;
            SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
            if (reader.Read())
            {
                DateTime res_fecha = reader.GetFieldValue<DateTime>(reader.GetOrdinal("RESERVA_FECHA"));
                cli_id = reader.GetSqlInt32(3).ToString();
                cabina_nro = reader.GetDecimal(4).ToString();
                cabina_piso = reader.GetDecimal(5).ToString();
                //DateTime date = DateTime.Today;
                String fechaProceso = ConfigurationManager.AppSettings["current_date"].ToString().TrimEnd();
                DateTime date = DateTime.ParseExact(fechaProceso, "dd-MM-yyyy", null);

                if (((TimeSpan)(date - res_fecha)).Days <= 3)
                {
                    reserva_fecha = res_fecha.ToString().Substring(0, 10);
                    dataGridView1.Rows[0].Cells[4].Value = reserva_fecha;
                    crucero_id = reader.GetString(0);
                    dataGridView1.Rows[0].Cells[0].Value = crucero_id;
                    viajeID = reader.GetSqlInt32(2).ToString();
                    reader.Close();

                    string query2 = "select FECHA_SALIDA,FECHA_LLEGADA from ZAFFA_TEAM.Viaje WHERE VIAJE_ID = " + viajeID;
                    SqlDataReader reader2 = ClaseConexion.ResolverConsulta(query2);
                    reader2.Read();
                    fecha_salida = reader2.GetFieldValue<DateTime>(reader2.GetOrdinal("FECHA_SALIDA")).
                                                    ToString().Substring(0, 10);
                    dataGridView1.Rows[0].Cells[2].Value = fecha_salida;
                    fecha_llegada = reader2.GetFieldValue<DateTime>(reader2.GetOrdinal("FECHA_LLEGADA")).
                                                    ToString().Substring(0, 10);
                    dataGridView1.Rows[0].Cells[3].Value = fecha_llegada;
                    reader2.Close();

                    string query3 = "select c.NOMBRE_PUERTO, d.NOMBRE_PUERTO, b.RECORRIDO_PRECIO_BASE from ZAFFA_TEAM.Viaje a join ZAFFA_TEAM.Tramo b on a.RECORRIDO_CODIGO = b.RECORRIDO_CODIGO join ZAFFA_TEAM.Puerto c on b.PUERTO_DESDE_ID = c.PUERTO_ID join ZAFFA_TEAM.Puerto d on b.PUERTO_HASTA_ID = d.PUERTO_ID WHERE VIAJE_ID=" + viajeID;
                    SqlDataReader reader3 = ClaseConexion.ResolverConsulta(query3);
                    while (reader3.Read())
                    {
                        comboBox1.Items.Add(reader3.GetString(0) + " - " + reader3.GetString(1));
                        precio += reader3.GetDecimal(2);
                    }
                    reader3.Close();

                    string query4 = "select c.CABINA_TIPO_RECARGO from ZAFFA_TEAM.Reserva a join ZAFFA_TEAM.Cabina b on a.CRUCERO_ID = b.CRUCERO_ID and a.CABINA_NRO = b.CABINA_NRO and a.CABINA_PISO = b.CABINA_PISO join ZAFFA_TEAM.Tipo_Cabina c on c.CABINA_TIPO_ID = b.CABINA_TIPO_ID where VIAJE_ID = " + viajeID;
                    SqlDataReader reader4 = ClaseConexion.ResolverConsulta(query4);
                    reader4.Read();
                    precio *= reader4.GetDecimal(0);
                    dataGridView1.Rows[0].Cells[5].Value = precio;
                    reader4.Close();

                    ok = true;
                }
                else 
                {
                    reader.Close();
                    MessageBox.Show("El numero de reserva posee mas de 3 dias desde su reserva");
                    int numRegs = ClaseConexion.ResolverNonQuery("delete from ZAFFA_TEAM.Reserva where RESERVA_CODIGO = " + CODIGO_RESERVA_TEXT.Text);
                }
            }
            else
            {
                reader.Close();
                MessageBox.Show("El numero de reserva ingresado no se encuentra registrado");
                CODIGO_RESERVA_TEXT.Clear();
                dataGridView1.Rows[0].Cells[0].Value = "";
                comboBox1.Items.Clear();
                dataGridView1.Rows[0].Cells[2].Value = "";
                dataGridView1.Rows[0].Cells[3].Value = "";
                dataGridView1.Rows[0].Cells[4].Value = "";
                dataGridView1.Rows[0].Cells[5].Value = ""; 
            }
        }

        private void BTN_ABONAR_Click(object sender, EventArgs e)
        {
            if (ok)
            {
                MedioPago pago = new MedioPago(CODIGO_RESERVA_TEXT.Text, viajeID, fecha_salida, fecha_llegada, precio, crucero_id, cli_id, cabina_nro, cabina_piso,rolSeleccionado);
                pago.Visible = true;
                this.Dispose(false);
                this.Close();
            }
        }

        private void BTN_MENU_PRINCIPAL_Click(object sender, EventArgs e)
        {
            Funcionalidades func = new Funcionalidades(rolSeleccionado);
            func.Visible = true;
            this.Dispose(false);
            this.Close();
        }
    }
}

           
        

       