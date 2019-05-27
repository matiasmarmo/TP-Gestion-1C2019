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
    public partial class ModificarFin : Form
    {
        public ModificarFin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void otro_mod_Click(object sender, EventArgs e)
        {
            ModificarCrucero incorporar = new ModificarCrucero();
            incorporar.Visible = true;
            this.Dispose(false);
        }

        private void iniciomod_Click(object sender, EventArgs e)
        {
            Crucero crucero = new Crucero();
            crucero.Visible = true;
            this.Dispose(false);
        }
    }
}
