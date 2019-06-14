namespace FrbaCrucero
{
    partial class ModificarRecorrido
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nuevoPrecioBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.puertoHBox = new System.Windows.Forms.TextBox();
            this.puertoDBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.puertoDesdeBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.puertoHastaBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nuevoPrecioBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.puertoHBox);
            this.groupBox1.Controls.Add(this.puertoDBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.puertoDesdeBox);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.puertoHastaBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Complete todas las opciones para modificar el recorrido:";
            // 
            // nuevoPrecioBox
            // 
            this.nuevoPrecioBox.Location = new System.Drawing.Point(139, 180);
            this.nuevoPrecioBox.Name = "nuevoPrecioBox";
            this.nuevoPrecioBox.Size = new System.Drawing.Size(121, 20);
            this.nuevoPrecioBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nuevo Precio:";
            // 
            // puertoHBox
            // 
            this.puertoHBox.Location = new System.Drawing.Point(139, 64);
            this.puertoHBox.Name = "puertoHBox";
            this.puertoHBox.Size = new System.Drawing.Size(121, 20);
            this.puertoHBox.TabIndex = 10;
            // 
            // puertoDBox
            // 
            this.puertoDBox.Location = new System.Drawing.Point(139, 35);
            this.puertoDBox.Name = "puertoDBox";
            this.puertoDBox.Size = new System.Drawing.Size(121, 20);
            this.puertoDBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Puerto hasta actual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Puerto desde actual:";
            // 
            // puertoDesdeBox
            // 
            this.puertoDesdeBox.FormattingEnabled = true;
            this.puertoDesdeBox.Location = new System.Drawing.Point(139, 99);
            this.puertoDesdeBox.Name = "puertoDesdeBox";
            this.puertoDesdeBox.Size = new System.Drawing.Size(121, 21);
            this.puertoDesdeBox.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Continuar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // puertoHastaBox
            // 
            this.puertoHastaBox.FormattingEnabled = true;
            this.puertoHastaBox.Location = new System.Drawing.Point(139, 140);
            this.puertoHastaBox.Name = "puertoHastaBox";
            this.puertoHastaBox.Size = new System.Drawing.Size(121, 21);
            this.puertoHastaBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Puerto Hasta (nuevo):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puerto Desde (nuevo):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModificarRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 285);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificarRecorrido";
            this.Text = "ModificarRecorrido";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox puertoDesdeBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox puertoHastaBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox puertoHBox;
        private System.Windows.Forms.TextBox puertoDBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nuevoPrecioBox;
        private System.Windows.Forms.Label label5;
    }
}