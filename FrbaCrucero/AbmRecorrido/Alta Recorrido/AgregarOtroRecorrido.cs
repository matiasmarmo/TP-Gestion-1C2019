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
    public partial class AgregarOtroRecorrido : Form
    {
        int indiceActualizado;

        public AgregarOtroRecorrido(int indiceNroRecorrido)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            indiceActualizado = indiceNroRecorrido++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AltaRecorrido altaRecorrido = new AltaRecorrido(indiceActualizado);
            altaRecorrido.Visible = true;
            this.Dispose(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AltaRecorrido altaRecorrido = new AltaRecorrido(indiceActualizado--);
            altaRecorrido.Visible = true;
            this.Dispose(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operacion realizada con exito");
        }
    }
}
