namespace FrbaCrucero
{
    partial class ModificarRol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.modificar_rol = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.PagoReserva = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ListadoEstadistico = new System.Windows.Forms.CheckBox();
            this.AbmRol = new System.Windows.Forms.CheckBox();
            this.AbmCrucero = new System.Windows.Forms.CheckBox();
            this.GeneracionViaje = new System.Windows.Forms.CheckBox();
            this.AbmPuerto = new System.Windows.Forms.CheckBox();
            this.AbmRecorrido = new System.Windows.Forms.CheckBox();
            this.ComprarReservaPasaje = new System.Windows.Forms.CheckBox();
            this.Listadoxfunc = new System.Windows.Forms.DataGridView();
            this.NOMBRE_ROL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNCIONALIDAD_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNCIONALIDAD_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nuevoNombre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Atras = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.Label();
            this.modificar_rol.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Listadoxfunc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // modificar_rol
            // 
            this.modificar_rol.Controls.Add(this.groupBox4);
            this.modificar_rol.Controls.Add(this.groupBox3);
            this.modificar_rol.Controls.Add(this.groupBox1);
            this.modificar_rol.Controls.Add(this.label1);
            this.modificar_rol.Controls.Add(this.Atras);
            this.modificar_rol.Controls.Add(this.nombre);
            this.modificar_rol.Location = new System.Drawing.Point(13, 13);
            this.modificar_rol.Name = "modificar_rol";
            this.modificar_rol.Size = new System.Drawing.Size(750, 636);
            this.modificar_rol.TabIndex = 0;
            this.modificar_rol.TabStop = false;
            this.modificar_rol.Text = "Modificar Rol";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(26, 512);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(713, 81);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Volver a habilitar Rol";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(203, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(277, 40);
            this.button3.TabIndex = 0;
            this.button3.Text = "VOLVER A HABILITAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.Listadoxfunc);
            this.groupBox3.Location = new System.Drawing.Point(26, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(713, 370);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado Funcionalidades";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button4);
            this.groupBox6.Location = new System.Drawing.Point(525, 21);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(182, 166);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Quitar Funcionalidad seleccionada";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(28, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 70);
            this.button4.TabIndex = 0;
            this.button4.Text = "QUITAR FUNCIONALIDAD\r\n";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.PagoReserva);
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.ListadoEstadistico);
            this.groupBox5.Controls.Add(this.AbmRol);
            this.groupBox5.Controls.Add(this.AbmCrucero);
            this.groupBox5.Controls.Add(this.GeneracionViaje);
            this.groupBox5.Controls.Add(this.AbmPuerto);
            this.groupBox5.Controls.Add(this.AbmRecorrido);
            this.groupBox5.Controls.Add(this.ComprarReservaPasaje);
            this.groupBox5.Location = new System.Drawing.Point(18, 200);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(689, 164);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Agregar funcionalidades";
            // 
            // PagoReserva
            // 
            this.PagoReserva.AutoSize = true;
            this.PagoReserva.Location = new System.Drawing.Point(213, 135);
            this.PagoReserva.Name = "PagoReserva";
            this.PagoReserva.Size = new System.Drawing.Size(116, 21);
            this.PagoReserva.TabIndex = 32;
            this.PagoReserva.Text = "PagoReserva";
            this.PagoReserva.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(455, 69);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(190, 70);
            this.button5.TabIndex = 2;
            this.button5.Text = "AGREGAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Funcionalidad del rol:";
            // 
            // ListadoEstadistico
            // 
            this.ListadoEstadistico.AutoSize = true;
            this.ListadoEstadistico.Location = new System.Drawing.Point(213, 108);
            this.ListadoEstadistico.Name = "ListadoEstadistico";
            this.ListadoEstadistico.Size = new System.Drawing.Size(144, 21);
            this.ListadoEstadistico.TabIndex = 31;
            this.ListadoEstadistico.Text = "ListadoEstadistico";
            this.ListadoEstadistico.UseVisualStyleBackColor = true;
            // 
            // AbmRol
            // 
            this.AbmRol.AutoSize = true;
            this.AbmRol.Location = new System.Drawing.Point(22, 54);
            this.AbmRol.Name = "AbmRol";
            this.AbmRol.Size = new System.Drawing.Size(79, 21);
            this.AbmRol.TabIndex = 25;
            this.AbmRol.Text = "AbmRol";
            this.AbmRol.UseVisualStyleBackColor = true;
            // 
            // AbmCrucero
            // 
            this.AbmCrucero.AutoSize = true;
            this.AbmCrucero.Location = new System.Drawing.Point(22, 81);
            this.AbmCrucero.Name = "AbmCrucero";
            this.AbmCrucero.Size = new System.Drawing.Size(108, 21);
            this.AbmCrucero.TabIndex = 26;
            this.AbmCrucero.Text = "AbmCrucero";
            this.AbmCrucero.UseVisualStyleBackColor = true;
            // 
            // GeneracionViaje
            // 
            this.GeneracionViaje.AutoSize = true;
            this.GeneracionViaje.Location = new System.Drawing.Point(213, 81);
            this.GeneracionViaje.Name = "GeneracionViaje";
            this.GeneracionViaje.Size = new System.Drawing.Size(135, 21);
            this.GeneracionViaje.TabIndex = 30;
            this.GeneracionViaje.Text = "GeneracionViaje";
            this.GeneracionViaje.UseVisualStyleBackColor = true;
            // 
            // AbmPuerto
            // 
            this.AbmPuerto.AutoSize = true;
            this.AbmPuerto.Location = new System.Drawing.Point(22, 108);
            this.AbmPuerto.Name = "AbmPuerto";
            this.AbmPuerto.Size = new System.Drawing.Size(100, 21);
            this.AbmPuerto.TabIndex = 27;
            this.AbmPuerto.Text = "AbmPuerto";
            this.AbmPuerto.UseVisualStyleBackColor = true;
            // 
            // AbmRecorrido
            // 
            this.AbmRecorrido.AutoSize = true;
            this.AbmRecorrido.Location = new System.Drawing.Point(22, 135);
            this.AbmRecorrido.Name = "AbmRecorrido";
            this.AbmRecorrido.Size = new System.Drawing.Size(120, 21);
            this.AbmRecorrido.TabIndex = 28;
            this.AbmRecorrido.Text = "AbmRecorrido";
            this.AbmRecorrido.UseVisualStyleBackColor = true;
            // 
            // ComprarReservaPasaje
            // 
            this.ComprarReservaPasaje.AutoSize = true;
            this.ComprarReservaPasaje.Location = new System.Drawing.Point(213, 54);
            this.ComprarReservaPasaje.Name = "ComprarReservaPasaje";
            this.ComprarReservaPasaje.Size = new System.Drawing.Size(175, 21);
            this.ComprarReservaPasaje.TabIndex = 29;
            this.ComprarReservaPasaje.Text = "CompraReservaPasaje";
            this.ComprarReservaPasaje.UseVisualStyleBackColor = true;
            // 
            // Listadoxfunc
            // 
            this.Listadoxfunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Listadoxfunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBRE_ROL,
            this.FUNCIONALIDAD_ID,
            this.FUNCIONALIDAD_DESC});
            this.Listadoxfunc.Location = new System.Drawing.Point(18, 30);
            this.Listadoxfunc.Name = "Listadoxfunc";
            this.Listadoxfunc.RowTemplate.Height = 24;
            this.Listadoxfunc.Size = new System.Drawing.Size(501, 147);
            this.Listadoxfunc.TabIndex = 1;
            this.Listadoxfunc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Listadoxfunc_CellContentClick);
            // 
            // NOMBRE_ROL
            // 
            this.NOMBRE_ROL.HeaderText = "NOMBRE_ROL";
            this.NOMBRE_ROL.Name = "NOMBRE_ROL";
            // 
            // FUNCIONALIDAD_ID
            // 
            this.FUNCIONALIDAD_ID.HeaderText = "FUNCIONALIDAD_ID";
            this.FUNCIONALIDAD_ID.Name = "FUNCIONALIDAD_ID";
            // 
            // FUNCIONALIDAD_DESC
            // 
            this.FUNCIONALIDAD_DESC.HeaderText = "FUNCIONALIDAD_DESC";
            this.FUNCIONALIDAD_DESC.Name = "FUNCIONALIDAD_DESC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nuevoNombre);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 75);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar nombre";
            // 
            // nuevoNombre
            // 
            this.nuevoNombre.Location = new System.Drawing.Point(231, 33);
            this.nuevoNombre.Name = "nuevoNombre";
            this.nuevoNombre.Size = new System.Drawing.Size(249, 22);
            this.nuevoNombre.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(608, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 37);
            this.button2.TabIndex = 28;
            this.button2.Text = "CARGAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 36);
            this.button1.TabIndex = 27;
            this.button1.Text = "LIMPIAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ingrese el nuevo nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Seleccione qué desea hacer con este rol:";
            // 
            // Atras
            // 
            this.Atras.Location = new System.Drawing.Point(9, 599);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(76, 31);
            this.Atras.TabIndex = 22;
            this.Atras.Text = "Atrás";
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(0, 0);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 23);
            this.nombre.TabIndex = 23;
            // 
            // ModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 653);
            this.Controls.Add(this.modificar_rol);
            this.Name = "ModificarRol";
            this.Text = "UTN FRBA";
            this.Load += new System.EventHandler(this.ModificarRol_Load);
            this.modificar_rol.ResumeLayout(false);
            this.modificar_rol.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Listadoxfunc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox modificar_rol;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Listadoxfunc;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_ROL;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNCIONALIDAD_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNCIONALIDAD_DESC;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox nuevoNombre;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox PagoReserva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ListadoEstadistico;
        private System.Windows.Forms.CheckBox AbmRol;
        private System.Windows.Forms.CheckBox AbmCrucero;
        private System.Windows.Forms.CheckBox GeneracionViaje;
        private System.Windows.Forms.CheckBox AbmPuerto;
        private System.Windows.Forms.CheckBox AbmRecorrido;
        private System.Windows.Forms.CheckBox ComprarReservaPasaje;
    }
}