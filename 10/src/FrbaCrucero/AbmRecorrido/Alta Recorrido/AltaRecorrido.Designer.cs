namespace FrbaCrucero
{
    partial class AltaRecorrido
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
            this.puertoHasta = new System.Windows.Forms.ComboBox();
            this.puertoDesde = new System.Windows.Forms.ComboBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.idRecorrido = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.puertoHasta);
            this.groupBox1.Controls.Add(this.puertoDesde);
            this.groupBox1.Controls.Add(this.precio);
            this.groupBox1.Controls.Add(this.idRecorrido);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(437, 363);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Completar todas las opciones:";
            // 
            // puertoHasta
            // 
            this.puertoHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.puertoHasta.FormattingEnabled = true;
            this.puertoHasta.Location = new System.Drawing.Point(167, 169);
            this.puertoHasta.Margin = new System.Windows.Forms.Padding(4);
            this.puertoHasta.Name = "puertoHasta";
            this.puertoHasta.Size = new System.Drawing.Size(160, 24);
            this.puertoHasta.TabIndex = 10;
            // 
            // puertoDesde
            // 
            this.puertoDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.puertoDesde.FormattingEnabled = true;
            this.puertoDesde.Location = new System.Drawing.Point(167, 110);
            this.puertoDesde.Margin = new System.Windows.Forms.Padding(4);
            this.puertoDesde.Name = "puertoDesde";
            this.puertoDesde.Size = new System.Drawing.Size(160, 24);
            this.puertoDesde.TabIndex = 9;
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(167, 220);
            this.precio.Margin = new System.Windows.Forms.Padding(4);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(160, 22);
            this.precio.TabIndex = 8;
            this.precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precio_KeyPress);
            // 
            // idRecorrido
            // 
            this.idRecorrido.Location = new System.Drawing.Point(167, 53);
            this.idRecorrido.Margin = new System.Windows.Forms.Padding(4);
            this.idRecorrido.MaxLength = 8;
            this.idRecorrido.Name = "idRecorrido";
            this.idRecorrido.Size = new System.Drawing.Size(160, 22);
            this.idRecorrido.TabIndex = 7;
            this.idRecorrido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idRecorrido_KeyPress);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(308, 325);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "Continuar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 325);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 325);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Puerto hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puerto desde:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID recorrido:";
            // 
            // AltaRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 393);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AltaRecorrido";
            this.Text = "AltaRecorrido";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox puertoHasta;
        private System.Windows.Forms.ComboBox puertoDesde;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.TextBox idRecorrido;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        public GD1C2019DataSet1TableAdapters.PuertoTableAdapter puertoTableAdapter2 { get; set; }
    }
}