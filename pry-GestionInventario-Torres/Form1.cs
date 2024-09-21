using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry_GestionInventario_Torres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personalizarDiseno()
        {
            panelSubProducto.Visible = false;
            panelSubReporte.Visible = false;    
        }

        private void esconderSubMenu()
        {
            if (panelSubProducto.Visible == true)
            {
                panelSubProducto.Visible = false;
            }
            if (panelSubReporte.Visible == true)
            {
                panelSubReporte.Visible = false;
            }
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                esconderSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubProducto);
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubReporte);
        }
    }
}
