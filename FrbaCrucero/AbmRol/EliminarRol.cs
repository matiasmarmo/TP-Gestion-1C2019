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
    public partial class EliminarRol : Form
    {
        public EliminarRol()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void eliminar_rol_Enter(object sender, EventArgs e)
        {

        }

        private void EliminarRol_Load(object sender, EventArgs e)
        {

        }

        private void nombreE_Click(object sender, EventArgs e)
        {

        }

        private void Atras_Click(object sender, EventArgs e)
        {

        }

        private void funcionalidadesR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {

        }

        private void limpiar_Click(object sender, EventArgs e)
        {

        }

        private void tipo_funcionalidad_Click(object sender, EventArgs e)
        {

        }

        private void limpiar_Click_1(object sender, EventArgs e)
        {
            nombreE.ResetText();
            funcionalidadesE.ResetText();
        }

        private void Atras_Click_1(object sender, EventArgs e)
        {
            Rol crear = new Rol();
            crear.Visible = true;
            this.Dispose(false);
        }

        private void guardar_Click_1(object sender, EventArgs e)
        {
            ErrorEliminar errorE = new ErrorEliminar();
            errorE.Visible = true;
            this.Dispose(false);
            // CHECKEO SI EXISTE DICHA FUNCIONALIDAD EN DICHO USUARIO CASO CONTRARIO MUESTRO ERROR
            // BORRO FUNCIONALIDAD A BDD
        }
    }
}
