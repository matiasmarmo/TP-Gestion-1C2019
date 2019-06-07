namespace FrbaCrucero
{
    partial class Funcionalidades
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gD1C2019DataSet1 = new FrbaCrucero.GD1C2019DataSet1();
            this.funcionalidadXRolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionalidad_x_RolTableAdapter = new FrbaCrucero.GD1C2019DataSet1TableAdapters.Funcionalidad_x_RolTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadXRolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecciones la funcionalidad que desea:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Continuar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.funcionalidadXRolBindingSource;
            this.comboBox1.DisplayMember = "FUNCIONALIDAD";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "FUNCIONALIDAD";
            // 
            // gD1C2019DataSet1
            // 
            this.gD1C2019DataSet1.DataSetName = "GD1C2019DataSet1";
            this.gD1C2019DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionalidadXRolBindingSource
            // 
            this.funcionalidadXRolBindingSource.DataMember = "Funcionalidad x Rol";
            this.funcionalidadXRolBindingSource.DataSource = this.gD1C2019DataSet1;
            // 
            // funcionalidad_x_RolTableAdapter
            // 
            this.funcionalidad_x_RolTableAdapter.ClearBeforeFill = true;
            // 
            // Funcionalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 304);
            this.Controls.Add(this.groupBox1);
            this.Name = "Funcionalidades";
            this.Text = "Funcionalidades";
            this.Load += new System.EventHandler(this.Funcionalidades_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadXRolBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private GD1C2019DataSet1 gD1C2019DataSet1;
        private System.Windows.Forms.BindingSource funcionalidadXRolBindingSource;
        private GD1C2019DataSet1TableAdapters.Funcionalidad_x_RolTableAdapter funcionalidad_x_RolTableAdapter;
    }
}