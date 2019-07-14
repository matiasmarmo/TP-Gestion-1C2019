namespace FrbaCrucero
{
    partial class NuevoCrucero
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
            this.crear_rol = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cargar_cabinas = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.nombreID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crear_rol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // crear_rol
            // 
            this.crear_rol.Controls.Add(this.label2);
            this.crear_rol.Controls.Add(this.label1);
            this.crear_rol.Controls.Add(this.cargar_cabinas);
            this.crear_rol.Controls.Add(this.limpiar);
            this.crear_rol.Controls.Add(this.nombreID);
            this.crear_rol.Location = new System.Drawing.Point(11, 11);
            this.crear_rol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crear_rol.Name = "crear_rol";
            this.crear_rol.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crear_rol.Size = new System.Drawing.Size(357, 263);
            this.crear_rol.TabIndex = 1;
            this.crear_rol.TabStop = false;
            this.crear_rol.Text = "Nuevo Crucero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 68);
            this.label2.TabIndex = 14;
            this.label2.Text = " Se necesita crear un crucero nuevo para suplir\r\n la ausencia del crucero viejo. " +
    "El mismo se va a \r\n    crear con el mismo fabricante, modelo y \r\ncabinas para po" +
    "der cumplir con sus requisitos.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID nuevo crucero:";
            // 
            // cargar_cabinas
            // 
            this.cargar_cabinas.Location = new System.Drawing.Point(177, 199);
            this.cargar_cabinas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cargar_cabinas.Name = "cargar_cabinas";
            this.cargar_cabinas.Size = new System.Drawing.Size(157, 51);
            this.cargar_cabinas.TabIndex = 5;
            this.cargar_cabinas.Text = "CREAR CRUCERO";
            this.cargar_cabinas.UseVisualStyleBackColor = true;
            this.cargar_cabinas.Click += new System.EventHandler(this.cargar_cabinas_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(27, 199);
            this.limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(110, 51);
            this.limpiar.TabIndex = 4;
            this.limpiar.Text = "LIMPIAR";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // nombreID
            // 
            this.nombreID.Location = new System.Drawing.Point(73, 145);
            this.nombreID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombreID.MaxLength = 12;
            this.nombreID.Name = "nombreID";
            this.nombreID.Size = new System.Drawing.Size(196, 22);
            this.nombreID.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4});
            this.dataGridView1.Location = new System.Drawing.Point(144, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(538, 240);
            this.dataGridView1.TabIndex = 15;
            // 
            // col1
            // 
            this.col1.HeaderText = "col1";
            this.col1.Name = "col1";
            // 
            // col2
            // 
            this.col2.HeaderText = "col2";
            this.col2.Name = "col2";
            // 
            // col3
            // 
            this.col3.HeaderText = "col3";
            this.col3.Name = "col3";
            // 
            // col4
            // 
            this.col4.HeaderText = "col4";
            this.col4.Name = "col4";
            // 
            // NuevoCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 279);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.crear_rol);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NuevoCrucero";
            this.Text = "AbmPuerto";
            this.crear_rol.ResumeLayout(false);
            this.crear_rol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox crear_rol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cargar_cabinas;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;


    }
}