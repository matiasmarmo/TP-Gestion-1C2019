namespace FrbaCrucero
{
    partial class ModificarFin
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
            this.modf = new System.Windows.Forms.GroupBox();
            this.otro_mod = new System.Windows.Forms.Button();
            this.iniciomod = new System.Windows.Forms.Button();
            this.md = new System.Windows.Forms.Label();
            this.modf.SuspendLayout();
            this.SuspendLayout();
            // 
            // modf
            // 
            this.modf.Controls.Add(this.otro_mod);
            this.modf.Controls.Add(this.iniciomod);
            this.modf.Controls.Add(this.md);
            this.modf.Location = new System.Drawing.Point(13, 12);
            this.modf.Name = "modf";
            this.modf.Size = new System.Drawing.Size(357, 228);
            this.modf.TabIndex = 3;
            this.modf.TabStop = false;
            this.modf.Text = "Crucero modificado";
            // 
            // otro_mod
            // 
            this.otro_mod.Location = new System.Drawing.Point(196, 114);
            this.otro_mod.Name = "otro_mod";
            this.otro_mod.Size = new System.Drawing.Size(134, 50);
            this.otro_mod.TabIndex = 2;
            this.otro_mod.Text = "Modificar otro crucero";
            this.otro_mod.UseVisualStyleBackColor = true;
            this.otro_mod.Click += new System.EventHandler(this.otro_mod_Click);
            // 
            // iniciomod
            // 
            this.iniciomod.Location = new System.Drawing.Point(37, 114);
            this.iniciomod.Name = "iniciomod";
            this.iniciomod.Size = new System.Drawing.Size(129, 50);
            this.iniciomod.TabIndex = 1;
            this.iniciomod.Text = "Volver al inicio";
            this.iniciomod.UseVisualStyleBackColor = true;
            this.iniciomod.Click += new System.EventHandler(this.iniciomod_Click);
            // 
            // md
            // 
            this.md.AutoSize = true;
            this.md.Location = new System.Drawing.Point(79, 68);
            this.md.Name = "md";
            this.md.Size = new System.Drawing.Size(171, 34);
            this.md.TabIndex = 0;
            this.md.Text = "          El crucero se ha \r\nmodificado correctamente";
            // 
            // ModificarFin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.modf);
            this.Name = "ModificarFin";
            this.Text = "UTN FRBA";
            this.modf.ResumeLayout(false);
            this.modf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox modf;
        private System.Windows.Forms.Button otro_mod;
        private System.Windows.Forms.Button iniciomod;
        private System.Windows.Forms.Label md;
    }
}