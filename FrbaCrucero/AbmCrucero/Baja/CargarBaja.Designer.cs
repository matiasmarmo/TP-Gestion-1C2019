namespace FrbaCrucero
{
    partial class CargarBaja
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
            this.bajaCru = new System.Windows.Forms.GroupBox();
            this.atrasBaja = new System.Windows.Forms.Button();
            this.darBaja = new System.Windows.Forms.Button();
            this.limpiarBaja = new System.Windows.Forms.Button();
            this.bajaC = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.bajaCru.SuspendLayout();
            this.SuspendLayout();
            // 
            // bajaCru
            // 
            this.bajaCru.Controls.Add(this.atrasBaja);
            this.bajaCru.Controls.Add(this.darBaja);
            this.bajaCru.Controls.Add(this.limpiarBaja);
            this.bajaCru.Controls.Add(this.bajaC);
            this.bajaCru.Controls.Add(this.id);
            this.bajaCru.Location = new System.Drawing.Point(12, 12);
            this.bajaCru.Name = "bajaCru";
            this.bajaCru.Size = new System.Drawing.Size(358, 229);
            this.bajaCru.TabIndex = 1;
            this.bajaCru.TabStop = false;
            this.bajaCru.Text = "Dar Baja Crucero";
            // 
            // atrasBaja
            // 
            this.atrasBaja.Location = new System.Drawing.Point(46, 129);
            this.atrasBaja.Name = "atrasBaja";
            this.atrasBaja.Size = new System.Drawing.Size(76, 66);
            this.atrasBaja.TabIndex = 8;
            this.atrasBaja.Text = "Atrás";
            this.atrasBaja.UseVisualStyleBackColor = true;
            this.atrasBaja.Click += new System.EventHandler(this.atrasBaja_Click);
            // 
            // darBaja
            // 
            this.darBaja.Location = new System.Drawing.Point(147, 165);
            this.darBaja.Name = "darBaja";
            this.darBaja.Size = new System.Drawing.Size(157, 30);
            this.darBaja.TabIndex = 5;
            this.darBaja.Text = "DAR BAJA";
            this.darBaja.UseVisualStyleBackColor = true;
            this.darBaja.Click += new System.EventHandler(this.darBaja_Click);
            // 
            // limpiarBaja
            // 
            this.limpiarBaja.Location = new System.Drawing.Point(147, 129);
            this.limpiarBaja.Name = "limpiarBaja";
            this.limpiarBaja.Size = new System.Drawing.Size(157, 30);
            this.limpiarBaja.TabIndex = 4;
            this.limpiarBaja.Text = "LIMPIAR";
            this.limpiarBaja.UseVisualStyleBackColor = true;
            this.limpiarBaja.Click += new System.EventHandler(this.limpiarBaja_Click);
            // 
            // bajaC
            // 
            this.bajaC.Location = new System.Drawing.Point(77, 78);
            this.bajaC.Name = "bajaC";
            this.bajaC.Size = new System.Drawing.Size(196, 22);
            this.bajaC.TabIndex = 3;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(134, 58);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(79, 17);
            this.id.TabIndex = 0;
            this.id.Text = "ID Crucero:";
            // 
            // CargarBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.bajaCru);
            this.Name = "CargarBaja";
            this.Text = "UTN FRBA";
            this.bajaCru.ResumeLayout(false);
            this.bajaCru.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox bajaCru;
        private System.Windows.Forms.Button atrasBaja;
        private System.Windows.Forms.Button darBaja;
        private System.Windows.Forms.Button limpiarBaja;
        private System.Windows.Forms.TextBox bajaC;
        private System.Windows.Forms.Label id;
    }
}