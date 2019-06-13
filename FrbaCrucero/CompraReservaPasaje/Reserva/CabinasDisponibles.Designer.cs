namespace FrbaCrucero
{
    partial class CabinasDisponibles
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CABINA_NRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CABINA_PISO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CABINA_DESCRIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SELECCIONAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CABINAS DISPONIBLES:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CABINA_NRO,
            this.CABINA_PISO,
            this.CABINA_DESCRIP,
            this.SELECCIONAR});
            this.dataGridView1.Location = new System.Drawing.Point(13, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 224);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // CABINA_NRO
            // 
            this.CABINA_NRO.HeaderText = "CABINA NUMERO";
            this.CABINA_NRO.Name = "CABINA_NRO";
            this.CABINA_NRO.ReadOnly = true;
            this.CABINA_NRO.Width = 70;
            // 
            // CABINA_PISO
            // 
            this.CABINA_PISO.HeaderText = "CABINA PISO";
            this.CABINA_PISO.Name = "CABINA_PISO";
            this.CABINA_PISO.ReadOnly = true;
            this.CABINA_PISO.Width = 70;
            // 
            // CABINA_DESCRIP
            // 
            this.CABINA_DESCRIP.HeaderText = "CABINA DESCRIPCION";
            this.CABINA_DESCRIP.Name = "CABINA_DESCRIP";
            this.CABINA_DESCRIP.ReadOnly = true;
            this.CABINA_DESCRIP.Width = 140;
            // 
            // SELECCIONAR
            // 
            this.SELECCIONAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SELECCIONAR.HeaderText = "SELECCIONADA";
            this.SELECCIONAR.Name = "SELECCIONAR";
            this.SELECCIONAR.Text = "SELECCIONAR";
            this.SELECCIONAR.ToolTipText = "SELECCIONAR";
            this.SELECCIONAR.UseColumnTextForButtonValue = true;
            this.SELECCIONAR.Width = 95;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "VOLVER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CabinasDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 323);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "CabinasDisponibles";
            this.Text = "CabinasDisponibles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CABINA_NRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CABINA_PISO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CABINA_DESCRIP;
        private System.Windows.Forms.DataGridViewButtonColumn SELECCIONAR;
        private System.Windows.Forms.Button button1;
    }
}