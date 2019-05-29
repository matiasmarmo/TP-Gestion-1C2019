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
    public partial class ModificarCrucero : Form
    {
        public ModificarCrucero()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void modificarCruc_Click(object sender, EventArgs e)
        {
            ModificarError modifError = new ModificarError();
            modifError.Visible = true;
            this.Dispose(false);
        }

        private void atrasMod_Click(object sender, EventArgs e)
        {
            Crucero crucero = new Crucero();
            crucero.Visible = true;
            this.Dispose(false);
        }

        private void limpiarMod_Click(object sender, EventArgs e)
        {
            modC.ResetText();
            fabricanteModif.ResetText();
        }
    }
}
