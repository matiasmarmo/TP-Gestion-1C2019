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
    public partial class SeleccionarCorrimiento : Form
    {
        string rolSeleccionado;
           
        public SeleccionarCorrimiento(string unRol)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            rolSeleccionado = unRol;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BajaCrucero baja = new BajaCrucero(rolSeleccionado);
            //baja.Visible = true;
            //this.Dispose(false);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(dias.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
            else { 
            
            }
        }
    }
}
