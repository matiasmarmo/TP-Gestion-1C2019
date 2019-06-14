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
            this.BTN_MENU_PRINCIPAL = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BTN_ABONAR = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CRUCERO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRUCERO_RECORRIDO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FECHA_SALIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_LLEGADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESERVA_FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASAJE_PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_CONFIRMAR = new System.Windows.Forms.Button();
            this.CODIGO_RESERVA_TEXT = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CODIGO_RESERVA_LABEL
            // 
            this.CODIGO_RESERVA_LABEL.AutoSize = true;
            this.CODIGO_RESERVA_LABEL.Location = new System.Drawing.Point(25, 46);
            this.CODIGO_RESERVA_LABEL.Name = "CODIGO_RESERVA_LABEL";
            this.CODIGO_RESERVA_LABEL.Size = new System.Drawing.Size(106, 13);
            this.CODIGO_RESERVA_LABEL.TabIndex = 0;
            this.CODIGO_RESERVA_LABEL.Text = "CODIGO RESERVA:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_MENU_PRINCIPAL);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.BTN_ABONAR);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.BTN_CONFIRMAR);
            this.groupBox1.Controls.Add(this.CODIGO_RESERVA_TEXT);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 248);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCADOR DE RESERVAS";
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
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(148, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 10;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CRUCERO_ID,
            this.CRUCERO_RECORRIDO,
            this.FECHA_SALIDA,
            this.FECHA_LLEGADA,
            this.RESERVA_FECHA,
            this.PASAJE_PRECIO});
            this.dataGridView1.Location = new System.Drawing.Point(6, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 123);
            this.dataGridView1.TabIndex = 8;
            // 
            // CRUCERO_ID
            // 
            this.CRUCERO_ID.Frozen = true;
            this.CRUCERO_ID.HeaderText = "CRUCERO ID";
            this.CRUCERO_ID.Name = "CRUCERO_ID";
            this.CRUCERO_ID.ReadOnly = true;
            this.CRUCERO_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CRUCERO_RECORRIDO
            // 
            this.CRUCERO_RECORRIDO.HeaderText = "CRUCERO RECORRIDO - TRAMOS";
            this.CRUCERO_RECORRIDO.Name = "CRUCERO_RECORRIDO";
            this.CRUCERO_RECORRIDO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CRUCERO_RECORRIDO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CRUCERO_RECORRIDO.Width = 150;
            // 
            // FECHA_SALIDA
            // 
            this.FECHA_SALIDA.HeaderText = "FECHA SALIDA";
            this.FECHA_SALIDA.Name = "FECHA_SALIDA";
            this.FECHA_SALIDA.ReadOnly = true;
            this.FECHA_SALIDA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FECHA_SALIDA.Width = 70;
            // 
            // FECHA_LLEGADA
            // 
            this.FECHA_LLEGADA.HeaderText = "FECHA LLEGADA";
            this.FECHA_LLEGADA.Name = "FECHA_LLEGADA";
            this.FECHA_LLEGADA.ReadOnly = true;
            this.FECHA_LLEGADA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FECHA_LLEGADA.Width = 70;
            // 
            // RESERVA_FECHA
            // 
            this.RESERVA_FECHA.HeaderText = "RESERVA FECHA";
            this.RESERVA_FECHA.Name = "RESERVA_FECHA";
            this.RESERVA_FECHA.ReadOnly = true;
            this.RESERVA_FECHA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PASAJE_PRECIO
            // 
            this.PASAJE_PRECIO.HeaderText = "PASAJE PRECIO";
            this.PASAJE_PRECIO.Name = "PASAJE_PRECIO";
            this.PASAJE_PRECIO.ReadOnly = true;
            this.PASAJE_PRECIO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // ReservaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 269);
            this.Controls.Add(this.CODIGO_RESERVA_LABEL);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReservaPrincipal";
            this.Text = "PAGO DE RESERVAS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRUCERO_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn CRUCERO_RECORRIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_SALIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_LLEGADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESERVA_FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASAJE_PRECIO;
        private System.Windows.Forms.Button BTN_MENU_PRINCIPAL;
    }
}