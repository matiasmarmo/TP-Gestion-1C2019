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
    public partial class FinModificar : Form
    {
        public FinModificar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rol crear = new Rol();
            crear.Visible = true;
            this.Dispose(false);
        }

        private void otro_rol_Click(object sender, EventArgs e)
        {
            ModificarRol modificar = new ModificarRol();
            modificar.Visible = true;
            this.Dispose(false);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
