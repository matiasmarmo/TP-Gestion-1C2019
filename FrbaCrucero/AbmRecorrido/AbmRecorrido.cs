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
        public AbmRecorrido()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaRecorrido altaRecorrido = new AltaRecorrido(1);
            altaRecorrido.Visible = true;
            this.Dispose(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListadoRecorrido listRecorrido = new ListadoRecorrido();
            listRecorrido.Visible = true;
            this.Dispose(false);
            
            
            //ModificarRecorrido modRecorrido = new ModificarRecorrido();
            //modRecorrido.Visible = true;
            //this.Dispose(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListadoRecorrido listRecorrido = new ListadoRecorrido();
            listRecorrido.Visible = true;
            this.Dispose(false);
            
            
            //BajaRecorrido bajaRecorrido = new BajaRecorrido();
            //bajaRecorrido.Visible = true;
            //this.Dispose(false);
        }
    }
}
