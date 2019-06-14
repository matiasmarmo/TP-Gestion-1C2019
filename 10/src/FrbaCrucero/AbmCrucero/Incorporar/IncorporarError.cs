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
    public partial class IncorporarError : Form
    {
        string rolSeleccionado;

        public IncorporarError(string unRol)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            rolSeleccionado = unRol;
        }

        private void volver_cru_Click(object sender, EventArgs e)
        {
            IncorporarCrucero incorporar = new IncorporarCrucero(rolSeleccionado);
            incorporar.Visible = true;
            this.Dispose(false);
        }
    }
}
