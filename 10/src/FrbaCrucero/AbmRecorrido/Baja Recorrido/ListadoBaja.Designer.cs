namespace FrbaCrucero
{
    partial class ListadoBaja
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
            this.button1 = new System.Windows.Forms.Button();
            this.idRecorrido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listaBaja = new System.Windows.Forms.DataGridView();
            this.RECORRIDO_CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO_RECORRIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atras = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaBaja)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.atras);
            this.groupBox1.Controls.Add(this.listaBaja);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.idRecorrido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione un recorrido:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idRecorrido
            // 
            this.idRecorrido.Location = new System.Drawing.Point(105, 46);
            this.idRecorrido.Name = "idRecorrido";
            this.idRecorrido.Size = new System.Drawing.Size(100, 20);
            this.idRecorrido.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID Recorrido:";
            // 
            // listaBaja
            // 
            this.listaBaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaBaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RECORRIDO_CODIGO,
            this.ESTADO_RECORRIDO});
            this.listaBaja.Location = new System.Drawing.Point(31, 125);
            this.listaBaja.Name = "listaBaja";
            this.listaBaja.Size = new System.Drawing.Size(264, 171);
            this.listaBaja.TabIndex = 10;
            // 
            // RECORRIDO_CODIGO
            // 
            this.RECORRIDO_CODIGO.HeaderText = "RECORRIDO_CODIGO";
            this.RECORRIDO_CODIGO.Name = "RECORRIDO_CODIGO";
            // 
            // ESTADO_RECORRIDO
            // 
            this.ESTADO_RECORRIDO.HeaderText = "ESTADO_RECORRIDO";
            this.ESTADO_RECORRIDO.Name = "ESTADO_RECORRIDO";
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(6, 319);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(75, 23);
            this.atras.TabIndex = 11;
            this.atras.Text = "Atras";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(130, 319);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(256, 319);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Continuar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ListadoBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 381);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoBaja";
            this.Text = "ListadoBaja";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaBaja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idRecorrido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listaBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn RECORRIDO_CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO_RECORRIDO;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button atras;
    }
}