namespace FrbaCrucero
{
    partial class ModificarError
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
            this.modError = new System.Windows.Forms.GroupBox();
            this.volver_mod = new System.Windows.Forms.Button();
            this.error_modif = new System.Windows.Forms.Label();
            this.modError.SuspendLayout();
            this.SuspendLayout();
            // 
            // modError
            // 
            this.modError.Controls.Add(this.volver_mod);
            this.modError.Controls.Add(this.error_modif);
            this.modError.Location = new System.Drawing.Point(13, 12);
            this.modError.Name = "modError";
            this.modError.Size = new System.Drawing.Size(357, 228);
            this.modError.TabIndex = 4;
            this.modError.TabStop = false;
            this.modError.Text = "Error modificación";
            // 
            // volver_mod
            // 
            this.volver_mod.Location = new System.Drawing.Point(110, 120);
            this.volver_mod.Name = "volver_mod";
            this.volver_mod.Size = new System.Drawing.Size(149, 53);
            this.volver_mod.TabIndex = 2;
            this.volver_mod.Text = "Volver a modificar\r\n  el crucero";
            this.volver_mod.UseVisualStyleBackColor = true;
            this.volver_mod.Click += new System.EventHandler(this.volver_mod_Click);
            // 
            // error_modif
            // 
            this.error_modif.AutoSize = true;
            this.error_modif.Location = new System.Drawing.Point(84, 56);
            this.error_modif.Name = "error_modif";
            this.error_modif.Size = new System.Drawing.Size(212, 51);
            this.error_modif.TabIndex = 0;
            this.error_modif.Text = "Los datos del crucero cargados \r\n     no son compatibles con\r\n       nuestra base" +
    " de datos";
            // 
            // ModificarError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.modError);
            this.Name = "ModificarError";
            this.Text = "UTN FRBA";
            this.modError.ResumeLayout(false);
            this.modError.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox modError;
        private System.Windows.Forms.Button volver_mod;
        private System.Windows.Forms.Label error_modif;
    }
}