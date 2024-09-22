using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string agregarId = txtAgregarCodigo.Text;
            string agregarNombre = txtAgregarNombre.Text;
            string agregarDescripcion = richDescripcion.Text;
            string agregarPrecio = txtAgregarPrecio.Text;
            string agregarStock = nudAgregarStock.Value.ToString();
            string agregarCategoria = txtAgregarCategoria.Text;

            if (string.IsNullOrWhiteSpace(agregarId) || string.IsNullOrWhiteSpace(agregarNombre) || string.IsNullOrWhiteSpace(agregarDescripcion) || string.IsNullOrWhiteSpace(agregarPrecio) || agregarStock == "0")
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DBConexion db = new DBConexion();
            db.agregarProducto(agregarId, agregarNombre, agregarDescripcion, agregarPrecio, agregarStock, agregarCategoria);

            MessageBox.Show("Producto agregado con éxito a la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            limpiarCombo();
        }

        private void limpiarCombo()
        {
            txtAgregarCategoria.Clear();
            txtAgregarCodigo.Clear();
            txtAgregarNombre.Clear();
            richDescripcion.Clear();
            txtAgregarPrecio.Clear();
            nudAgregarStock.Value = 0;
            txtAgregarCategoria.Clear();
        }
    }
}
