namespace FrbaCrucero
{
    partial class ReservaPrincipal
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
            this.CODIGO_RESERVA_LABEL = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_MENU_PRINCIPAL = new System.Windows.Forms.Button();
            this.BTN_ABONAR = new System.Windows.Forms.Button();
            this.BTN_CONFIRMAR = new System.Windows.Forms.Button();
            this.CODIGO_RESERVA_TEXT = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CRU_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AFSDFF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASAJE_PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CODIGO_RESERVA_LABEL
            // 
            this.CODIGO_RESERVA_LABEL.AutoSize = true;
            this.CODIGO_RESERVA_LABEL.Location = new System.Drawing.Point(25, 66);
            this.CODIGO_RESERVA_LABEL.Name = "CODIGO_RESERVA_LABEL";
            this.CODIGO_RESERVA_LABEL.Size = new System.Drawing.Size(106, 13);
            this.CODIGO_RESERVA_LABEL.TabIndex = 0;
            this.CODIGO_RESERVA_LABEL.Text = "CODIGO RESERVA:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.BTN_MENU_PRINCIPAL);
            this.groupBox1.Controls.Add(this.BTN_ABONAR);
            this.groupBox1.Controls.Add(this.BTN_CONFIRMAR);
            this.groupBox1.Controls.Add(this.CODIGO_RESERVA_TEXT);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 248);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCADOR DE RESERVAS";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 48;
            this.button2.Text = "VER TRAMOS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CRU_ID,
            this.Column3,
            this.AFSDFF,
            this.Column2,
            this.Column1,
            this.PASAJE_PRECIO});
            this.dataGridView1.Location = new System.Drawing.Point(6, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 123);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_MENU_PRINCIPAL
            // 
            this.BTN_MENU_PRINCIPAL.Location = new System.Drawing.Point(6, 219);
            this.BTN_MENU_PRINCIPAL.Name = "BTN_MENU_PRINCIPAL";
            this.BTN_MENU_PRINCIPAL.Size = new System.Drawing.Size(76, 23);
            this.BTN_MENU_PRINCIPAL.TabIndex = 29;
            this.BTN_MENU_PRINCIPAL.Text = "ATRAS";
            this.BTN_MENU_PRINCIPAL.UseVisualStyleBackColor = true;
            this.BTN_MENU_PRINCIPAL.Click += new System.EventHandler(this.BTN_MENU_PRINCIPAL_Click);
            // 
            // BTN_ABONAR
            // 
            this.BTN_ABONAR.Location = new System.Drawing.Point(565, 219);
            this.BTN_ABONAR.Name = "BTN_ABONAR";
            this.BTN_ABONAR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BTN_ABONAR.Size = new System.Drawing.Size(85, 23);
            this.BTN_ABONAR.TabIndex = 9;
            this.BTN_ABONAR.Text = "ABONAR";
            this.BTN_ABONAR.UseVisualStyleBackColor = true;
            this.BTN_ABONAR.Click += new System.EventHandler(this.BTN_ABONAR_Click);
            // 
            // BTN_CONFIRMAR
            // 
            this.BTN_CONFIRMAR.Location = new System.Drawing.Point(169, 61);
            this.BTN_CONFIRMAR.Name = "BTN_CONFIRMAR";
            this.BTN_CONFIRMAR.Size = new System.Drawing.Size(85, 23);
            this.BTN_CONFIRMAR.TabIndex = 1;
            this.BTN_CONFIRMAR.Text = "CONFIRMAR";
            this.BTN_CONFIRMAR.UseVisualStyleBackColor = true;
            this.BTN_CONFIRMAR.Click += new System.EventHandler(this.BTN_CONFIRMAR_Click);
            // 
            // CODIGO_RESERVA_TEXT
            // 
            this.CODIGO_RESERVA_TEXT.Location = new System.Drawing.Point(126, 34);
            this.CODIGO_RESERVA_TEXT.Name = "CODIGO_RESERVA_TEXT";
            this.CODIGO_RESERVA_TEXT.Size = new System.Drawing.Size(128, 20);
            this.CODIGO_RESERVA_TEXT.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Navy;
            this.label18.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label18.Location = new System.Drawing.Point(500, 6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 17);
            this.label18.TabIndex = 57;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrbaCrucero.Properties.Resources.crucero;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(686, 34);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // CRU_ID
            // 
            this.CRU_ID.HeaderText = "CRUCERO ID";
            this.CRU_ID.Name = "CRU_ID";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.HeaderText = "RECORRIDO TRAMOS";
            this.Column3.Name = "Column3";
            this.Column3.Text = "Column3";
            this.Column3.ToolTipText = "Column3";
            this.Column3.UseColumnTextForButtonValue = true;
            this.Column3.Width = 114;
            // 
            // AFSDFF
            // 
            this.AFSDFF.HeaderText = "FECHA SALIDA";
            this.AFSDFF.Name = "AFSDFF";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "FECHA LLEGADA";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "RESERVA FECHA";
            this.Column1.Name = "Column1";
            // 
            // PASAJE_PRECIO
            // 
            this.PASAJE_PRECIO.HeaderText = "PASAJE PRECIO";
            this.PASAJE_PRECIO.Name = "PASAJE_PRECIO";
            this.PASAJE_PRECIO.ReadOnly = true;
            this.PASAJE_PRECIO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PASAJE_PRECIO.Width = 80;
            // 
            // ReservaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 287);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CODIGO_RESERVA_LABEL);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReservaPrincipal";
            this.Text = "PAGO DE RESERVAS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CODIGO_RESERVA_LABEL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_CONFIRMAR;
        private System.Windows.Forms.TextBox CODIGO_RESERVA_TEXT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_ABONAR;
        private System.Windows.Forms.Button BTN_MENU_PRINCIPAL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRU_ID;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn AFSDFF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASAJE_PRECIO;
    }
}