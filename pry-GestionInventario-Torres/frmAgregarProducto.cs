﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry_GestionInventario_Torres
{
    public partial class frmAgregarProducto : Form
    {
        public frmAgregarProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConexion db = new DBConexion();
            db.abrirConexion();
        }
    }
}
