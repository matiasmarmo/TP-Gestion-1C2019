﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero
{
    public partial class Funcionalidades : Form
    {
        public Funcionalidades()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Visible = true;
            this.Dispose(false);
        }

        private void Funcionalidades_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2019DataSet1.Funcionalidad_x_Rol' table. You can move, or remove it, as needed.
            this.funcionalidad_x_RolTableAdapter.Fill(this.gD1C2019DataSet1.Funcionalidad_x_Rol);

        }
    }
}