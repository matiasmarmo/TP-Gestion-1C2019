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
    public partial class ModificarRol : Form
    {
        string nom;
        string funcionalidad;
        int id;
        List<string> funcionalidades = new List<string>();
        string nombr;
        string func;
        string nombre_func;

        string cliente = "Cliente";
        string administrativo = "Administrativo";

        string rolSeleccionado;
        

        public ModificarRol(string v1, string v2, string unRol)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            nom = v1;
            funcionalidad = v2;
            rolSeleccionado = unRol;


            funcionalidades.Add("AbmRol");
            funcionalidades.Add("AbmCrucero");
            funcionalidades.Add("AbmPuerto");
            funcionalidades.Add("AbmRecorrido");
            funcionalidades.Add("CompraReservaPasaje");
            funcionalidades.Add("GeneracionViaje");
            funcionalidades.Add("ListadoEstadistico");
            funcionalidades.Add("PagoReserva");

            //DataGridViewColumnSortMode.Programmatic;

            //Listadoxfunc.MultiSelect = true;
            //Listadoxfunc.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            Listadoxfunc.Rows.Clear();
            listadoAgregar.Rows.Clear();

            string query = "SELECT * FROM ZAFFA_TEAM.[Funcionalidad x Rol] WHERE nombre_rol LIKE '" + nom + "'";
            cargarFuncionalidad(ClaseConexion.ResolverConsulta(query));

            string query2 = "SELECT FUNCIONALIDAD FROM ZAFFA_TEAM.Funcionalidad EXCEPT SELECT fr.FUNCIONALIDAD FROM ZAFFA_TEAM.[Funcionalidad x Rol] fr JOIN ZAFFA_TEAM.Funcionalidad f ON fr.FUNCIONALIDAD = f.FUNCIONALIDAD where NOMBRE_ROL LIKE '" + nom + "'";            
            cargarFuncionalidadAgregar(ClaseConexion.ResolverConsulta(query2));
        }

        private void ModificarRol_Load(object sender, EventArgs e)
        {

        }

        private void Atras_Click(object sender, EventArgs e)
        {
            ListadoRol crear = new ListadoRol(true, rolSeleccionado);
            crear.Visible = true;
            this.Dispose(false);
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
        }

        private void buscar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void modificarNombre()
        {
            // CREO UN NUEVO ROL CON MISMO NOMBRE Y ESTADO
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_guardarRol", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre_rol", nuevoNombre.Text);
            cmd.Parameters.AddWithValue("@estado_rol", funcionalidad);

            cmd.ExecuteReader().Close();

            // ACTUALIZO SUS FUNCIONALIDADES
            SqlCommand cmd2 = new SqlCommand("ZAFFA_TEAM.sp_updateNombreFuncionalidadxRol", ClaseConexion.conexion);

            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@nombre_rol", nuevoNombre.Text);
            cmd2.Parameters.AddWithValue("@nombre_viejo", nom);
         
            cmd2.ExecuteReader().Close();


            if (string.Compare(nom, cliente)==0) {
                SqlCommand cmd4 = new SqlCommand("ZAFFA_TEAM.sp_updatClienteRol", ClaseConexion.conexion);

                cmd4.CommandType = CommandType.StoredProcedure;
                cmd4.Parameters.AddWithValue("@nombre_rol", nuevoNombre.Text);
                cmd4.Parameters.AddWithValue("@nombre_original", cliente);
                cliente = nuevoNombre.Text;

                cmd4.ExecuteReader().Close();
            }
            if (string.Compare(nom, administrativo) == 0)
            {
                
                SqlCommand cmd5 = new SqlCommand("ZAFFA_TEAM.sp_updateAdministradorRol", ClaseConexion.conexion);

                cmd5.CommandType = CommandType.StoredProcedure;
                cmd5.Parameters.AddWithValue("@nombre_rol", nuevoNombre.Text);
                cmd5.Parameters.AddWithValue("@nombre_original", administrativo);
                administrativo = nuevoNombre.Text;

                cmd5.ExecuteReader().Close();
            }

            // BORRO ROL VIEJO
            SqlCommand cmd3 = new SqlCommand("ZAFFA_TEAM.sp_deleteRol", ClaseConexion.conexion);

            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.AddWithValue("@nombre_rol", nom);

            cmd3.ExecuteReader().Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nuevoNombre.Text)) {
                MessageBox.Show("Debe completar el nuevo nombre", "Error");
            }
            else {
                try
                {
                    this.modificarNombre();
                    MessageBox.Show("Se ha modificado el nombre del rol", "Ok");
                    nom = nuevoNombre.Text;
                    Listadoxfunc.Rows.Clear();
                    listadoAgregar.Rows.Clear();

                    string query = "SELECT * FROM ZAFFA_TEAM.[Funcionalidad x Rol] WHERE nombre_rol LIKE '" + nom + "'";
                    cargarFuncionalidad(ClaseConexion.ResolverConsulta(query));

                    string query2 = "SELECT FUNCIONALIDAD FROM ZAFFA_TEAM.Funcionalidad EXCEPT SELECT fr.FUNCIONALIDAD FROM ZAFFA_TEAM.[Funcionalidad x Rol] fr JOIN ZAFFA_TEAM.Funcionalidad f ON fr.FUNCIONALIDAD = f.FUNCIONALIDAD where NOMBRE_ROL LIKE '" + nom + "'";
                    cargarFuncionalidadAgregar(ClaseConexion.ResolverConsulta(query2));
                }
                catch (SqlException)
                {
                    MessageBox.Show("Error al tratar de cambiar el nombre", "Ok");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            nuevoNombre.ResetText();
        }

        private void obtenerIdFunc(SqlDataReader reader)
        {
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            reader.Close();
        }

        private void guardarFuncxRol()
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_guardarFuncionalidadxRol", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre_rol", nom);
            cmd.Parameters.AddWithValue("@funcionalidad", id);

            cmd.ExecuteReader().Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in listadoAgregar.SelectedRows)
                {
                    nombr = row.Cells[0].Value.ToString();
                    func = row.Cells[1].Value.ToString();
                    nombre_func = row.Cells[2].Value.ToString();

                    try
                    {
                        try
                        {
                            string query = "SELECT FUNCIONALIDAD FROM ZAFFA_TEAM.Funcionalidad WHERE descripcion_func LIKE '%" + nombre_func + "%'";
                            obtenerIdFunc(ClaseConexion.ResolverConsulta(query));
                            this.guardarFuncxRol();
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Error al guardar la funcionalidad " + nombre_func + " del rol pues ya existe", "Ok");
                        }

                        listadoAgregar.Rows.Clear();
                        
                        string query2 = "SELECT FUNCIONALIDAD FROM ZAFFA_TEAM.Funcionalidad EXCEPT SELECT fr.FUNCIONALIDAD FROM ZAFFA_TEAM.[Funcionalidad x Rol] fr JOIN ZAFFA_TEAM.Funcionalidad f ON fr.FUNCIONALIDAD = f.FUNCIONALIDAD where NOMBRE_ROL LIKE '" + nom + "'";
                        cargarFuncionalidadAgregar(ClaseConexion.ResolverConsulta(query2));
                        listadoAgregar.Rows.Clear();
                        Listadoxfunc.Rows.Clear();

                        string query3 = "SELECT FUNCIONALIDAD FROM ZAFFA_TEAM.Funcionalidad EXCEPT SELECT fr.FUNCIONALIDAD FROM ZAFFA_TEAM.[Funcionalidad x Rol] fr JOIN ZAFFA_TEAM.Funcionalidad f ON fr.FUNCIONALIDAD = f.FUNCIONALIDAD where NOMBRE_ROL LIKE '" + nom + "'";
                        cargarFuncionalidadAgregar(ClaseConexion.ResolverConsulta(query3));

                        string query4 = "SELECT * FROM ZAFFA_TEAM.[Funcionalidad x Rol] WHERE nombre_rol LIKE '" + nom + "'";
                        cargarFuncionalidad(ClaseConexion.ResolverConsulta(query4));
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error al tratar de agregar el rol", "Ok");
                    }
                }
                try
                {
                    listadoAgregar.CurrentCell.RowIndex.ToString();
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Por favor seleccione alguna fila", "Ok");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Por favor seleccione alguna fila válida", "Ok");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void cargarFuncionalidad(SqlDataReader reader)
        {
            while (reader.Read())
            {
                Listadoxfunc.Rows.Add(reader.GetString(0).Trim(), reader.GetInt32(1).ToString() , funcionalidades[reader.GetInt32(1) - 1]);
            }
            reader.Close();
        }

        private void cargarFuncionalidadAgregar(SqlDataReader reader)
        {
            while (reader.Read())
            {
                listadoAgregar.Rows.Add(nom, reader.GetInt32(0).ToString(), funcionalidades[reader.GetInt32(0) - 1]);
            }
            reader.Close();
        }
        
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Listadoxfunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void borrarRolxFunc(string nombr, string func)
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_deleteFuncionalidadxRol", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre_rol", nombr);
            cmd.Parameters.AddWithValue("@funcionalidad", func);

            cmd.ExecuteReader().Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in Listadoxfunc.SelectedRows)
                {
                    nombr = row.Cells[0].Value.ToString();
                    func = row.Cells[1].Value.ToString();

                    try
                    {
                        this.borrarRolxFunc(nombr, func);
                        Listadoxfunc.Rows.Clear();
                        string query = "SELECT * FROM ZAFFA_TEAM.[Funcionalidad x Rol] WHERE nombre_rol LIKE '" + nom + "'";
                        cargarFuncionalidad(ClaseConexion.ResolverConsulta(query));
                        Listadoxfunc.Rows.Clear();
                        listadoAgregar.Rows.Clear();

                        string query2 = "SELECT * FROM ZAFFA_TEAM.[Funcionalidad x Rol] WHERE nombre_rol LIKE '" + nom + "'";
                        cargarFuncionalidad(ClaseConexion.ResolverConsulta(query2));

                        string query3 = "SELECT FUNCIONALIDAD FROM ZAFFA_TEAM.Funcionalidad EXCEPT SELECT fr.FUNCIONALIDAD FROM ZAFFA_TEAM.[Funcionalidad x Rol] fr JOIN ZAFFA_TEAM.Funcionalidad f ON fr.FUNCIONALIDAD = f.FUNCIONALIDAD where NOMBRE_ROL LIKE '" + nom + "'";
                        cargarFuncionalidadAgregar(ClaseConexion.ResolverConsulta(query3));
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error al tratar de quitar el rol", "Ok");
                    }
                }
                try
                {
                    Listadoxfunc.CurrentCell.RowIndex.ToString();
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Por favor seleccione alguna fila", "Ok");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Por favor seleccione alguna fila válida", "Ok");
            }
        }

        private void guardarHab(String nombr)
        {
            SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_habilitarFuncionalidad", ClaseConexion.conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre_rol", nombr);
            cmd.Parameters.AddWithValue("@estado_rol", 'A');

            cmd.ExecuteReader().Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (string.Compare(funcionalidad, "I") == 0) {
                try
                {
                    this.guardarHab(nom);
                    MessageBox.Show("Rol activado", "Ok");
                    funcionalidad = "A";
                }
                catch (SqlException)
                {
                    MessageBox.Show("Error al tratar de volver a habilitar el rol", "Ok");
                }       
                                
            }
            else {
                MessageBox.Show("Este rol ya se encontraba activo", "Error");
            }
        }
    }
}
