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
    public partial class ModificarRol : Form
    {
        public ModificarRol()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ModificarRol_Load(object sender, EventArgs e)
        {

        }

        private void Atras_Click(object sender, EventArgs e)
        {
            Rol crear = new Rol();
            crear.Visible = true;
            this.Dispose(false);
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            nombreM.ResetText();
            funcionalidadesM.ResetText();
        }

        private void funcionalidadesE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            ErrorEliminar errorE = new ErrorEliminar();
            errorE.Visible = true;
            this.Dispose(false);
        }
    }
}
