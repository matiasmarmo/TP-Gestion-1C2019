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
    public partial class IncorporacionAceptada : Form
    {
        string rolSeleccionado;

        public IncorporacionAceptada(string unRol)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            rolSeleccionado = unRol;
        }

        private void inicio_Click(object sender, EventArgs e)
        {
            Crucero cru = new Crucero(rolSeleccionado);
            cru.Visible = true;
            this.Dispose(false);
        }

        private void otro_cru_Click(object sender, EventArgs e)
        {
            IncorporarCrucero incorporar = new IncorporarCrucero(rolSeleccionado);
            incorporar.Visible = true;
            this.Dispose(false);
        }
    }
}
