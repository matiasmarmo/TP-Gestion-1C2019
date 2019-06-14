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
    public partial class OperacionExitosa : Form
    {

        String rolSeleccionado;

        public OperacionExitosa(String rol)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            rolSeleccionado = rol;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbmRecorrido abmRecorrido = new AbmRecorrido(rolSeleccionado);
            abmRecorrido.Visible = true;
            this.Dispose(false);
        }
    }
}
