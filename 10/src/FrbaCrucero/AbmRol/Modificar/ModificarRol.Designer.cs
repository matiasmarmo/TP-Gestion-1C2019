namespace FrbaCrucero
{
    partial class ModificarRol
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
            this.modificar_rol = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Listadoxfunc = new System.Windows.Forms.DataGridView();
            this.NOMBRE_ROL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNCIONALIDAD_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNCIONALIDAD_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listadoAgregar = new System.Windows.Forms.DataGridView();
            this.NOMBRE__ROL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNCIONALIDAD__ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNCIONALIDAD__DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nuevoNombre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Atras = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.modificar_rol.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Listadoxfunc)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoAgregar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // modificar_rol
            // 
            this.modificar_rol.Controls.Add(this.groupBox4);
            this.modificar_rol.Controls.Add(this.groupBox3);
            this.modificar_rol.Controls.Add(this.groupBox1);
            this.modificar_rol.Controls.Add(this.label1);
            this.modificar_rol.Controls.Add(this.Atras);
            this.modificar_rol.Controls.Add(this.nombre);
            this.modificar_rol.Location = new System.Drawing.Point(13, 13);
            this.modificar_rol.Name = "modificar_rol";
            this.modificar_rol.Size = new System.Drawing.Size(750, 682);
            this.modificar_rol.TabIndex = 0;
            this.modificar_rol.TabStop = false;
            this.modificar_rol.Text = "Modificar Rol";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(26, 555);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(713, 81);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Volver a habilitar Rol";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(203, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(277, 40);
            this.button3.TabIndex = 0;
            this.button3.Text = "VOLVER A HABILITAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Location = new System.Drawing.Point(26, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(713, 413);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado Funcionalidades";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Listadoxfunc);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(6, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(689, 187);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quitar funcionalidades";
            // 
            // Listadoxfunc
            // 
            this.Listadoxfunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Listadoxfunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBRE_ROL,
            this.FUNCIONALIDAD_ID,
            this.FUNCIONALIDAD_DESC});
            this.Listadoxfunc.Location = new System.Drawing.Point(18, 30);
            this.Listadoxfunc.Name = "Listadoxfunc";
            this.Listadoxfunc.RowTemplate.Height = 24;
            this.Listadoxfunc.Size = new System.Drawing.Size(501, 147);
            this.Listadoxfunc.TabIndex = 1;
            this.Listadoxfunc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Listadoxfunc_CellContentClick);
            // 
            // NOMBRE_ROL
            // 
            this.NOMBRE_ROL.HeaderText = "NOMBRE_ROL";
            this.NOMBRE_ROL.Name = "NOMBRE_ROL";
            // 
            // FUNCIONALIDAD_ID
            // 
            this.FUNCIONALIDAD_ID.HeaderText = "FUNCIONALIDAD_ID";
            this.FUNCIONALIDAD_ID.Name = "FUNCIONALIDAD_ID";
            // 
            // FUNCIONALIDAD_DESC
            // 
            this.FUNCIONALIDAD_DESC.HeaderText = "FUNCIONALIDAD_DESC";
            this.FUNCIONALIDAD_DESC.Name = "FUNCIONALIDAD_DESC";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(532, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 70);
            this.button4.TabIndex = 0;
            this.button4.Text = "QUITAR FUNCIONALIDADES\r\n\r\n";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.listadoAgregar);
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Location = new System.Drawing.Point(6, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(689, 187);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Agregar funcionalidades";
            // 
            // listadoAgregar
            // 
            this.listadoAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoAgregar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBRE__ROL,
            this.FUNCIONALIDAD__ID,
            this.FUNCIONALIDAD__DESC});
            this.listadoAgregar.Location = new System.Drawing.Point(18, 21);
            this.listadoAgregar.Name = "listadoAgregar";
            this.listadoAgregar.RowTemplate.Height = 24;
            this.listadoAgregar.Size = new System.Drawing.Size(501, 151);
            this.listadoAgregar.TabIndex = 2;
            // 
            // NOMBRE__ROL
            // 
            this.NOMBRE__ROL.HeaderText = "NOMBRE__ROL";
            this.NOMBRE__ROL.Name = "NOMBRE__ROL";
            // 
            // FUNCIONALIDAD__ID
            // 
            this.FUNCIONALIDAD__ID.HeaderText = "FUNCIONALIDAD__ID";
            this.FUNCIONALIDAD__ID.Name = "FUNCIONALIDAD__ID";
            // 
            // FUNCIONALIDAD__DESC
            // 
            this.FUNCIONALIDAD__DESC.HeaderText = "FUNCIONALIDAD__DESC";
            this.FUNCIONALIDAD__DESC.Name = "FUNCIONALIDAD__DESC";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(532, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 70);
            this.button5.TabIndex = 2;
            this.button5.Text = "AGREGAR FUNCIONALIDADES\r\n";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nuevoNombre);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 75);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar nombre";
            // 
            // nuevoNombre
            // 
            this.nuevoNombre.Location = new System.Drawing.Point(231, 33);
            this.nuevoNombre.Name = "nuevoNombre";
            this.nuevoNombre.Size = new System.Drawing.Size(249, 22);
            this.nuevoNombre.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(608, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 37);
            this.button2.TabIndex = 28;
            this.button2.Text = "CARGAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 36);
            this.button1.TabIndex = 27;
            this.button1.Text = "LIMPIAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ingrese el nuevo nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Seleccione qué desea hacer con este rol:";
            // 
            // Atras
            // 
            this.Atras.Location = new System.Drawing.Point(9, 642);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(76, 31);
            this.Atras.TabIndex = 22;
            this.Atras.Text = "Atrás";
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(0, 0);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 23);
            this.nombre.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 68);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nota: para seleccionar \r\n       más de una fila \r\nmantenga apretada la \r\n        " +
    "   tecla CTRL\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 68);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nota: para seleccionar \r\n       más de una fila \r\nmantenga apretada la \r\n        " +
    "   tecla CTRL\r\n";
            // 
            // ModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 702);
            this.Controls.Add(this.modificar_rol);
            this.Name = "ModificarRol";
            this.Text = "UTN FRBA";
            this.Load += new System.EventHandler(this.ModificarRol_Load);
            this.modificar_rol.ResumeLayout(false);
            this.modificar_rol.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Listadoxfunc)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoAgregar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox modificar_rol;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Listadoxfunc;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_ROL;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNCIONALIDAD_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNCIONALIDAD_DESC;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox nuevoNombre;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView listadoAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE__ROL;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNCIONALIDAD__ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNCIONALIDAD__DESC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}