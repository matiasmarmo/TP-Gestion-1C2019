using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCrucero
{
    public partial class BajaCrucero : Form
    {
        string rolSeleccionado;
        string cruID;
        string cruModeloDesc;
        string cruModelo;
        string cruMarcaID;
        string estadoCrucero;
        string cantCabinas;

        public BajaCrucero(string unRol, string unID, string unModeloDesc, string unModelo, string unaMarca, string unEstado, string unasCabinas)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            rolSeleccionado = unRol;
            cruID = unID;
            cruModeloDesc = unModeloDesc;
            cruModelo = unModelo;
            cruMarcaID = unaMarca;
            estadoCrucero = unEstado;
            cantCabinas = unasCabinas;
        }

       
        private void baja_definitiva_Click(object sender, EventArgs e)
        {
            BajaDef fin = new BajaDef(rolSeleccionado, cruID, cruModeloDesc, cruModelo, cruMarcaID, estadoCrucero, cantCabinas);
            fin.Visible = true;
            this.Dispose(false);
        }

        private void fuera_servicio_Click(object sender, EventArgs e)
        {
            Fds fds = new Fds(rolSeleccionado,cruID);
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
