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
    public partial class Crucero : Form
    {
        string rolSeleccionado;

        public Crucero(string unRol)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            rolSeleccionado = unRol;
        }

        private void incorporar_crucero_Click(object sender, EventArgs e)
        {
            IncorporarCrucero incorporar = new IncorporarCrucero(rolSeleccionado);
            incorporar.Visible = true;
            this.Dispose(false);
        }

        private void modificar_crucero_Click(object sender, EventArgs e)
        {
            bool tipoListado = true;
            CruceroListado modificar = new CruceroListado(tipoListado, rolSeleccionado);
            modificar.Visible = true;
            this.Dispose(false);
        }

        private void baja_crucero_Click(object sender, EventArgs e)
        {
            bool tipoListado = false;
            CruceroListado baja = new CruceroListado(tipoListado, rolSeleccionado);
            baja.Visible = true;
            this.Dispose(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionalidades func = new Funcionalidades(rolSeleccionado);
            func.Visible = true;
            this.Dispose(false);
        }
    }
}
