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
    public partial class CabinasDisponibles : Form
    {
        String viaje_id;
        String crucero_id;
        String fecha_salida;
        String fecha_llegada;
        String rolSeleccionado;
        public CabinasDisponibles(String viaje_id, String fecha_salida, String fecha_llegada, String crucero_id,String rolSeleccionado)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.rolSeleccionado = rolSeleccionado;
            this.agregarCabinasLibres(viaje_id, crucero_id);
            this.viaje_id = viaje_id;
            this.crucero_id = crucero_id;
            this.fecha_salida = fecha_salida;
            this.fecha_llegada = fecha_llegada;
            String fechaProceso = ConfigurationManager.AppSettings["current_date"].ToString().TrimEnd();
            DateTime date = DateTime.ParseExact(fechaProceso, "dd-MM-yyyy", null);
            label18.Text = "FECHA ACTUAL: " + date.ToString().Substring(0, 10);
        }

        private void agregarCabinasLibres(String viaje_id, String crucero_id)
        {
            int contador = 0;
            string a = "select CABINA_NRO,CABINA_PISO,b.CABINA_TIPO_DESCRIPCION from ZAFFA_TEAM.Cabina a JOIN ZAFFA_TEAM.Tipo_Cabina b on a.CABINA_TIPO_ID = b.CABINA_TIPO_ID where CRUCERO_ID = '" + crucero_id + "'";
            string b = "select a.CABINA_NRO,a.CABINA_PISO,d.CABINA_TIPO_DESCRIPCION from ZAFFA_TEAM.Pasaje a join ZAFFA_TEAM.Cabina c on a.CRUCERO_ID = c.CRUCERO_ID and a.CABINA_NRO = c.CABINA_NRO and a.CABINA_PISO = c.CABINA_PISO join ZAFFA_TEAM.Tipo_Cabina d on c.CABINA_TIPO_ID = d.CABINA_TIPO_ID where a.CRUCERO_ID = '" + crucero_id + "' and a.VIAJE_ID= " + viaje_id;
            string c = "select a.CABINA_NRO,a.CABINA_PISO,d.CABINA_TIPO_DESCRIPCION from ZAFFA_TEAM.Reserva a join ZAFFA_TEAM.Cabina c on a.CRUCERO_ID = c.CRUCERO_ID and a.CABINA_NRO = c.CABINA_NRO and a.CABINA_PISO = c.CABINA_PISO join ZAFFA_TEAM.Tipo_Cabina d on c.CABINA_TIPO_ID = d.CABINA_TIPO_ID where a.CRUCERO_ID = '" + crucero_id + "' and a.VIAJE_ID= " + viaje_id;
            string query = a + " EXCEPT " + b + " EXCEPT " + c; 
            
            SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader.GetDecimal(0).ToString(), reader.GetDecimal(1).ToString(), reader.GetString(2));
                contador++;
            }
            reader.Close();
            textBox1.Text = contador.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SacarPasaje pas = new SacarPasaje(rolSeleccionado);
            pas.Visible = true;
            this.Dispose(false);
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() != "")
            {
                dataGridView1.CurrentRow.Selected = true;
                String cabina_nro = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                String cabina_piso = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                String tipo_cabina = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();

                RegistroViajeCliente reg = new RegistroViajeCliente(viaje_id, fecha_salida, fecha_llegada,
                                                            crucero_id, cabina_nro, cabina_piso, tipo_cabina,rolSeleccionado);
                reg.Visible = true;
                this.Dispose(false);
                this.Close();
            }
        }
    }
}
