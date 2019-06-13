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
    public partial class Fds : Form
    {
        string rolSeleccionado;
        string id;

        public Fds(string unRol, string unID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            rolSeleccionado = unRol;
            id = unID;
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
            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
            else
            {
                if (string.Compare(comboBox1.Text, "Reprogramarlos para cuando el crucero vuelva") == 0) // selecciono cant dias
                {
                    SeleccionarCorrimiento corr = new SeleccionarCorrimiento(rolSeleccionado);
                    corr.Visible = true;
                    this.Dispose(false);
                }
                else // cancelo pasajes
                {
                    MessageBox.Show("Pasajes cancelados correctamente", "Volver al menú");
                    Crucero cru = new Crucero(rolSeleccionado);
                    cru.Visible = true;
                    this.Dispose(false);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            comboBox1.ResetText();
        }
    }
}
