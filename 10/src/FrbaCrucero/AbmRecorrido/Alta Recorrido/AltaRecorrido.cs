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
    public partial class AltaRecorrido : Form
    {
        //indice para indicar el nro de tramo
        int indiceNroRecorrido;
        String rolSeleccionado;
        String codRecorridoActualizado;
        String puertoDActualizado;


        public AltaRecorrido(int indiceActualizado,String codRec,String puertoD,String rol)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            indiceNroRecorrido = indiceActualizado;
            codRecorridoActualizado = codRec;
            puertoDActualizado = puertoD;
            rolSeleccionado = rol;
            this.Llenar_ComboBox1();
            this.Llenar_ComboBox2();
            
        }

        private void Llenar_ComboBox1()
        {

            if (indiceNroRecorrido == 1)
            {
                string query = "select NOMBRE_PUERTO from ZAFFA_TEAM.Puerto";
                SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
                while (reader.Read())
                {
                    string puerto = reader.GetString(0).Trim();
                    puertoDesde.Items.Add(puerto);
                }
                reader.Close();
            }else {

                idRecorrido.Text = codRecorridoActualizado;

                string query2 = "select NOMBRE_PUERTO from ZAFFA_TEAM.Puerto where NOMBRE_PUERTO = '" + puertoDActualizado + "'";
                SqlDataReader reader2 = ClaseConexion.ResolverConsulta(query2);
                while (reader2.Read())
                {
                    string puerto2 = reader2.GetString(0).Trim();
                    puertoDesde.Items.Add(puerto2);
                }
                reader2.Close();
            
            }
        }

        private void Llenar_ComboBox2()
        {
            string query = "select NOMBRE_PUERTO from ZAFFA_TEAM.Puerto";
            SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
            while (reader.Read())
            {
                string puerto = reader.GetString(0).Trim();
                puertoHasta.Items.Add(puerto);
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbmRecorrido abmRecorrido = new AbmRecorrido(rolSeleccionado);
            abmRecorrido.Visible = true;
            this.Dispose(false);
        }


        private void button3_Click(object sender, EventArgs e)
        {

            
            if (String.IsNullOrWhiteSpace(puertoHasta.Text) || String.IsNullOrWhiteSpace(puertoDesde.Text) || String.IsNullOrWhiteSpace(idRecorrido.Text) || String.IsNullOrWhiteSpace(precio.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error");

                }else if (idRecorrido.Text.LongCount() != 8){

                    MessageBox.Show("El ID recorrido debe ser de 8 digitos", "Error");

                }else if(puertoDesde.Text == puertoHasta.Text){

                    MessageBox.Show("Los puertos deben ser distintos", "Error");

                }else if (Double.Parse(precio.Text) <= 0){

                    MessageBox.Show("El precio debe ser mayor a cero", "Error");
            }else //si no hay ningun error
            {
                try
                {
                    if (indiceNroRecorrido == 1)
                    {
                        codRecorridoActualizado = idRecorrido.Text;
                        puertoDActualizado = puertoHasta.Text;
                        this.guardarRecorrido();
                        MessageBox.Show("Recorrido guardado correctamente", "Ok");
                        AgregarOtroRecorrido agregarOtroRecorrido = new AgregarOtroRecorrido(indiceNroRecorrido, codRecorridoActualizado,puertoDActualizado, rolSeleccionado);
                        agregarOtroRecorrido.Visible = true;
                        this.Dispose(false);
                    }
                    else
                    {
                        
                        this.guardarSoloTramo();
                        puertoDActualizado = puertoHasta.Text;
                        MessageBox.Show("Recorrido guardado correctamente", "Ok");
                        AgregarOtroRecorrido agregarOtroRecorrido = new AgregarOtroRecorrido(indiceNroRecorrido, codRecorridoActualizado,puertoDActualizado, rolSeleccionado);
                        agregarOtroRecorrido.Visible = true;
                        this.Dispose(false);

                    }

                }
                catch (SqlException)
                {
                    MessageBox.Show("No debe modificar el ID o el recorrido ya existe", "Error al crear recorrido");
                }
            }
        }

        private void guardarRecorrido()
        {

            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_guardarRecorrido", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_recorrido", idRecorrido.Text);
            cmd.Parameters.AddWithValue("@orden_tramo", indiceNroRecorrido);
            cmd.Parameters.AddWithValue("@puerto_desde", puertoDesde.Text);
            cmd.Parameters.AddWithValue("@puerto_hasta", puertoHasta.Text);
            cmd.Parameters.AddWithValue("@precio_recorrido", precio.Text);

            cmd.ExecuteReader().Close();
        }

        private void guardarSoloTramo()
        {

            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_guardarSoloTramo", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_recorrido", idRecorrido.Text);
            cmd.Parameters.AddWithValue("@orden_tramo", indiceNroRecorrido);
            cmd.Parameters.AddWithValue("@puerto_desde", puertoDActualizado);
            cmd.Parameters.AddWithValue("@puerto_hasta", puertoHasta.Text);
            cmd.Parameters.AddWithValue("@precio_recorrido", precio.Text);

            cmd.ExecuteReader().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idRecorrido.ResetText();
            puertoDesde.ResetText();
            puertoHasta.ResetText();
            precio.ResetText();

        }

        private void precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void idRecorrido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
