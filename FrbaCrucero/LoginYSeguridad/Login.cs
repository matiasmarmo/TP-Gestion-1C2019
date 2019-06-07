using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero
{
    public partial class Login : Form
    {



        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void seleccionRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private Boolean rolSeleccionadoEsAdministrador()
        {

            return selectorRol.Text == "Administrativo";

   
        }

        private void continuar_Click(object sender, EventArgs e)
        {
            if (this.rolSeleccionadoEsAdministrador())
            {

                LoginAdministrativo login = new LoginAdministrativo();
                login.Visible = true;
                this.Dispose(false);
            }
            else
            {

                Funcionalidades func = new Funcionalidades();
                func.Visible = true;
                this.Dispose(false);

            }
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

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2019DataSet1.Rol' table. You can move, or remove it, as needed.
            this.rolTableAdapter.Fill(this.gD1C2019DataSet1.Rol);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rolTableAdapter.FillBy(this.gD1C2019DataSet1.Rol);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


    }
}
