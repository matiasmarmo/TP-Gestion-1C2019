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
    public partial class LoginAdministrativo : Form
    {
        public LoginAdministrativo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void LoginAdministrativo_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Close();
        }
        private void LoginAdministrativo_Load(object sender, EventArgs e)
        {

        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            

            string query = "SELECT USERNAME FROM ZAFFA_TEAM.Administrativo WHERE USERNAME = '" + usuario.Text + "' AND ESTADO_ADMIN != 'I'";
            SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
            //  while (reader.Read())
            //  {

            if (reader.Read())
            {
                reader.Close();
                SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_login", ClaseConexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", usuario.Text);
                cmd.Parameters.AddWithValue("@password", contraseña.Text);
                cmd.ExecuteReader().Close();
                string query2 = "SELECT ESTADO_ADMIN,INTENTOS_FALLIDOS FROM ZAFFA_TEAM.Administrativo WHERE USERNAME = '" + usuario.Text + "'";
                SqlDataReader reader2 = ClaseConexion.ResolverConsulta(query2);
                reader2.Read();

                string ESTADO = reader2.GetString(0);
                string INTENTOS_FALLIDOS = reader2.GetSqlInt16(1).ToString();
                reader2.Close();
                if (ESTADO == "I")
                {
                    MessageBox.Show("Ha ingresado la contraseña incorrecta 3 veces, usted ha sido inhabilitado ");
                    usuario.ResetText();
                    contraseña.ResetText();
                }
                else if (INTENTOS_FALLIDOS != "0")
                {
                    MessageBox.Show("Ha ingresado la contraseña incorrecta");
                    usuario.ResetText();
                    contraseña.ResetText();
                }
                else
                {
                    MessageBox.Show("Bienvenido " + usuario.Text);
                    Funcionalidades func = new Funcionalidades("Administrativo");
                    func.Visible = true;
                    this.Dispose(false);
                    this.Close();
                }

            }
            else
            {
                reader.Close();
                MessageBox.Show("El usuario ingresado no se encuentra registrado o habilitado");
                usuario.ResetText();
                contraseña.ResetText();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            usuario.ResetText();
            contraseña.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Visible = true;
            this.Dispose(false);
            this.Close();
        }

        private void loginYSeguridad_Enter(object sender, EventArgs e)
        {

        }
    }
}
