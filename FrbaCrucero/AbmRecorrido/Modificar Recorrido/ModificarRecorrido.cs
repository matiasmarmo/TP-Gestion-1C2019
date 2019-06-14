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
    public partial class ModificarRecorrido : Form
    {

        string codRecorrido;
        int nroTramo;
        string puertoDesdeID;
        string puertoHastaID;
        string precioBase;
        string rolSeleccionado;
        int contadorTramos;
        int contAct;


        public ModificarRecorrido(string idRecorrido, string nTramo, string puertoD, string puertoH, string precio,int cont,string rol)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            codRecorrido = idRecorrido;
            nroTramo = int.Parse(nTramo);
            puertoDesdeID = puertoD;
            puertoHastaID = puertoH;
            precioBase = precio;
            rolSeleccionado = rol;
            contAct = cont;
            contadorTramos = this.ContadorDeTramos();
            this.Llenar_box1();
            this.Llenar_box2();
            this.Llenar_ComboBox1();
            this.Llenar_ComboBox2();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListadoRecorrido listadoRecorrido = new ListadoRecorrido(true,rolSeleccionado);
            listadoRecorrido.Visible = true;
            this.Dispose(false);
        }


        private void Llenar_box1()
        {
            if (contAct == 1)
            {
                string query = "SELECT NOMBRE_PUERTO FROM ZAFFA_TEAM.Puerto WHERE PUERTO_ID = " + int.Parse(puertoDesdeID);
                SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
                while (reader.Read())
                {
                    puertoDBox.Text = reader.GetString(0).Trim();
                }
                reader.Close();
            }
            else
            {
                
                string query2 = "SELECT NOMBRE_PUERTO FROM ZAFFA_TEAM.Puerto WHERE NOMBRE_PUERTO = '" + puertoDesdeID + "'";
                SqlDataReader reader2 = ClaseConexion.ResolverConsulta(query2);
                while (reader2.Read())
                {
                    puertoDBox.Text = reader2.GetString(0).Trim();
                }
                reader2.Close();

            }
        }

        private void Llenar_box2()
        {
            if (contAct == 1)
            {
                string query2 = "SELECT NOMBRE_PUERTO FROM ZAFFA_TEAM.Puerto WHERE PUERTO_ID = " + int.Parse(puertoHastaID);
                SqlDataReader reader = ClaseConexion.ResolverConsulta(query2);
                while (reader.Read())
                {

                    puertoHBox.Text = reader.GetString(0).Trim();
                }
                reader.Close();
            }
            else
            {
                string query3 = "SELECT NOMBRE_PUERTO FROM ZAFFA_TEAM.Puerto WHERE NOMBRE_PUERTO = '" + puertoHastaID + "'";
                SqlDataReader reader3 = ClaseConexion.ResolverConsulta(query3);
                while (reader3.Read())
                {

                    puertoHBox.Text = reader3.GetString(0).Trim();
                }
                reader3.Close();
            }
        }


        private void Llenar_ComboBox1()
        {
            if (contAct == 1)
            {
                string query = "select NOMBRE_PUERTO from ZAFFA_TEAM.Puerto";
                SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
                while (reader.Read())
                {
                    string puerto = reader.GetString(0).Trim();
                    puertoDesdeBox.Items.Add(puerto);
                }
                reader.Close();
            }
            else
            {

                string query2 = "select NOMBRE_PUERTO from ZAFFA_TEAM.Puerto WHERE NOMBRE_PUERTO = '" + puertoHastaID + "'";
                SqlDataReader reader2 = ClaseConexion.ResolverConsulta(query2);
                while (reader2.Read())
                {
                    string puerto = reader2.GetString(0).Trim();
                    puertoDesdeBox.Items.Add(puerto);
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
                puertoHastaBox.Items.Add(puerto);
            }
            reader.Close();
        }

        private int ContadorDeTramos()
        {
            string query3 = "select count(RECORRIDO_CODIGO) nroRecorridos from ZAFFA_TEAM.Tramo where RECORRIDO_CODIGO =" + codRecorrido;
            SqlDataReader reader = ClaseConexion.ResolverConsulta(query3);
            reader.Read();

            String cuantosRecorridos = reader.GetInt32(0).ToString();

            reader.Close();

            return int.Parse(cuantosRecorridos);
        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(nuevoPrecioBox.Text) && puertoDesdeBox.Text == puertoHastaBox.Text){
                MessageBox.Show("Los puertos deben ser distintos y debe ingresar un precio", "Error");
            }
            else
            {
                try
                {


                    puertoDesdeID = puertoDesdeBox.Text;
                    puertoHastaID = puertoHastaBox.Text;
                    precioBase = nuevoPrecioBox.Text;

                        if (contAct == contadorTramos)
                        {
                            nroTramo = nroTramo + 1;
                            MessageBox.Show(nroTramo.ToString());
                            this.actualizarTramo();
                            MessageBox.Show("Todo el tramo fue actualizado", "OK");
                            AbmRecorrido abmRec = new AbmRecorrido(rolSeleccionado);
                            abmRec.Visible = true;
                            this.Dispose(false);

                            
                        }
                        else
                        {
                            
                            contAct = contAct + 1;
                            this.actualizarTramo();
                            SeguirModificando sMod = new SeguirModificando(codRecorrido, nroTramo.ToString(), puertoDesdeID, puertoHastaID, precioBase, contAct, rolSeleccionado);
                            sMod.Visible = true;
                            this.Dispose(false);
 

                        }
                    }

                
                catch (SqlException)
                {
                    MessageBox.Show("Volver a intentar", "Error");
                }
            }

        }


        private void actualizarTramo()
        {

            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_updateTramo", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codRec", Decimal.Parse(codRecorrido));
            cmd.Parameters.AddWithValue("@ordenTramo", nroTramo);
            cmd.Parameters.AddWithValue("@puertoD", puertoDesdeID);
            cmd.Parameters.AddWithValue("@puertoA", puertoHastaID);
            cmd.Parameters.AddWithValue("@nuevoPrecio", Decimal.Parse(precioBase));

            cmd.ExecuteReader().Close();
            MessageBox.Show("Actualizando recorrido", "loading");
        }

    }
}
