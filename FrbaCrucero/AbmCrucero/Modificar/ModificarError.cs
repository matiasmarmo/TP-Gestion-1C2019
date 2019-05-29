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
    public partial class ModificarError : Form
    {
        public ModificarError()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void volver_mod_Click(object sender, EventArgs e)
        {
            ModificarCrucero incorporar = new ModificarCrucero();
            incorporar.Visible = true;
            this.Dispose(false);
        }
    }
}
