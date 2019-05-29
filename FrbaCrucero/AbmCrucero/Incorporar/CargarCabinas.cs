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
    public partial class CargarCabinas : Form
    {
        public CargarCabinas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            nroCab.ResetText();
            pisoCab.ResetText();
            tipoCab.ResetText();
        }

        private void cargar_cabinas_Click(object sender, EventArgs e)
        {
            nroCab.ResetText();
            pisoCab.ResetText();
            tipoCab.ResetText();
            // SE CARGAN LOS DATOS A LA BDD
        }

        private void Finalizar_Click(object sender, EventArgs e)
        {
            IncorporacionAceptada aceptar = new IncorporacionAceptada();
            aceptar.Visible = true;
            this.Dispose(false);
        }
    }
}
