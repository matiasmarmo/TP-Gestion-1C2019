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
    public partial class AbmPuerto : Form
    {
        string rolSeleccionado;

        public AbmPuerto(string unRol)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            rolSeleccionado = unRol;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Funcionalidades listado = new Funcionalidades(rolSeleccionado);
            listado.Visible = true;
            this.Dispose(false);
        }
    }
}
