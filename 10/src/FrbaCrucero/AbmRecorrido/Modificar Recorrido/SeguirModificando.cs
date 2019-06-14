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
    public partial class SeguirModificando : Form
    {

        string codRecorrido;
        int nroTramo;
        string puertoDesdeID;
        string puertoHastaID;
        string precioBase;
        string rolSeleccionado;
        int contAct;

        public SeguirModificando(string idRecorrido, string nTramo, string puertoD, string puertoH, string precio, int cont, string rol)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            codRecorrido = idRecorrido;
            nroTramo = int.Parse(nTramo);
            puertoDesdeID = puertoD;
            puertoHastaID = puertoH;
            precioBase = precio;
            rolSeleccionado = rol;
            contAct = cont;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModificarRecorrido modRec = new ModificarRecorrido(codRecorrido, nroTramo.ToString(), puertoDesdeID, puertoHastaID, precioBase, contAct, rolSeleccionado);
            modRec.Visible = true;
            this.Dispose(false);
        }
    }
}
