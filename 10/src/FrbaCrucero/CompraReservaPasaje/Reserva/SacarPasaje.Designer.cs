namespace FrbaCrucero
{
    partial class SacarPasaje
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
            this.BTN_ATRAS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BTN_SELEC1 = new System.Windows.Forms.Button();
            this.BTN_SELEC2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PUERTO_ORIGEN = new System.Windows.Forms.ComboBox();
            this.PUERTO_DESTINO = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.VIAJE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRUCERO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VER_CABINAS_DISPONIBLES = new System.Windows.Forms.DataGridViewButtonColumn();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_ATRAS
            // 
            this.BTN_ATRAS.Location = new System.Drawing.Point(12, 267);
            this.BTN_ATRAS.Name = "BTN_ATRAS";
            this.BTN_ATRAS.Size = new System.Drawing.Size(75, 23);
            this.BTN_ATRAS.TabIndex = 0;
            this.BTN_ATRAS.Text = "ATRAS";
            this.BTN_ATRAS.UseVisualStyleBackColor = true;
            this.BTN_ATRAS.Click += new System.EventHandler(this.BTN_ATRAS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "FECHA SALIDA:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(93, 20);
            this.textBox1.TabIndex = 5;
            // 
            // BTN_SELEC1
            // 
            this.BTN_SELEC1.Location = new System.Drawing.Point(203, 4);
            this.BTN_SELEC1.Name = "BTN_SELEC1";
            this.BTN_SELEC1.Size = new System.Drawing.Size(95, 23);
            this.BTN_SELEC1.TabIndex = 6;
            this.BTN_SELEC1.Text = "SELECCIONAR";
            this.BTN_SELEC1.UseVisualStyleBackColor = true;
            this.BTN_SELEC1.Click += new System.EventHandler(this.BTN_SELEC1_Click);
            // 
            // BTN_SELEC2
            // 
            this.BTN_SELEC2.Location = new System.Drawing.Point(203, 29);
            this.BTN_SELEC2.Name = "BTN_SELEC2";
            this.BTN_SELEC2.Size = new System.Drawing.Size(95, 23);
            this.BTN_SELEC2.TabIndex = 9;
            this.BTN_SELEC2.Text = "SELECCIONAR";
            this.BTN_SELEC2.UseVisualStyleBackColor = true;
            this.BTN_SELEC2.Click += new System.EventHandler(this.BTN_SELEC2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(93, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "FECHA LLEGADA:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "LIMPIAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(462, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "BUSCAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "PUERTO ORIGEN:";
            // 
            // PUERTO_ORIGEN
            // 
            this.PUERTO_ORIGEN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PUERTO_ORIGEN.FormattingEnabled = true;
            this.PUERTO_ORIGEN.Location = new System.Drawing.Point(416, 6);
            this.PUERTO_ORIGEN.Name = "PUERTO_ORIGEN";
            this.PUERTO_ORIGEN.Size = new System.Drawing.Size(121, 21);
            this.PUERTO_ORIGEN.TabIndex = 13;
            // 
            // PUERTO_DESTINO
            // 
            this.PUERTO_DESTINO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PUERTO_DESTINO.FormattingEnabled = true;
            this.PUERTO_DESTINO.Location = new System.Drawing.Point(416, 31);
            this.PUERTO_DESTINO.Name = "PUERTO_DESTINO";
            this.PUERTO_DESTINO.Size = new System.Drawing.Size(121, 21);
            this.PUERTO_DESTINO.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "PUERTO DESTINO:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VIAJE_ID,
            this.CRUCERO_ID,
            this.VER_CABINAS_DISPONIBLES});
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 169);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // VIAJE_ID
            // 
            this.VIAJE_ID.HeaderText = "VIAJE ID";
            this.VIAJE_ID.Name = "VIAJE_ID";
            // 
            // CRUCERO_ID
            // 
            this.CRUCERO_ID.HeaderText = "CRUCERO ID";
            this.CRUCERO_ID.Name = "CRUCERO_ID";
            this.CRUCERO_ID.Width = 150;
            // 
            // VER_CABINAS_DISPONIBLES
            // 
            this.VER_CABINAS_DISPONIBLES.HeaderText = "VER CABINAS DISPONIBLES";
            this.VER_CABINAS_DISPONIBLES.Name = "VER_CABINAS_DISPONIBLES";
            this.VER_CABINAS_DISPONIBLES.Text = "VER CABINAS";
            this.VER_CABINAS_DISPONIBLES.ToolTipText = "VER CABINAS";
            this.VER_CABINAS_DISPONIBLES.UseColumnTextForButtonValue = true;
            this.VER_CABINAS_DISPONIBLES.Width = 150;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(203, 4);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 17;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(247, 143);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(141, 23);
            this.btnConfirmar.TabIndex = 18;
            this.btnConfirmar.Text = "Confirmar Fecha";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // SacarPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 297);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PUERTO_DESTINO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PUERTO_ORIGEN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BTN_SELEC2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_SELEC1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_ATRAS);
            this.Name = "SacarPasaje";
            this.Text = "SacarPasaje";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_ATRAS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BTN_SELEC1;
        private System.Windows.Forms.Button BTN_SELEC2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PUERTO_ORIGEN;
        private System.Windows.Forms.ComboBox PUERTO_DESTINO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIAJE_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRUCERO_ID;
        private System.Windows.Forms.DataGridViewButtonColumn VER_CABINAS_DISPONIBLES;
    }
}