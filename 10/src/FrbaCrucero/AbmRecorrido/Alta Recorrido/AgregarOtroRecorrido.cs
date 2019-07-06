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
    public partial class AgregarOtroRecorrido : Form
    {
        int indiceActualizado;
        String rolSeleccionado;
        String codRecorridoActualizado;
        String puertoDAct;

        public AgregarOtroRecorrido(int indiceNroRecorrido, String codRec, String puertoD, String rol)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            codRecorridoActualizado = codRec;
            puertoDAct = puertoD;
            indiceActualizado = indiceNroRecorrido;
            rolSeleccionado = rol;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            indiceActualizado = indiceActualizado + 1;
            AltaRecorrido altaRecorrido = new AltaRecorrido(indiceActualizado,codRecorridoActualizado,puertoDAct,rolSeleccionado);
            altaRecorrido.Visible = true;
            this.Dispose(false);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OperacionExitosa opExitosa = new OperacionExitosa(rolSeleccionado);
            opExitosa.Visible = true;
            this.Dispose(false);
        }
    }
}
