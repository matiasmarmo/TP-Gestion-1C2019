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
    public partial class MedioPago : Form
    {
        String CODIGO_RESERVA;
        String viajeID;
        String fecha_salida;
        String fecha_llegada;
        Decimal precio = 0;
        String crucero_id;
        String cli_id;
        String cabina_nro;
        String cabina_piso;
        String rolSeleccionado;

        public MedioPago(String codigo_res, String viajeID, String fecha_salida, String fecha_llegada,Decimal precio,String crucero_id,
                            String cli_id, String cabina_nro, String cabina_piso,String rolSeleccionado)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.rolSeleccionado = rolSeleccionado;
            this.CODIGO_RESERVA = codigo_res;
            this.viajeID = viajeID;
            this.fecha_salida = fecha_salida;
            this.fecha_llegada = fecha_llegada;
            this.precio = precio;
            this.crucero_id = crucero_id;
            this.cli_id = cli_id;
            this.cabina_nro = cabina_nro;
            this.cabina_piso = cabina_piso;
            textBox1.Text = this.precio.ToString();
            MEDIOS_DE_PAGO.Items.Add("Tarjeta de crédito");
            MEDIOS_DE_PAGO.Items.Add("Tarjeta de débito");
            TIPO_TARJETA.Items.Add("Visa");
            TIPO_TARJETA.Items.Add("Mastercard");
            if (rolSeleccionado == "Cliente")
            {
                SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_borrarReservas", ClaseConexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteReader().Close();
            }
        }

        private void MEDIOS_DE_PAGO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MEDIOS_DE_PAGO.Text == "Tarjeta de crédito")
            {
                numericUpDown1.Enabled = true;
            }
            else
            {
                numericUpDown1.Value = 1;
                numericUpDown1.Enabled = false;
            }

        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 16) 
            {
                MessageBox.Show("El numero de tarjeta ingresado es incorrecto, deben ser los 16 digitos que figuran al frente de la tarjeta");
                return;
            }
            if (textBox3.Text.Length != 3)
            {
                MessageBox.Show("El pin ingresado es incorrecto, deben ser los 3 digitos que figuran al reverso de su tarjeta");
                return;
            }
            if (MEDIOS_DE_PAGO.Text != "" && TIPO_TARJETA.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                this.generarCompra();
                String formaPago = MEDIOS_DE_PAGO.Text + " - " + TIPO_TARJETA.Text;
                VoucherCompra voucher = new VoucherCompra(viajeID, fecha_salida, fecha_llegada, precio, crucero_id,
                                                        formaPago,numericUpDown1.Value.ToString(),cli_id,cabina_nro,cabina_piso,rolSeleccionado);
                voucher.Visible = true;
                this.Dispose(false);
                this.Close();
            }
            else
            {
                MessageBox.Show("Falto completar algun campo");
            }
        }

        private void generarCompra() 
        {
            if (CODIGO_RESERVA != "")
            {
                int numRegs = ClaseConexion.ResolverNonQuery("delete from ZAFFA_TEAM.Reserva where RESERVA_CODIGO = " + CODIGO_RESERVA);
                SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_generarPasaje", ClaseConexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@precio", this.precio);
                cmd.Parameters.AddWithValue("@cliente_id", this.cli_id);
                cmd.Parameters.AddWithValue("@viaje_id", this.viajeID);
                cmd.Parameters.AddWithValue("@crucero_id", this.crucero_id);
                cmd.Parameters.AddWithValue("@cabina_nro", this.cabina_nro);
                cmd.Parameters.AddWithValue("@cabina_piso", this.cabina_piso);
                cmd.Parameters.AddWithValue("@medio_pago", MEDIOS_DE_PAGO.Text + " - " + TIPO_TARJETA.Text);
                cmd.ExecuteReader().Close();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("ZAFFA_TEAM.sp_generarPasaje", ClaseConexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@precio", this.precio);
                cmd.Parameters.AddWithValue("@cliente_id", this.cli_id);
                cmd.Parameters.AddWithValue("@viaje_id", this.viajeID);
                cmd.Parameters.AddWithValue("@crucero_id", this.crucero_id);
                cmd.Parameters.AddWithValue("@cabina_nro", this.cabina_nro);
                cmd.Parameters.AddWithValue("@cabina_piso", this.cabina_piso);
                cmd.Parameters.AddWithValue("@medio_pago", MEDIOS_DE_PAGO.Text + " - " + TIPO_TARJETA.Text);
                cmd.ExecuteReader().Close();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
