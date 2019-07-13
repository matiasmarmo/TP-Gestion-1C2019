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
            this.button1 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CABINA_NRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CABINA_PISO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CABINA_DESCRIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SELECCIONAR = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CABINAS DISPONIBLES:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 39);
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 214);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Navy;
            this.label18.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label18.Location = new System.Drawing.Point(304, 6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 17);
            this.label18.TabIndex = 57;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrbaCrucero.Properties.Resources.crucero;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(490, 34);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
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
            // CabinasDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 323);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "CabinasDisponibles";
            this.Text = "CabinasDisponibles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CABINA_NRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CABINA_PISO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CABINA_DESCRIP;
        private System.Windows.Forms.DataGridViewButtonColumn SELECCIONAR;
    }
}