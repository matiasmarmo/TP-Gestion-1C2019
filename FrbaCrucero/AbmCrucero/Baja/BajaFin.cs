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
    public partial class BajaFin : Form
    {
        string rolSeleccionado;

        public BajaFin(string unRol)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            rolSeleccionado = unRol;
        }

        private void iniciobaj_Click(object sender, EventArgs e)
        {
            Crucero crucero = new Crucero(rolSeleccionado);
            crucero.Visible = true;
            this.Dispose(false);
        }

        private void otro_baj_Click(object sender, EventArgs e)
        {
            CruceroListado incorporar = new CruceroListado(false, rolSeleccionado);
            incorporar.Visible = true;
            this.Dispose(false);
        }
    }
}
