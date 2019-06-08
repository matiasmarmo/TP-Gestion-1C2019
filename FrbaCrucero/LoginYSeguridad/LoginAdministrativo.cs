using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero
{
    public partial class LoginAdministrativo : Form
    {
        public LoginAdministrativo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoginAdministrativo_Load(object sender, EventArgs e)
        {

        }

        private void ingresar_Click(object sender, EventArgs e)
        {

            //chequear que los datos esten en la base
            //Si estan ingreso a funcionalidadesAdm
            //intentos fallidos = 0
            Funcionalidades func = new Funcionalidades("Administrativo");
            func.Visible = true;
            this.Dispose(false);
            //Sino limpio pantalla, "Usuario ingresado incorrecto"
            //intentos fallidos + 1
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
        }
    }
}
