using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry_GestionInventario_Torres
{
    public partial class frmBuscarProducto : Form
    {
        public frmBuscarProducto()
        {
            InitializeComponent();
        }

        List<string> encabezado = new List<string>() { "Id", "Nombre", "Descripcion", "Precio", "Stock" };

        private void frmBuscarProducto_Load(object sender, EventArgs e)
        {
            txtBuscarCodigo.Enabled = false;
            txtBuscarNombre.Enabled = false;
            cmbCategoria.Enabled = false;

            foreach (var c in encabezado)
            {
                dgvProductos.Columns.Add($"col{c}", c.ToString());
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string buscarId = txtBuscarCodigo.Text;
            string buscarNombre = txtBuscarNombre.Text;
            string buscarCategoria = optBuscarCategoria.Checked && cmbCategoria.SelectedItem != null ? cmbCategoria.SelectedItem.ToString() : string.Empty;


            if (optBuscarCodigo.Checked && !string.IsNullOrWhiteSpace(buscarId))
            {
                buscaPorId(buscarId);
            }
            else if (optBuscarNombre.Checked && !string.IsNullOrWhiteSpace(buscarNombre))
            {
                buscaPorNombre(buscarNombre);
            }
            else if (optBuscarCategoria.Checked && cmbCategoria.SelectedItem != null)
            {

            }
        }

        private void buscaPorId(string id)
        {
            DBConexion db = new DBConexion();
            List<Dictionary<string, object>> listaProductos = db.obtenerDatos();

            var productoEncontrado = listaProductos.FirstOrDefault(p => p["Id"].ToString().Equals(id, StringComparison.OrdinalIgnoreCase));

            if (productoEncontrado != null)
            {
                dgvProductos.Rows.Clear();
                dgvProductos.Rows.Add(productoEncontrado["Id"],
                    productoEncontrado["Nombre"],
                    productoEncontrado["Descripcion"],
                    productoEncontrado["Precio"],
                    productoEncontrado["Stock"],
                    productoEncontrado["Categorias"]);
            }
            else
            {
                MessageBox.Show($"El producto código {id} no se encuentra en el inventario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buscaPorNombre(string nombre)
        {
            DBConexion db = new DBConexion();
            List<Dictionary<string, object>> listaProductos = db.obtenerDatos();

            var productoEncontrado = listaProductos.Where(p => p["Nombre"].ToString().IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0);

            if (productoEncontrado.Any())
            {
                dgvProductos.Rows.Clear();

                foreach (var producto in productoEncontrado)
                {
                    dgvProductos.Rows.Add(producto["Id"],
                    producto["Nombre"],
                    producto["Descripcion"],
                    producto["Precio"],
                    producto["Stock"],
                    producto["Categorias"]);
                }
            }
            else
            {
                MessageBox.Show($"El producto {nombre} no se encuentra en el inventario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region REGION Validar Radio button
        private void optBuscarNombre_CheckedChanged(object sender, EventArgs e)
        {
            chequear(optBuscarNombre, txtBuscarNombre);
        }

        private void optBuscarCodigo_CheckedChanged(object sender, EventArgs e)
        {
            chequear(optBuscarCodigo, txtBuscarCodigo);
        }

        private void optBuscarCategoria_CheckedChanged(object sender, EventArgs e)
        {
            cmbCategoria.Enabled = optBuscarCategoria.Checked;
        }

        private void chequear(RadioButton opt, TextBox text)
        {
            text.Enabled = opt.Checked;

            if (!opt.Checked)
            {
                if (opt == optBuscarNombre)
                {
                    txtBuscarCodigo.Enabled = false;
                    limpiarCombo();
                }
                else if (opt == optBuscarCodigo)
                {
                    txtBuscarNombre.Enabled = false;
                    limpiarCombo();
                }
                else if (opt == optBuscarCategoria)
                {
                    cmbCategoria.Enabled = false;
                    limpiarCombo();
                }
            }
        }
        #endregion

        private void limpiarCombo()
        {
            txtBuscarNombre.Clear();
            txtBuscarCodigo.Clear();
            cmbCategoria.SelectedIndex = -1;
        }
    }
}

