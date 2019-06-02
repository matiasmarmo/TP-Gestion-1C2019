namespace FrbaCrucero
{
    partial class CruceroListado
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
            this.listadoDePosibles = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.atrasListado = new System.Windows.Forms.Button();
            this.modificarListado = new System.Windows.Forms.Button();
            this.limpiarListado = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.seleccionarID = new System.Windows.Forms.TextBox();
            this.seleccionarFabricante = new System.Windows.Forms.ComboBox();
            this.seleccionarModelo = new System.Windows.Forms.TextBox();
            this.buscarListado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listadoDePosibles
            // 
            this.listadoDePosibles.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listadoDePosibles.ColumnCount = 2;
            this.listadoDePosibles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.listadoDePosibles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.listadoDePosibles.Location = new System.Drawing.Point(12, 98);
            this.listadoDePosibles.Name = "listadoDePosibles";
            this.listadoDePosibles.RowCount = 2;
            this.listadoDePosibles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.listadoDePosibles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.listadoDePosibles.Size = new System.Drawing.Size(358, 111);
            this.listadoDePosibles.TabIndex = 0;
            this.listadoDePosibles.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrar por ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filtrar por fabricante:";
            // 
            // atrasListado
            // 
            this.atrasListado.Location = new System.Drawing.Point(12, 217);
            this.atrasListado.Name = "atrasListado";
            this.atrasListado.Size = new System.Drawing.Size(58, 28);
            this.atrasListado.TabIndex = 11;
            this.atrasListado.Text = "Atrás";
            this.atrasListado.UseVisualStyleBackColor = true;
            this.atrasListado.Click += new System.EventHandler(this.atrasListado_Click);
            // 
            // modificarListado
            // 
            this.modificarListado.Location = new System.Drawing.Point(243, 217);
            this.modificarListado.Name = "modificarListado";
            this.modificarListado.Size = new System.Drawing.Size(127, 30);
            this.modificarListado.TabIndex = 10;
            this.modificarListado.Text = "SELECCIONAR";
            this.modificarListado.UseVisualStyleBackColor = true;
            this.modificarListado.Click += new System.EventHandler(this.modificarListado_Click);
            // 
            // limpiarListado
            // 
            this.limpiarListado.Location = new System.Drawing.Point(110, 217);
            this.limpiarListado.Name = "limpiarListado";
            this.limpiarListado.Size = new System.Drawing.Size(127, 30);
            this.limpiarListado.TabIndex = 9;
            this.limpiarListado.Text = "LIMPIAR";
            this.limpiarListado.UseVisualStyleBackColor = true;
            this.limpiarListado.Click += new System.EventHandler(this.limpiarListado_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Filtrar por modelo:";
            // 
            // seleccionarID
            // 
            this.seleccionarID.Location = new System.Drawing.Point(158, 9);
            this.seleccionarID.Name = "seleccionarID";
            this.seleccionarID.Size = new System.Drawing.Size(158, 22);
            this.seleccionarID.TabIndex = 13;
            // 
            // seleccionarFabricante
            // 
            this.seleccionarFabricante.FormattingEnabled = true;
            this.seleccionarFabricante.Items.AddRange(new object[] {
            "P&O Cruises",
            "Costa Cruises",
            "fathom Cruise Line",
            "Holland America Line",
            "P&O Cruises Australia",
            "Princess Cruises",
            "AIDA Cruises",
            "Seaboum Cruise Line",
            "Cunard Line",
            "Carnival Cruise Lines"});
            this.seleccionarFabricante.Location = new System.Drawing.Point(158, 38);
            this.seleccionarFabricante.Name = "seleccionarFabricante";
            this.seleccionarFabricante.Size = new System.Drawing.Size(158, 24);
            this.seleccionarFabricante.TabIndex = 15;
            // 
            // seleccionarModelo
            // 
            this.seleccionarModelo.Location = new System.Drawing.Point(158, 70);
            this.seleccionarModelo.Name = "seleccionarModelo";
            this.seleccionarModelo.Size = new System.Drawing.Size(158, 22);
            this.seleccionarModelo.TabIndex = 16;
            // 
            // buscarListado
            // 
            this.buscarListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarListado.Location = new System.Drawing.Point(322, 4);
            this.buscarListado.Name = "buscarListado";
            this.buscarListado.Size = new System.Drawing.Size(48, 88);
            this.buscarListado.TabIndex = 17;
            this.buscarListado.Text = "C\r\nA\r\nR\r\nG\r\nA\r\nR";
            this.buscarListado.UseVisualStyleBackColor = true;
            this.buscarListado.Click += new System.EventHandler(this.buscarListado_Click);
            // 
            // CruceroListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.limpiarListado);
            this.Controls.Add(this.buscarListado);
            this.Controls.Add(this.seleccionarModelo);
            this.Controls.Add(this.seleccionarFabricante);
            this.Controls.Add(this.seleccionarID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modificarListado);
            this.Controls.Add(this.atrasListado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listadoDePosibles);
            this.Name = "CruceroListado";
            this.Text = "UTN FRBA";
            this.Load += new System.EventHandler(this.CruceroListado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel listadoDePosibles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button atrasListado;
        private System.Windows.Forms.Button modificarListado;
        private System.Windows.Forms.Button limpiarListado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox seleccionarID;
        private System.Windows.Forms.ComboBox seleccionarFabricante;
        private System.Windows.Forms.TextBox seleccionarModelo;
        private System.Windows.Forms.Button buscarListado;

    }
}