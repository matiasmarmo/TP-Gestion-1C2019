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
            this.guardar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.nombreR = new System.Windows.Forms.TextBox();
            this.tipo_funcionalidad = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.funcionalidadesR = new System.Windows.Forms.ComboBox();
            this.Atras = new System.Windows.Forms.Button();
            this.crear_rol.SuspendLayout();
            this.SuspendLayout();
            // 
            // crear_rol
            // 
            this.crear_rol.Controls.Add(this.Atras);
            this.crear_rol.Controls.Add(this.funcionalidadesR);
            this.crear_rol.Controls.Add(this.guardar);
            this.crear_rol.Controls.Add(this.limpiar);
            this.crear_rol.Controls.Add(this.nombreR);
            this.crear_rol.Controls.Add(this.tipo_funcionalidad);
            this.crear_rol.Controls.Add(this.nombre);
            this.crear_rol.Location = new System.Drawing.Point(12, 12);
            this.crear_rol.Name = "crear_rol";
            this.crear_rol.Size = new System.Drawing.Size(358, 229);
            this.crear_rol.TabIndex = 0;
            this.crear_rol.TabStop = false;
            this.crear_rol.Text = "Crear Rol";
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(147, 179);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(157, 30);
            this.guardar.TabIndex = 5;
            this.guardar.Text = "GUARDAR";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(147, 143);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(157, 30);
            this.limpiar.TabIndex = 4;
            this.limpiar.Text = "LIMPIAR";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // nombreR
            // 
            this.nombreR.Location = new System.Drawing.Point(83, 45);
            this.nombreR.Name = "nombreR";
            this.nombreR.Size = new System.Drawing.Size(181, 22);
            this.nombreR.TabIndex = 3;
            // 
            // tipo_funcionalidad
            // 
            this.tipo_funcionalidad.AutoSize = true;
            this.tipo_funcionalidad.Location = new System.Drawing.Point(114, 80);
            this.tipo_funcionalidad.Name = "tipo_funcionalidad";
            this.tipo_funcionalidad.Size = new System.Drawing.Size(115, 17);
            this.tipo_funcionalidad.TabIndex = 1;
            this.tipo_funcionalidad.Text = "Funcionalidades:";
            this.tipo_funcionalidad.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(144, 25);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(62, 17);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "Nombre:";
            this.nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // funcionalidadesR
            // 
            this.funcionalidadesR.FormattingEnabled = true;
            this.funcionalidadesR.Items.AddRange(new object[] {
            "AbmRol",
            "AbmCrucero",
            "AbmPuerto",
            "AbmRecorrido",
            "ComprarReservaPasaje",
            "GeneracionViaje",
            "ListadoEstadistico",
            "PagoReserva"});
            this.funcionalidadesR.Location = new System.Drawing.Point(83, 100);
            this.funcionalidadesR.Name = "funcionalidadesR";
            this.funcionalidadesR.Size = new System.Drawing.Size(181, 24);
            this.funcionalidadesR.TabIndex = 7;
            this.funcionalidadesR.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // Atras
            // 
            this.Atras.Location = new System.Drawing.Point(46, 143);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(76, 66);
            this.Atras.TabIndex = 8;
            this.Atras.Text = "Atrás";
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // CrearRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.crear_rol);
            this.Name = "CrearRol";
            this.Text = "UTN FRBA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.crear_rol.ResumeLayout(false);
            this.crear_rol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox crear_rol;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label tipo_funcionalidad;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.TextBox nombreR;
        private System.Windows.Forms.ComboBox funcionalidadesR;
        private System.Windows.Forms.Button Atras;
    }
}