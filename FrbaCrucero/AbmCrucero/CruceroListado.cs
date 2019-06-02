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
    public partial class CruceroListado : Form
    {
        private bool unListado;
        private bool seleccionCorrecta = false;

        public CruceroListado(bool tipoListado)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            unListado = tipoListado;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CruceroListado_Load(object sender, EventArgs e)
        {

        }

        private void limpiarListado_Click(object sender, EventArgs e)
        {
            seleccionarID.ResetText();
            seleccionarFabricante.ResetText();
            seleccionarModelo.ResetText();
        }

        private void buscarListado_Click(object sender, EventArgs e)
        {
            // EJECUTO LAS LINEAS QUE LLENAN MI TABLA
            // listadoDePosibles.
           
        }

        private void atrasListado_Click(object sender, EventArgs e)
        {
            Crucero modificar = new Crucero();
            modificar.Visible = true;
            this.Dispose(false);
        }

        private void modificarListado_Click(object sender, EventArgs e)
        {
            if (!seleccionCorrecta)
            {
                if (unListado)
                {
                    ModificarCrucero modificar = new ModificarCrucero();
                    modificar.Visible = true;
                    this.Dispose(false);
                }
                else
                {
                    BajaCrucero baja = new BajaCrucero();
                    baja.Visible = true;
                    this.Dispose(false);
                }
            }
            else {
                ModificarError error = new ModificarError();
                error.Visible = true;
                this.Dispose(false);
            } 
        }
    }
}
