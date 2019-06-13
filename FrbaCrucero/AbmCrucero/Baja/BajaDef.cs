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
    public partial class BajaDef : Form
    {
        string rolSeleccionado;
        string id;

        public BajaDef(string unRol, string unID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            rolSeleccionado = unRol;
            id = unID;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fueraServicio_Click(object sender, EventArgs e)
        {
            //BajaCrucero baja = new BajaCrucero(rolSeleccionado);
            //baja.Visible = true;
            //this.Dispose(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
            else {
                if (string.Compare("Intentar asignarlos a otro crucero", comboBox1.Text) == 0)
                {
                    // consulto si hay otro crucero que pueda
                    NuevoCrucero baja = new NuevoCrucero();
                    baja.Visible = true;
                    this.Dispose(false);
                }
                else
                {
                    // cancelo pasajes
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
