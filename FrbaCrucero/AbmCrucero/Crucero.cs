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
    public partial class Crucero : Form
    {
        public Crucero()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void incorporar_crucero_Click(object sender, EventArgs e)
        {
            IncorporarCrucero incorporar = new IncorporarCrucero();
            incorporar.Visible = true;
            this.Dispose(false);
        }

        private void modificar_crucero_Click(object sender, EventArgs e)
        {

        }

        private void baja_crucero_Click(object sender, EventArgs e)
        {
            BajaCrucero incorporar = new BajaCrucero();
            incorporar.Visible = true;
            this.Dispose(false);
        }
    }
}
