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
            CruceroListado listado = new CruceroListado(true);
            listado.Visible = true;
            this.Dispose(false);
        }

        private void limpiarMod_Click(object sender, EventArgs e)
        {
            fabricanteModif.ResetText();
        }

        private void modC_TextChanged(object sender, EventArgs e)
        {

        }

        private void fabricanteModif_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
