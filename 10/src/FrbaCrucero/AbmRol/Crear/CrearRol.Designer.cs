namespace FrbaCrucero
{
    partial class CrearRol
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
            this.crear_rol = new System.Windows.Forms.GroupBox();
            this.PagoReserva = new System.Windows.Forms.CheckBox();
            this.ListadoEstadistico = new System.Windows.Forms.CheckBox();
            this.GeneracionViaje = new System.Windows.Forms.CheckBox();
            this.ComprarReservaPasaje = new System.Windows.Forms.CheckBox();
            this.AbmRecorrido = new System.Windows.Forms.CheckBox();
            this.AbmPuerto = new System.Windows.Forms.CheckBox();
            this.AbmCrucero = new System.Windows.Forms.CheckBox();
            this.AbmRol = new System.Windows.Forms.CheckBox();
            this.Atras = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.nombreC = new System.Windows.Forms.TextBox();
            this.tipo_funcionalidad = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.crear_rol.SuspendLayout();
            this.SuspendLayout();
            // 
            // crear_rol
            // 
            this.crear_rol.Controls.Add(this.PagoReserva);
            this.crear_rol.Controls.Add(this.ListadoEstadistico);
            this.crear_rol.Controls.Add(this.GeneracionViaje);
            this.crear_rol.Controls.Add(this.ComprarReservaPasaje);
            this.crear_rol.Controls.Add(this.AbmRecorrido);
            this.crear_rol.Controls.Add(this.AbmPuerto);
            this.crear_rol.Controls.Add(this.AbmCrucero);
            this.crear_rol.Controls.Add(this.AbmRol);
            this.crear_rol.Controls.Add(this.Atras);
            this.crear_rol.Controls.Add(this.buscar);
            this.crear_rol.Controls.Add(this.limpiar);
            this.crear_rol.Controls.Add(this.nombreC);
            this.crear_rol.Controls.Add(this.tipo_funcionalidad);
            this.crear_rol.Controls.Add(this.nombre);
            this.crear_rol.Location = new System.Drawing.Point(12, 12);
            this.crear_rol.Name = "crear_rol";
            this.crear_rol.Size = new System.Drawing.Size(358, 415);
            this.crear_rol.TabIndex = 1;
            this.crear_rol.TabStop = false;
            this.crear_rol.Text = "Crear Rol";
            // 
            // PagoReserva
            // 
            this.PagoReserva.AutoSize = true;
            this.PagoReserva.Location = new System.Drawing.Point(113, 288);
            this.PagoReserva.Name = "PagoReserva";
            this.PagoReserva.Size = new System.Drawing.Size(116, 21);
            this.PagoReserva.TabIndex = 23;
            this.PagoReserva.Text = "PagoReserva";
            this.PagoReserva.UseVisualStyleBackColor = true;
            // 
            // ListadoEstadistico
            // 
            this.ListadoEstadistico.AutoSize = true;
            this.ListadoEstadistico.Location = new System.Drawing.Point(113, 261);
            this.ListadoEstadistico.Name = "ListadoEstadistico";
            this.ListadoEstadistico.Size = new System.Drawing.Size(144, 21);
            this.ListadoEstadistico.TabIndex = 22;
            this.ListadoEstadistico.Text = "ListadoEstadistico";
            this.ListadoEstadistico.UseVisualStyleBackColor = true;
            // 
            // GeneracionViaje
            // 
            this.GeneracionViaje.AutoSize = true;
            this.GeneracionViaje.Location = new System.Drawing.Point(113, 234);
            this.GeneracionViaje.Name = "GeneracionViaje";
            this.GeneracionViaje.Size = new System.Drawing.Size(135, 21);
            this.GeneracionViaje.TabIndex = 21;
            this.GeneracionViaje.Text = "GeneracionViaje";
            this.GeneracionViaje.UseVisualStyleBackColor = true;
            // 
            // ComprarReservaPasaje
            // 
            this.ComprarReservaPasaje.AutoSize = true;
            this.ComprarReservaPasaje.Location = new System.Drawing.Point(113, 207);
            this.ComprarReservaPasaje.Name = "ComprarReservaPasaje";
            this.ComprarReservaPasaje.Size = new System.Drawing.Size(175, 21);
            this.ComprarReservaPasaje.TabIndex = 20;
            this.ComprarReservaPasaje.Text = "CompraReservaPasaje";
            this.ComprarReservaPasaje.UseVisualStyleBackColor = true;
            this.ComprarReservaPasaje.CheckedChanged += new System.EventHandler(this.ComprarReservaPasaje_CheckedChanged);
            // 
            // AbmRecorrido
            // 
            this.AbmRecorrido.AutoSize = true;
            this.AbmRecorrido.Location = new System.Drawing.Point(113, 180);
            this.AbmRecorrido.Name = "AbmRecorrido";
            this.AbmRecorrido.Size = new System.Drawing.Size(120, 21);
            this.AbmRecorrido.TabIndex = 19;
            this.AbmRecorrido.Text = "AbmRecorrido";
            this.AbmRecorrido.UseVisualStyleBackColor = true;
            // 
            // AbmPuerto
            // 
            this.AbmPuerto.AutoSize = true;
            this.AbmPuerto.Location = new System.Drawing.Point(113, 152);
            this.AbmPuerto.Name = "AbmPuerto";
            this.AbmPuerto.Size = new System.Drawing.Size(100, 21);
            this.AbmPuerto.TabIndex = 18;
            this.AbmPuerto.Text = "AbmPuerto";
            this.AbmPuerto.UseVisualStyleBackColor = true;
            // 
            // AbmCrucero
            // 
            this.AbmCrucero.AutoSize = true;
            this.AbmCrucero.Location = new System.Drawing.Point(113, 125);
            this.AbmCrucero.Name = "AbmCrucero";
            this.AbmCrucero.Size = new System.Drawing.Size(108, 21);
            this.AbmCrucero.TabIndex = 17;
            this.AbmCrucero.Text = "AbmCrucero";
            this.AbmCrucero.UseVisualStyleBackColor = true;
            // 
            // AbmRol
            // 
            this.AbmRol.AutoSize = true;
            this.AbmRol.Location = new System.Drawing.Point(113, 97);
            this.AbmRol.Name = "AbmRol";
            this.AbmRol.Size = new System.Drawing.Size(79, 21);
            this.AbmRol.TabIndex = 16;
            this.AbmRol.Text = "AbmRol";
            this.AbmRol.UseVisualStyleBackColor = true;
            // 
            // Atras
            // 
            this.Atras.Location = new System.Drawing.Point(49, 330);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(76, 66);
            this.Atras.TabIndex = 15;
            this.Atras.Text = "Atrás";
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(150, 366);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(157, 30);
            this.buscar.TabIndex = 13;
            this.buscar.Text = "CARGAR";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(150, 330);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(157, 30);
            this.limpiar.TabIndex = 12;
            this.limpiar.Text = "LIMPIAR";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // nombreC
            // 
            this.nombreC.Location = new System.Drawing.Point(87, 42);
            this.nombreC.Name = "nombreC";
            this.nombreC.Size = new System.Drawing.Size(181, 22);
            this.nombreC.TabIndex = 11;
            // 
            // tipo_funcionalidad
            // 
            this.tipo_funcionalidad.AutoSize = true;
            this.tipo_funcionalidad.Location = new System.Drawing.Point(110, 77);
            this.tipo_funcionalidad.Name = "tipo_funcionalidad";
            this.tipo_funcionalidad.Size = new System.Drawing.Size(143, 17);
            this.tipo_funcionalidad.TabIndex = 10;
            this.tipo_funcionalidad.Text = "Funcionalidad del rol:";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(110, 22);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(148, 17);
            this.nombre.TabIndex = 9;
            this.nombre.Text = "Nombre del nuevo rol:";
            // 
            // CrearRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 438);
            this.Controls.Add(this.crear_rol);
            this.Name = "CrearRol";
            this.Text = "UTN FRBA";
            this.crear_rol.ResumeLayout(false);
            this.crear_rol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox crear_rol;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.TextBox nombreC;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label tipo_funcionalidad;
        private System.Windows.Forms.CheckBox AbmRol;
        private System.Windows.Forms.CheckBox PagoReserva;
        private System.Windows.Forms.CheckBox ListadoEstadistico;
        private System.Windows.Forms.CheckBox GeneracionViaje;
        private System.Windows.Forms.CheckBox ComprarReservaPasaje;
        private System.Windows.Forms.CheckBox AbmRecorrido;
        private System.Windows.Forms.CheckBox AbmPuerto;
        private System.Windows.Forms.CheckBox AbmCrucero;

    }
}