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
    public partial class BajaCrucero : Form
    {
        public BajaCrucero()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void baja_definitiva_Click(object sender, EventArgs e)
        {
            CargarBaja crucero = new CargarBaja();
            crucero.Visible = true;
            this.Dispose(false);
            // SETEO UNA VARIABLE QUE ME REFERENCIA A BAJA DEFINITIVA
        }

        private void fuera_servicio_Click(object sender, EventArgs e)
        {
            CargarBaja crucero = new CargarBaja();
            crucero.Visible = true;
            this.Dispose(false);
            // SETEO UNA VARIABLE QUE ME REFERENCIA A FUERA DE SERVICIO
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            Crucero crucero = new Crucero();
            crucero.Visible = true;
            this.Dispose(false);
        }
    }
}
