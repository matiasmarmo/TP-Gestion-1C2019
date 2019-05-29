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
    public partial class CabinaError : Form
    {
        public CabinaError()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void volver_cru_Click(object sender, EventArgs e)
        {
            CargarCabinas cabinas = new CargarCabinas();
            cabinas.Visible = true;
            this.Dispose(false);
        }
    }
}
