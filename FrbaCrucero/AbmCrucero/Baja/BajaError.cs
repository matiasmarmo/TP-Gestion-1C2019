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
        public BajaError()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void volver_baja_Click(object sender, EventArgs e)
        {
            CargarBaja crucero = new CargarBaja();
            crucero.Visible = true;
            this.Dispose(false);
        }
    }
}
