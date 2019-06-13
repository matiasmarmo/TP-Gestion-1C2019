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
    public partial class BajaError : Form
    {
        string rolSeleccionado;

        public BajaError(string unRol)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            rolSeleccionado = unRol;
        }

        private void volver_baja_Click(object sender, EventArgs e)
        {
            BajaSeleccionarFecha crucero = new BajaSeleccionarFecha(rolSeleccionado);
            crucero.Visible = true;
            this.Dispose(false);
        }
    }
}
