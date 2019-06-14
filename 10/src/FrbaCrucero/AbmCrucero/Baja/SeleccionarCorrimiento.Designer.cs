namespace FrbaCrucero
{
    partial class SeleccionarCorrimiento
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
            this.def = new System.Windows.Forms.Label();
            this.fdeserv = new System.Windows.Forms.Button();
            this.abc = new System.Windows.Forms.Label();
            this.dias = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dias);
            this.groupBox1.Controls.Add(this.def);
            this.groupBox1.Controls.Add(this.fdeserv);
            this.groupBox1.Controls.Add(this.abc);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 229);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fuera de servicio";
            // 
            // def
            // 
            this.def.AutoSize = true;
            this.def.Location = new System.Drawing.Point(11, 102);
            this.def.Name = "def";
            this.def.Size = new System.Drawing.Size(341, 51);
            this.def.TabIndex = 6;
            this.def.Text = "Tenga en cuenta que todos los viajes que tenga que\r\n     hacer este crucero se co" +
    "rreran la determinada \r\n              cantidad de días que se ingresó.";
            // 
            // fdeserv
            // 
            this.fdeserv.Location = new System.Drawing.Point(80, 167);
            this.fdeserv.Name = "fdeserv";
            this.fdeserv.Size = new System.Drawing.Size(184, 45);
            this.fdeserv.TabIndex = 5;
            this.fdeserv.Text = "DAR FUERA DE SERVICIO";
            this.fdeserv.UseVisualStyleBackColor = true;
            this.fdeserv.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // abc
            // 
            this.abc.AutoSize = true;
            this.abc.Location = new System.Drawing.Point(32, 39);
            this.abc.Name = "abc";
            this.abc.Size = new System.Drawing.Size(290, 17);
            this.abc.TabIndex = 3;
            this.abc.Text = "Indique la cantidad de dias fuera de servicio:\r\n";
            // 
            // dias
            // 
            this.dias.FormattingEnabled = true;
            this.dias.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.dias.Location = new System.Drawing.Point(107, 59);
            this.dias.Name = "dias";
            this.dias.Size = new System.Drawing.Size(121, 24);
            this.dias.TabIndex = 7;
            // 
            // SeleccionarCorrimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.groupBox1);
            this.Name = "SeleccionarCorrimiento";
            this.Text = "UTN FRBA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label abc;
        private System.Windows.Forms.Label def;
        private System.Windows.Forms.Button fdeserv;
        private System.Windows.Forms.ComboBox dias;
    }
}