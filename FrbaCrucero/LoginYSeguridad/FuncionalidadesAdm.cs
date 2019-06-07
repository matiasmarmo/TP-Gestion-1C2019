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
    public partial class FuncionalidadesAdm : Form
    {
        public FuncionalidadesAdm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginAdministrativo logAdm = new LoginAdministrativo();
            logAdm.Visible = true;
            this.Dispose(false);
        }
    }
}
