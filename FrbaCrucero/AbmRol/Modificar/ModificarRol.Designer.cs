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
            this.Atras = new System.Windows.Forms.Button();
            this.funcionalidadesM = new System.Windows.Forms.ComboBox();
            this.buscar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.nombreM = new System.Windows.Forms.TextBox();
            this.tipo_funcionalidad = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.modificar_rol.SuspendLayout();
            this.SuspendLayout();
            // 
            // modificar_rol
            // 
            this.modificar_rol.Controls.Add(this.Atras);
            this.modificar_rol.Controls.Add(this.funcionalidadesM);
            this.modificar_rol.Controls.Add(this.buscar);
            this.modificar_rol.Controls.Add(this.limpiar);
            this.modificar_rol.Controls.Add(this.nombreM);
            this.modificar_rol.Controls.Add(this.tipo_funcionalidad);
            this.modificar_rol.Controls.Add(this.nombre);
            this.modificar_rol.Location = new System.Drawing.Point(13, 13);
            this.modificar_rol.Name = "modificar_rol";
            this.modificar_rol.Size = new System.Drawing.Size(357, 228);
            this.modificar_rol.TabIndex = 0;
            this.modificar_rol.TabStop = false;
            this.modificar_rol.Text = "Modificar Rol";
            // 
            // Atras
            // 
            this.Atras.Location = new System.Drawing.Point(49, 140);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(76, 66);
            this.Atras.TabIndex = 22;
            this.Atras.Text = "Atrás";
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // funcionalidadesM
            // 
            this.funcionalidadesM.FormattingEnabled = true;
            this.funcionalidadesM.Items.AddRange(new object[] {
            "AbmRol",
            "AbmCrucero",
            "AbmPuerto",
            "AbmRecorrido",
            "ComprarReservaPasaje",
            "GeneracionViaje",
            "ListadoEstadistico",
            "PagoReserva"});
            this.funcionalidadesM.Location = new System.Drawing.Point(86, 97);
            this.funcionalidadesM.Name = "funcionalidadesM";
            this.funcionalidadesM.Size = new System.Drawing.Size(181, 24);
            this.funcionalidadesM.TabIndex = 21;
            this.funcionalidadesM.SelectedIndexChanged += new System.EventHandler(this.funcionalidadesE_SelectedIndexChanged);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(150, 176);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(157, 30);
            this.buscar.TabIndex = 20;
            this.buscar.Text = "BUSCAR";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(150, 140);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(157, 30);
            this.limpiar.TabIndex = 19;
            this.limpiar.Text = "LIMPIAR";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // nombreM
            // 
            this.nombreM.Location = new System.Drawing.Point(86, 42);
            this.nombreM.Name = "nombreM";
            this.nombreM.Size = new System.Drawing.Size(181, 22);
            this.nombreM.TabIndex = 18;
            // 
            // tipo_funcionalidad
            // 
            this.tipo_funcionalidad.AutoSize = true;
            this.tipo_funcionalidad.Location = new System.Drawing.Point(94, 77);
            this.tipo_funcionalidad.Name = "tipo_funcionalidad";
            this.tipo_funcionalidad.Size = new System.Drawing.Size(173, 17);
            this.tipo_funcionalidad.TabIndex = 17;
            this.tipo_funcionalidad.Text = "Funcionalidad a modificar:";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(147, 22);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(62, 17);
            this.nombre.TabIndex = 16;
            this.nombre.Text = "Nombre:";
            // 
            // ModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.modificar_rol);
            this.Name = "ModificarRol";
            this.Text = "UTN FRBA";
            this.Load += new System.EventHandler(this.ModificarRol_Load);
            this.modificar_rol.ResumeLayout(false);
            this.modificar_rol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox modificar_rol;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.ComboBox funcionalidadesM;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.TextBox nombreM;
        private System.Windows.Forms.Label tipo_funcionalidad;
        private System.Windows.Forms.Label nombre;
    }
}