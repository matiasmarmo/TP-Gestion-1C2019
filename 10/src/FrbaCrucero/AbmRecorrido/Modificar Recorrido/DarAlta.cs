using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero
{
    public partial class DarAlta : Form
    {

        String rolSeleccionado;
        String recID;


        public DarAlta(String rol, String recid)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            recID = recid;
            rolSeleccionado = rol;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListadoRecorrido listRec = new ListadoRecorrido(rolSeleccionado);
            listRec.Visible = true;
            this.Dispose(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                this.darDeAltaRecorrido();
                MessageBox.Show("Se dio de alta corretamente");
                ListadoRecorrido listRec = new ListadoRecorrido(rolSeleccionado);
                listRec.Visible = true;
                this.Dispose(false);
            }
            catch (SqlException)
            {
                MessageBox.Show("Volver a intentar", "Error");
            }
        }

        private void darDeAltaRecorrido()
        {


            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_altaTramo", ClaseConexion.conexion);

            String id_recorrido = Decimal.Parse(recID).ToString();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_recorrido", id_recorrido);

            cmd.ExecuteReader().Close();
            MessageBox.Show("Dando de alta recorrido", "loading");


        }


    }
}
