namespace FrbaCrucero
{
    partial class EliminarRol
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
            this.eliminar_rol = new System.Windows.Forms.GroupBox();
            this.Atras = new System.Windows.Forms.Button();
            this.funcionalidadesE = new System.Windows.Forms.ComboBox();
            this.buscar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.nombreE = new System.Windows.Forms.TextBox();
            this.tipo_funcionalidad = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.eliminar_rol.SuspendLayout();
            this.SuspendLayout();
            // 
            // eliminar_rol
            // 
            this.eliminar_rol.Controls.Add(this.Atras);
            this.eliminar_rol.Controls.Add(this.funcionalidadesE);
            this.eliminar_rol.Controls.Add(this.buscar);
            this.eliminar_rol.Controls.Add(this.limpiar);
            this.eliminar_rol.Controls.Add(this.nombreE);
            this.eliminar_rol.Controls.Add(this.tipo_funcionalidad);
            this.eliminar_rol.Controls.Add(this.nombre);
            this.eliminar_rol.Location = new System.Drawing.Point(12, 12);
            this.eliminar_rol.Name = "eliminar_rol";
            this.eliminar_rol.Size = new System.Drawing.Size(358, 229);
            this.eliminar_rol.TabIndex = 0;
            this.eliminar_rol.TabStop = false;
            this.eliminar_rol.Text = "Eliminar Rol";
            this.eliminar_rol.Enter += new System.EventHandler(this.eliminar_rol_Enter);
            // 
            // Atras
            // 
            this.Atras.Location = new System.Drawing.Point(50, 140);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(76, 66);
            this.Atras.TabIndex = 15;
            this.Atras.Text = "Atrás";
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click_1);
            // 
            // funcionalidadesE
            // 
            this.funcionalidadesE.FormattingEnabled = true;
            this.funcionalidadesE.Items.AddRange(new object[] {
            "AbmRol",
            "AbmCrucero",
            "AbmPuerto",
            "AbmRecorrido",
            "ComprarReservaPasaje",
            "GeneracionViaje",
            "ListadoEstadistico",
            "PagoReserva"});
            this.funcionalidadesE.Location = new System.Drawing.Point(87, 97);
            this.funcionalidadesE.Name = "funcionalidadesE";
            this.funcionalidadesE.Size = new System.Drawing.Size(181, 24);
            this.funcionalidadesE.TabIndex = 14;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(151, 176);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(157, 30);
            this.buscar.TabIndex = 13;
            this.buscar.Text = "BUSCAR";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.guardar_Click_1);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(151, 140);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(157, 30);
            this.limpiar.TabIndex = 12;
            this.limpiar.Text = "LIMPIAR";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click_1);
            // 
            // nombreE
            // 
            this.nombreE.Location = new System.Drawing.Point(87, 42);
            this.nombreE.Name = "nombreE";
            this.nombreE.Size = new System.Drawing.Size(181, 22);
            this.nombreE.TabIndex = 11;
            // 
            // tipo_funcionalidad
            // 
            this.tipo_funcionalidad.AutoSize = true;
            this.tipo_funcionalidad.Location = new System.Drawing.Point(94, 77);
            this.tipo_funcionalidad.Name = "tipo_funcionalidad";
            this.tipo_funcionalidad.Size = new System.Drawing.Size(165, 17);
            this.tipo_funcionalidad.TabIndex = 10;
            this.tipo_funcionalidad.Text = "Funcionalidad a eliminar:";
            this.tipo_funcionalidad.Click += new System.EventHandler(this.tipo_funcionalidad_Click);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(148, 22);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(62, 17);
            this.nombre.TabIndex = 9;
            this.nombre.Text = "Nombre:";
            // 
            // EliminarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.eliminar_rol);
            this.Name = "EliminarRol";
            this.Text = "UTN FRBA";
            this.Load += new System.EventHandler(this.EliminarRol_Load);
            this.eliminar_rol.ResumeLayout(false);
            this.eliminar_rol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox eliminar_rol;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.ComboBox funcionalidadesE;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.TextBox nombreE;
        private System.Windows.Forms.Label tipo_funcionalidad;
        private System.Windows.Forms.Label nombre;
    }
}