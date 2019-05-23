using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmPuerto
{
    public partial class AbmPuerto : Form
    {
        public AbmPuerto()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //para que la pantalla esta centrada
        }

        private void crearPuerto_Click(object sender, EventArgs e)
        {
            CrearPuerto crearPuerto = new CrearPuerto();
            crearPuerto.Visible = true;
            this.Dispose(false);
        }

        private void AbmPuerto_Load(object sender, EventArgs e)
        {

        }

        private void modificarPuerto_Click(object sender, EventArgs e)
        {
            ModificarPuerto modPuerto = new ModificarPuerto();
            modPuerto.Visible = true;
            this.Dispose(false);
        }

        private void darDeBajaPuerto_Click(object sender, EventArgs e)
        {
            BajaPuerto bajaPuerto = new BajaPuerto();
            bajaPuerto.Visible = true;
            this.Dispose(false);
        }
    }
}
