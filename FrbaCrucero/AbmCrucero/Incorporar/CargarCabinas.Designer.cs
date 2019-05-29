namespace FrbaCrucero
{
    partial class CargarCabinas
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
            this.cargarCab = new System.Windows.Forms.GroupBox();
            this.tipoCab = new System.Windows.Forms.ComboBox();
            this.modelo = new System.Windows.Forms.Label();
            this.pisoCab = new System.Windows.Forms.TextBox();
            this.Finalizar = new System.Windows.Forms.Button();
            this.cargar_cabinas = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.nroCab = new System.Windows.Forms.TextBox();
            this.piso = new System.Windows.Forms.Label();
            this.nro = new System.Windows.Forms.Label();
            this.cargarCab.SuspendLayout();
            this.SuspendLayout();
            // 
            // cargarCab
            // 
            this.cargarCab.Controls.Add(this.tipoCab);
            this.cargarCab.Controls.Add(this.modelo);
            this.cargarCab.Controls.Add(this.pisoCab);
            this.cargarCab.Controls.Add(this.Finalizar);
            this.cargarCab.Controls.Add(this.cargar_cabinas);
            this.cargarCab.Controls.Add(this.limpiar);
            this.cargarCab.Controls.Add(this.nroCab);
            this.cargarCab.Controls.Add(this.piso);
            this.cargarCab.Controls.Add(this.nro);
            this.cargarCab.Location = new System.Drawing.Point(12, 12);
            this.cargarCab.Name = "cargarCab";
            this.cargarCab.Size = new System.Drawing.Size(358, 229);
            this.cargarCab.TabIndex = 1;
            this.cargarCab.TabStop = false;
            this.cargarCab.Text = "Cargar Cabinas";
            // 
            // tipoCab
            // 
            this.tipoCab.FormattingEnabled = true;
            this.tipoCab.Items.AddRange(new object[] {
            "Cabina Exterior",
            "Ejecutivo",
            "Cabina estandar",
            "Suite",
            "Cabina Balcón"});
            this.tipoCab.Location = new System.Drawing.Point(103, 89);
            this.tipoCab.Name = "tipoCab";
            this.tipoCab.Size = new System.Drawing.Size(196, 24);
            this.tipoCab.TabIndex = 11;
            // 
            // modelo
            // 
            this.modelo.AutoSize = true;
            this.modelo.Location = new System.Drawing.Point(56, 89);
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(40, 17);
            this.modelo.TabIndex = 10;
            this.modelo.Text = "Tipo:";
            // 
            // pisoCab
            // 
            this.pisoCab.Location = new System.Drawing.Point(103, 58);
            this.pisoCab.Name = "pisoCab";
            this.pisoCab.Size = new System.Drawing.Size(196, 22);
            this.pisoCab.TabIndex = 9;
            // 
            // Finalizar
            // 
            this.Finalizar.Location = new System.Drawing.Point(250, 142);
            this.Finalizar.Name = "Finalizar";
            this.Finalizar.Size = new System.Drawing.Size(76, 66);
            this.Finalizar.TabIndex = 8;
            this.Finalizar.Text = "Finalizar Carga";
            this.Finalizar.UseVisualStyleBackColor = true;
            this.Finalizar.Click += new System.EventHandler(this.Finalizar_Click);
            // 
            // cargar_cabinas
            // 
            this.cargar_cabinas.Location = new System.Drawing.Point(38, 178);
            this.cargar_cabinas.Name = "cargar_cabinas";
            this.cargar_cabinas.Size = new System.Drawing.Size(184, 30);
            this.cargar_cabinas.TabIndex = 5;
            this.cargar_cabinas.Text = "CARGAR OTRA CABINA";
            this.cargar_cabinas.UseVisualStyleBackColor = true;
            this.cargar_cabinas.Click += new System.EventHandler(this.cargar_cabinas_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(38, 142);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(184, 30);
            this.limpiar.TabIndex = 4;
            this.limpiar.Text = "LIMPIAR";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // nroCab
            // 
            this.nroCab.Location = new System.Drawing.Point(103, 30);
            this.nroCab.Name = "nroCab";
            this.nroCab.Size = new System.Drawing.Size(196, 22);
            this.nroCab.TabIndex = 3;
            // 
            // piso
            // 
            this.piso.AutoSize = true;
            this.piso.Location = new System.Drawing.Point(56, 58);
            this.piso.Name = "piso";
            this.piso.Size = new System.Drawing.Size(39, 17);
            this.piso.TabIndex = 1;
            this.piso.Text = "Piso:";
            // 
            // nro
            // 
            this.nro.AutoSize = true;
            this.nro.Location = new System.Drawing.Point(35, 30);
            this.nro.Name = "nro";
            this.nro.Size = new System.Drawing.Size(62, 17);
            this.nro.TabIndex = 0;
            this.nro.Text = "Número:";
            // 
            // CargarCabinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.cargarCab);
            this.Name = "CargarCabinas";
            this.Text = "UTN FRBA";
            this.cargarCab.ResumeLayout(false);
            this.cargarCab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cargarCab;
        private System.Windows.Forms.Label modelo;
        private System.Windows.Forms.TextBox pisoCab;
        private System.Windows.Forms.Button Finalizar;
        private System.Windows.Forms.Button cargar_cabinas;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.TextBox nroCab;
        private System.Windows.Forms.Label piso;
        private System.Windows.Forms.Label nro;
        private System.Windows.Forms.ComboBox tipoCab;
    }
}