namespace FrbaCrucero
{
    partial class ListadoRecorrido
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
            this.label2 = new System.Windows.Forms.Label();
            this.idRecorrido = new System.Windows.Forms.TextBox();
            this.idPuerto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listRecorrido = new System.Windows.Forms.DataGridView();
            this.RECORRIDO_CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDEN_TRAMOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUERTO_DESDE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUERTO_HASTA_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RECORRIDO_PRECIO_BASE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listRecorrido)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Recorrido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Puerto:";
            // 
            // idRecorrido
            // 
            this.idRecorrido.Location = new System.Drawing.Point(84, 36);
            this.idRecorrido.Name = "idRecorrido";
            this.idRecorrido.Size = new System.Drawing.Size(100, 20);
            this.idRecorrido.TabIndex = 2;
            // 
            // idPuerto
            // 
            this.idPuerto.Location = new System.Drawing.Point(84, 78);
            this.idPuerto.Name = "idPuerto";
            this.idPuerto.Size = new System.Drawing.Size(100, 20);
            this.idPuerto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio:";
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(84, 121);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(100, 20);
            this.precio.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Atras";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(486, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Continuar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(250, 360);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listRecorrido);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.precio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.idPuerto);
            this.groupBox1.Controls.Add(this.idRecorrido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por:";
            // 
            // listRecorrido
            // 
            this.listRecorrido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listRecorrido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RECORRIDO_CODIGO,
            this.ORDEN_TRAMOS,
            this.PUERTO_DESDE_ID,
            this.PUERTO_HASTA_ID,
            this.RECORRIDO_PRECIO_BASE});
            this.listRecorrido.Location = new System.Drawing.Point(10, 204);
            this.listRecorrido.Name = "listRecorrido";
            this.listRecorrido.Size = new System.Drawing.Size(547, 150);
            this.listRecorrido.TabIndex = 11;
            // 
            // RECORRIDO_CODIGO
            // 
            this.RECORRIDO_CODIGO.HeaderText = "RECORRIDO_CODIGO";
            this.RECORRIDO_CODIGO.Name = "RECORRIDO_CODIGO";
            // 
            // ORDEN_TRAMOS
            // 
            this.ORDEN_TRAMOS.HeaderText = "ORDEN_TRAMOS";
            this.ORDEN_TRAMOS.Name = "ORDEN_TRAMOS";
            // 
            // PUERTO_DESDE_ID
            // 
            this.PUERTO_DESDE_ID.HeaderText = "PUERTO_DESDE_ID";
            this.PUERTO_DESDE_ID.Name = "PUERTO_DESDE_ID";
            // 
            // PUERTO_HASTA_ID
            // 
            this.PUERTO_HASTA_ID.HeaderText = "PUERTO_HASTA_ID";
            this.PUERTO_HASTA_ID.Name = "PUERTO_HASTA_ID";
            // 
            // RECORRIDO_PRECIO_BASE
            // 
            this.RECORRIDO_PRECIO_BASE.HeaderText = "RECORRIDO_PRECIO_BASE";
            this.RECORRIDO_PRECIO_BASE.Name = "RECORRIDO_PRECIO_BASE";
            // 
            // ListadoRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 411);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoRecorrido";
            this.Text = "ListadoRecorrido";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listRecorrido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idRecorrido;
        private System.Windows.Forms.TextBox idPuerto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView listRecorrido;
        private System.Windows.Forms.DataGridViewTextBoxColumn RECORRIDO_CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDEN_TRAMOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUERTO_DESDE_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUERTO_HASTA_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RECORRIDO_PRECIO_BASE;
    }
}