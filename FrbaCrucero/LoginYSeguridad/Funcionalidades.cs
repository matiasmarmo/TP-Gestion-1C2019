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
            label2.Text = rolSeleccionado;
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
             if (string.Compare(selectorFunc.Text, "AbmRol")==0)
             {
                 Rol rol = new Rol(rolSeleccionado);
                 rol.Visible = true;
                 this.Dispose(false);
             }
             if (string.Compare(selectorFunc.Text, "AbmCrucero") == 0)
             {
                 Crucero modificar = new Crucero(rolSeleccionado);
                 modificar.Visible = true;
                 this.Dispose(false);
             }
             if (string.Compare(selectorFunc.Text, "AbmRecorrido") == 0)
             {
                 //Recorrido recorrido = new Recorrido(rolSeleccionado);
                 //recorrido.Visible = true;
                 //this.Dispose(false);
             }
             if (string.Compare(selectorFunc.Text, "CompraReservaPasaje") == 0)
             {
                 //CompraReservaPasaje compra = new CompraReservaPasaje(rolSeleccionado);
                 //compra.Visible = true;
                 //this.Dispose(false);
             }
             if (string.Compare(selectorFunc.Text, "GeneracionViaje") == 0)
             {
                 GeneracionViaje generar = new GeneracionViaje(rolSeleccionado);
                 generar.Visible = true;
                 this.Dispose(false);
             }
             if (string.Compare(selectorFunc.Text, "ListadoEstadistico") == 0)
             {
                 ListadoEstadistico listado = new ListadoEstadistico(rolSeleccionado);
                 listado.Visible = true;
                 this.Dispose(false);
             }
             if (string.Compare(selectorFunc.Text, "PagoReserva") == 0)
             {
                 //PagoReserva reserva = new PagoReserva(rolSeleccionado);
                 //reserva.Visible = true;
                 //this.Dispose(false);
             }
         }

         private void Funcionalidades_Load(object sender, EventArgs e)
         {

         }


    }
}
