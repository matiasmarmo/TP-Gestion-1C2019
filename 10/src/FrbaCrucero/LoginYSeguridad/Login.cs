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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Llenar_ComboBox_Roles();
        }

        private void Llenar_ComboBox_Roles()
        {
            string query = "select NOMBRE_ROL from ZAFFA_TEAM.Rol where ESTADO_ROL = 'A'";
            SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
            while (reader.Read())
            {
                string a = reader.GetString(0);
                selectorRol.Items.Add(a);
            }
            reader.Close();
        }

        private void seleccionRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private Boolean rolSeleccionadoEsAdministrador()
        {
            return selectorRol.Text == "Administrador General";
        }

        private void continuar_Click(object sender, EventArgs e)
        {
            if (selectorRol.Text == "")
            {
                return;
            }
            if (this.rolSeleccionadoEsAdministrador())
            {
                LoginAdministrativo login = new LoginAdministrativo();
                login.Visible = true;
                this.Dispose(false);
                this.Close();
            }
            else
            {

                Funcionalidades func = new Funcionalidades(selectorRol.Text);
                func.Visible = true;
                this.Dispose(false);
                this.Close();
            }
        }

        private void loginYSeguridad_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Close();
        }
        private void loginYSeguridad_Enter(object sender, EventArgs e)
        {

        }

        private void seleccionarRol_Click(object sender, EventArgs e)
        {

        }

        private void selectorRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

