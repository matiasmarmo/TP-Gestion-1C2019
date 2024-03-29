﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

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
            if (rolSelec == "Administrador General")
            {
                String fechaProceso = ConfigurationManager.AppSettings["current_date"].ToString().TrimEnd();
                DateTime date = DateTime.ParseExact(fechaProceso, "dd-MM-yyyy",null);
                SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_borrarReservas", ClaseConexion.conexion);
                cmd.Parameters.AddWithValue("@fecha_actual", date);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteReader().Close();
            }
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
             if (string.Compare(selectorFunc.Text, "AbmRol") == 0)
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
                 AbmRecorrido recorrido = new AbmRecorrido(rolSeleccionado);
                 recorrido.Visible = true;
                 this.Dispose(false);
             }
             if (string.Compare(selectorFunc.Text, "AbmPuerto") == 0)
             {
                 AbmPuerto recorrido = new AbmPuerto(rolSeleccionado);
                 recorrido.Visible = true;
                 this.Dispose(false);
             }
             if (string.Compare(selectorFunc.Text, "CompraReservaPasaje") == 0)
             {
                 SacarPasaje sacarpasaje = new SacarPasaje(rolSeleccionado);
                 sacarpasaje.Visible = true;
                 this.Dispose(false);
                 this.Close();
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
                 ReservaPrincipal reserva = new ReservaPrincipal(rolSeleccionado);
                 reserva.Visible = true;
                 this.Dispose(false);
                 this.Close();
             }
         }

         private void Funcionalidades_Load(object sender, EventArgs e)
         {

         }


    }
}
