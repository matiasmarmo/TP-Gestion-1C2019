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
    public partial class AbmRecorrido : Form
    {

        string rolSeleccionado;

        public AbmRecorrido(String rol)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            rolSeleccionado = rol;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaRecorrido altaRecorrido = new AltaRecorrido(1, "" ,"",rolSeleccionado);
            altaRecorrido.Visible = true;
            this.Dispose(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListadoRecorrido listRecorrido = new ListadoRecorrido(rolSeleccionado);
            listRecorrido.Visible = true;
            this.Dispose(false);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListadoBaja listadoBaja = new ListadoBaja(rolSeleccionado);
            listadoBaja.Visible = true;
            this.Dispose(false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Funcionalidades func = new Funcionalidades(rolSeleccionado);
            func.Visible = true;
            this.Dispose(false);
        }
    }
}
