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
    public partial class BajaCrucero : Form
    {
        string rolSeleccionado;
        string id;

        public BajaCrucero(string unRol, string unID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            rolSeleccionado = unRol;
            id = unID;
        }

        private void baja_definitiva_Click(object sender, EventArgs e)
        {
            BajaDef fin = new BajaDef(rolSeleccionado,id);
            fin.Visible = true;
            this.Dispose(false);
            // BORRO DEFINITIVAMENTE CRUCERO

            // HAGO UPDATE ESTADO CRU
        }

        private void fuera_servicio_Click(object sender, EventArgs e)
        {
            Fds fds = new Fds(rolSeleccionado,id);
            fds.Visible = true;
            this.Dispose(false);
            // SELECCIONO FECHA

            // HAGO UPDATE ESTADO CRU
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            CruceroListado listado = new CruceroListado(false, rolSeleccionado);
            listado.Visible = true;
            this.Dispose(false);
        }
    }
}
