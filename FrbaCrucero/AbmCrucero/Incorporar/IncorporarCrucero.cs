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
    public partial class IncorporarCrucero : Form
    {
        public IncorporarCrucero()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            nombreID.ResetText();
            fabricanteCru.ResetText();
            modeloCru.ResetText();
            CargarCabinas cabinas = new CargarCabinas();
            cabinas.Visible = true;
            this.Dispose(false);
            // CARGO LA NUEVA FUNCIONALIDAD A BDD
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            Crucero crucero = new Crucero();
            crucero.Visible = true;
            this.Dispose(false);
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            nombreID.ResetText();
            fabricanteCru.ResetText();
            modeloCru.ResetText();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void fabricanteCru_TextChanged(object sender, EventArgs e)
        {

        }

        private void fabricanteCru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
