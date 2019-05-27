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
    public partial class CargarBaja : Form
    {
        public CargarBaja()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void atrasBaja_Click(object sender, EventArgs e)
        {
            BajaCrucero crucero = new BajaCrucero();
            crucero.Visible = true;
            this.Dispose(false);
        }

        private void limpiarBaja_Click(object sender, EventArgs e)
        {
            bajaC.ResetText();
        }

        private void darBaja_Click(object sender, EventArgs e)
        {
            BajaError err = new BajaError();
            err.Visible = true;
            this.Dispose(false);
            // CHECKEO TAMBIEN SI LOS DATOS NO SON CORRECTOS
        }
    }
}
