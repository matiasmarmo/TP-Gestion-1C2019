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
    public partial class Rol : Form
    {
        private string rolSeleccionado;

        public Rol(string rolSelec)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            rolSeleccionado = rolSelec;
        }

        private void crear_rol_Click(object sender, EventArgs e)
        {
            CrearRol crear = new CrearRol(rolSeleccionado);
            crear.Visible = true;
            this.Dispose(false);
        }

        private void modificar_rol_Click(object sender, EventArgs e)
        {
            bool tipoListado = true;
            ListadoRol listado = new ListadoRol(tipoListado, rolSeleccionado);
            listado.Visible = true;
            this.Dispose(false);
        }

        private void eliminar_rol_Click(object sender, EventArgs e)
        {
            bool tipoListado = false;
            ListadoRol listado = new ListadoRol(tipoListado, rolSeleccionado);
            listado.Visible = true;
            this.Dispose(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionalidades listado = new Funcionalidades(rolSeleccionado);
            listado.Visible = true;
            this.Dispose(false);
        }
    }
}
