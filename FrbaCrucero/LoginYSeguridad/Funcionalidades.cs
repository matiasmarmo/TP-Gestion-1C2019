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
    public partial class Funcionalidades : Form
    {
        private string rolSeleccionado;

        public Funcionalidades(string rolSelec)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.rolSeleccionado = rolSelec;
            this.Llenar_ComboBox_Funcionalidades();
        }


        private void btn_atras_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.ShowDialog();
            this.Close();
        }

        private void Llenar_ComboBox_Funcionalidades()
        {
            string query = "select b.DESCRIPCION_FUNC from ZAFFA_TEAM.[Funcionalidad x Rol] a JOIN ZAFFA_TEAM.Funcionalidad b ON a.FUNCIONALIDAD = b.FUNCIONALIDAD where NOMBRE_ROL = '" + this.rolSeleccionado + "'";
            SqlDataReader reader = ClaseConexion.ResolverConsulta(query);
            while (reader.Read()){
                string a = reader.GetString(0);
                selectorFunc.Items.Add(a);
            }
            reader.Close();
        }

        private void selectorFunc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
         private void button2_Click(object sender, EventArgs e)
        {

        }

         private void button2_Click_1(object sender, EventArgs e)
         {

         }


    }
}
