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
    public partial class CrearRol : Form
    {
        int id;

        string rolSeleccionado;

        public CrearRol(string unRol)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            rolSeleccionado = unRol;
        }

        private void funcionalidadesE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Atras_Click(object sender, EventArgs e)
        {
            Rol crear = new Rol(rolSeleccionado);
            crear.Visible = true;
            this.Dispose(false);
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nombreC.Text) || (!AbmRol.Checked && !AbmCrucero.Checked
                && !AbmPuerto.Checked && !AbmRecorrido.Checked && !ComprarReservaPasaje.Checked
                && !GeneracionViaje.Checked && !ListadoEstadistico.Checked && !PagoReserva.Checked))
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
            else
            {
                try
                {
                    this.guardarRol();
                    if (AbmRol.Checked)
                    {
                        try
                        {
                            string query = "SELECT FUNCIONALIDAD FROM ZAFFA_TEAM.Funcionalidad WHERE descripcion_func LIKE '%" + AbmRol.Text + "%'";
                            obtenerIdFunc(ClaseConexion.ResolverConsulta(query));
                            this.guardarFuncxRol();
                            MessageBox.Show("Rol guardado " + AbmRol.Text + " correctamente", "Ok");
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Error al guardar la funcionalidad " + AbmRol.Text + " del rol", "Ok");
                        }
                    }
                    if (AbmCrucero.Checked)
                    {
                        try
                        {
                            string query = "SELECT FUNCIONALIDAD FROM ZAFFA_TEAM.Funcionalidad WHERE descripcion_func LIKE '%" + AbmCrucero.Text + "%'";
                            obtenerIdFunc(ClaseConexion.ResolverConsulta(query));
                            this.guardarFuncxRol();
                            MessageBox.Show("Rol guardado " + AbmCrucero.Text + " correctamente", "Ok");
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Error al guardar la funcionalidad " + AbmCrucero.Text + " del rol", "Ok");
                        }
                    }
                    if (AbmPuerto.Checked)
                    {
                        try
                        {
                            string query = "SELECT FUNCIONALIDAD FROM ZAFFA_TEAM.Funcionalidad WHERE descripcion_func LIKE '%" + AbmPuerto.Text + "%'";
                            obtenerIdFunc(ClaseConexion.ResolverConsulta(query));
                            this.guardarFuncxRol();
                            MessageBox.Show("Rol guardado " + AbmPuerto.Text + " correctamente", "Ok");
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Error al guardar la funcionalidad " + AbmPuerto.Text + " del rol", "Ok");
                        }
                    }
                    if (AbmRecorrido.Checked)
                    {
                        try
                        {
                            string query = "SELECT FUNCIONALIDAD FROM ZAFFA_TEAM.Funcionalidad WHERE descripcion_func LIKE '%" + AbmRecorrido.Text + "%'";
                            obtenerIdFunc(ClaseConexion.ResolverConsulta(query));
                            this.guardarFuncxRol();
                            MessageBox.Show("Rol guardado " + AbmRecorrido.Text + " correctamente", "Ok");
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Error al guardar la funcionalidad " + AbmRecorrido.Text + " del rol", "Ok");
                        }
                    }
                    if (ComprarReservaPasaje.Checked)
                    {
                        try
                        {
                            string query = "SELECT FUNCIONALIDAD FROM ZAFFA_TEAM.Funcionalidad WHERE descripcion_func LIKE '%" + ComprarReservaPasaje.Text + "%'";
                            obtenerIdFunc(ClaseConexion.ResolverConsulta(query));
                            this.guardarFuncxRol();
                            MessageBox.Show("Rol guardado " + ComprarReservaPasaje.Text + " correctamente", "Ok");
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Error al guardar la funcionalidad " + ComprarReservaPasaje.Text + " del rol", "Ok");
                        }
                    }
                    if (GeneracionViaje.Checked)
                    {
                        try
                        {
                            string query = "SELECT FUNCIONALIDAD FROM ZAFFA_TEAM.Funcionalidad WHERE descripcion_func LIKE '%" + GeneracionViaje.Text + "%'";
                            obtenerIdFunc(ClaseConexion.ResolverConsulta(query));
                            this.guardarFuncxRol();
                            MessageBox.Show("Rol guardado " + GeneracionViaje.Text + " correctamente", "Ok");
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Error al guardar la funcionalidad " + GeneracionViaje.Text + " del rol", "Ok");
                        }
                    }
                    if (ListadoEstadistico.Checked)
                    {
                        try
                        {
                            string query = "SELECT FUNCIONALIDAD FROM ZAFFA_TEAM.Funcionalidad WHERE descripcion_func LIKE '%" + ListadoEstadistico.Text + "%'";
                            obtenerIdFunc(ClaseConexion.ResolverConsulta(query));
                            this.guardarFuncxRol();
                            MessageBox.Show("Rol guardado " + ListadoEstadistico.Text + " correctamente", "Ok");
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Error al guardar la funcionalidad " + ListadoEstadistico.Text + " del rol", "Ok");
                        }
                    }
                    if (PagoReserva.Checked)
                    {
                        try
                        {
                            string query = "SELECT FUNCIONALIDAD FROM ZAFFA_TEAM.Funcionalidad WHERE descripcion_func LIKE '%" + PagoReserva.Text + "%'";
                            obtenerIdFunc(ClaseConexion.ResolverConsulta(query));
                            this.guardarFuncxRol();
                            MessageBox.Show("Rol guardado " + PagoReserva.Text + " correctamente", "Ok");
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Error al guardar la funcionalidad " + PagoReserva.Text + " del rol", "Ok");
                        }
                    }
                    FinRol fin = new FinRol(rolSeleccionado);
                    fin.Visible = true;
                    this.Dispose(false);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Error al guardar el rol " + nombreC.Text + " pues ya existe", "Error");
                }
            }
        }

        private void guardarRol()
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_guardarRol", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre_rol", nombreC.Text);
            cmd.Parameters.AddWithValue("@estado_rol", 'A');

            cmd.ExecuteReader().Close();
        }

        private void guardarFuncxRol()
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_guardarFuncionalidadxRol", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre_rol", nombreC.Text);
            cmd.Parameters.AddWithValue("@funcionalidad", id);

            cmd.ExecuteReader().Close();
        }

        private void obtenerIdFunc(SqlDataReader reader)
        {
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            reader.Close();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            nombreC.ResetText();
            AbmRol.Checked = false;
            AbmCrucero.Checked = false;
            AbmPuerto.Checked = false;
            AbmRecorrido.Checked = false;
            ComprarReservaPasaje.Checked = false;
            GeneracionViaje.Checked = false;
            ListadoEstadistico.Checked = false;
            PagoReserva.Checked = false;
        }

        private void ComprarReservaPasaje_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
