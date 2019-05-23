namespace FrbaCrucero.AbmPuerto
{
    partial class CrearPuerto
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
            this.ingresarDatos = new System.Windows.Forms.GroupBox();
            this.estadoPuerto = new System.Windows.Forms.TextBox();
            this.nombrePuerto = new System.Windows.Forms.TextBox();
            this.idPuerto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ingresarDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // ingresarDatos
            // 
            this.ingresarDatos.Controls.Add(this.button1);
            this.ingresarDatos.Controls.Add(this.estadoPuerto);
            this.ingresarDatos.Controls.Add(this.nombrePuerto);
            this.ingresarDatos.Controls.Add(this.idPuerto);
            this.ingresarDatos.Controls.Add(this.label3);
            this.ingresarDatos.Controls.Add(this.label2);
            this.ingresarDatos.Controls.Add(this.label1);
            this.ingresarDatos.Location = new System.Drawing.Point(12, 12);
            this.ingresarDatos.Name = "ingresarDatos";
            this.ingresarDatos.Size = new System.Drawing.Size(248, 236);
            this.ingresarDatos.TabIndex = 0;
            this.ingresarDatos.TabStop = false;
            this.ingresarDatos.Text = "Ingresar datos:";
            this.ingresarDatos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // estadoPuerto
            // 
            this.estadoPuerto.Location = new System.Drawing.Point(99, 154);
            this.estadoPuerto.Name = "estadoPuerto";
            this.estadoPuerto.Size = new System.Drawing.Size(100, 20);
            this.estadoPuerto.TabIndex = 5;
            // 
            // nombrePuerto
            // 
            this.nombrePuerto.Location = new System.Drawing.Point(99, 108);
            this.nombrePuerto.Name = "nombrePuerto";
            this.nombrePuerto.Size = new System.Drawing.Size(100, 20);
            this.nombrePuerto.TabIndex = 4;
            // 
            // idPuerto
            // 
            this.idPuerto.Location = new System.Drawing.Point(99, 62);
            this.idPuerto.Name = "idPuerto";
            this.idPuerto.Size = new System.Drawing.Size(100, 20);
            this.idPuerto.TabIndex = 3;
            this.idPuerto.TextChanged += new System.EventHandler(this.idPuerto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado Puerto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Puerto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Puerto:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CrearPuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 260);
            this.Controls.Add(this.ingresarDatos);
            this.Name = "CrearPuerto";
            this.Text = "CrearPuerto";
            this.Load += new System.EventHandler(this.CrearPuerto_Load);
            this.ingresarDatos.ResumeLayout(false);
            this.ingresarDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ingresarDatos;
        private System.Windows.Forms.TextBox estadoPuerto;
        private System.Windows.Forms.TextBox nombrePuerto;
        private System.Windows.Forms.TextBox idPuerto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}