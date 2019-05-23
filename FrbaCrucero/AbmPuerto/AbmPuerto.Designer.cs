namespace FrbaCrucero.AbmPuerto
{
    partial class AbmPuerto
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
            this.seleccionarOpcionBox = new System.Windows.Forms.GroupBox();
            this.crearPuerto = new System.Windows.Forms.Button();
            this.darDeBajaPuerto = new System.Windows.Forms.Button();
            this.modificarPuerto = new System.Windows.Forms.Button();
            this.seleccionarOpcionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // seleccionarOpcionBox
            // 
            this.seleccionarOpcionBox.Controls.Add(this.crearPuerto);
            this.seleccionarOpcionBox.Controls.Add(this.darDeBajaPuerto);
            this.seleccionarOpcionBox.Controls.Add(this.modificarPuerto);
            this.seleccionarOpcionBox.Location = new System.Drawing.Point(12, 12);
            this.seleccionarOpcionBox.Name = "seleccionarOpcionBox";
            this.seleccionarOpcionBox.Size = new System.Drawing.Size(260, 237);
            this.seleccionarOpcionBox.TabIndex = 0;
            this.seleccionarOpcionBox.TabStop = false;
            this.seleccionarOpcionBox.Text = "Seleccione una opcion:";
            // 
            // crearPuerto
            // 
            this.crearPuerto.Location = new System.Drawing.Point(62, 52);
            this.crearPuerto.Name = "crearPuerto";
            this.crearPuerto.Size = new System.Drawing.Size(129, 23);
            this.crearPuerto.TabIndex = 1;
            this.crearPuerto.Text = "Crear puerto";
            this.crearPuerto.UseVisualStyleBackColor = true;
            this.crearPuerto.Click += new System.EventHandler(this.crearPuerto_Click);
            // 
            // darDeBajaPuerto
            // 
            this.darDeBajaPuerto.Location = new System.Drawing.Point(62, 166);
            this.darDeBajaPuerto.Name = "darDeBajaPuerto";
            this.darDeBajaPuerto.Size = new System.Drawing.Size(129, 23);
            this.darDeBajaPuerto.TabIndex = 3;
            this.darDeBajaPuerto.Text = "Dar de baja puerto";
            this.darDeBajaPuerto.UseVisualStyleBackColor = true;
            this.darDeBajaPuerto.Click += new System.EventHandler(this.darDeBajaPuerto_Click);
            // 
            // modificarPuerto
            // 
            this.modificarPuerto.Location = new System.Drawing.Point(62, 107);
            this.modificarPuerto.Name = "modificarPuerto";
            this.modificarPuerto.Size = new System.Drawing.Size(129, 23);
            this.modificarPuerto.TabIndex = 2;
            this.modificarPuerto.Text = "Modificar puerto";
            this.modificarPuerto.UseVisualStyleBackColor = true;
            this.modificarPuerto.Click += new System.EventHandler(this.modificarPuerto_Click);
            // 
            // AbmPuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.seleccionarOpcionBox);
            this.Name = "AbmPuerto";
            this.Text = "ABM PUERTOS";
            this.Load += new System.EventHandler(this.AbmPuerto_Load);
            this.seleccionarOpcionBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox seleccionarOpcionBox;
        private System.Windows.Forms.Button darDeBajaPuerto;
        private System.Windows.Forms.Button modificarPuerto;
        private System.Windows.Forms.Button crearPuerto;
    }
}