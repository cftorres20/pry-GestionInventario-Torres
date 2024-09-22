using System;
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
    public partial class frmEliminarProducto : Form
    {
        public frmEliminarProducto()
        {
            InitializeComponent();
        }

        List<string> encabezado = new List<string>() { "Id", "Nombre", "Descripcion", "Precio", "Stock", "Categorias" };

        private void frmEliminarProducto_Load(object sender, EventArgs e)
        {
            soloLectura();

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
                buscaPorCategoria(buscarCategoria);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            string eliminarId = txtCodigoEliminar.Text;
            eliminarProducto(eliminarId);
            limpiarCombo();

            dgvProductos.Rows.Clear();
        }


        #region metodos de Busquedas
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
       
        private void buscaPorCategoria(string categoria)
        {
            DBConexion db = new DBConexion();
            List<Dictionary<string, object>> listaProductos = db.obtenerDatos();

            var productoEncontrado = listaProductos.Where(p => p["Categorias"].ToString().Equals(categoria, StringComparison.OrdinalIgnoreCase)).ToList();

            if (productoEncontrado.Any())
            {
                dgvProductos.Rows.Clear();
                foreach (var item in productoEncontrado)
                {
                    dgvProductos.Rows.Add(item["Id"],
                        item["Nombre"],
                        item["Descripcion"],
                        item["Precio"],
                        item["Stock"],
                        item["Categorias"]);
                }
            }
            else
            {
                MessageBox.Show($"El producto categoría {categoria} no se encuentra en el inventario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        private void eliminarProducto(string eliminarId)
        {
            if (int.TryParse(eliminarId, out int eliminar))
            {
                DBConexion db = new DBConexion();

                db.eliminarProducto(eliminar);
            }
            else
            {
                MessageBox.Show($"El producto {eliminarId} no se encuentra en el inventario.");
            }

            dgvProductos.Rows.Clear();
            limpiarComboEliminar();
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
            cargarCombo();
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

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {           

            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvProductos.Rows[e.RowIndex];

                txtCodigoEliminar.Text = filaSeleccionada.Cells["colId"].Value.ToString();
                txtNombreEliminar.Text = filaSeleccionada.Cells["colNombre"].Value.ToString();
                richDescripcionEliminar.Text = filaSeleccionada.Cells["colDescripcion"].Value.ToString();
                txtPrecioEliminar.Text = filaSeleccionada.Cells["colPrecio"].Value.ToString();
                txtStockEliminar.Text = filaSeleccionada.Cells["colStock"].Value.ToString();
                txtCategoriaEliminar.Text = filaSeleccionada.Cells["colCategorias"].Value.ToString();
            }
        }

        private void cargarCombo()
        {
            cmbCategoria.Items.Clear();
            DBConexion db = new DBConexion();
            List<Dictionary<string, object>> listaProductos = db.obtenerDatos();

            HashSet<string> categoriasUnicas = new HashSet<string>();

            foreach (var producto in listaProductos)
            {
                if (producto.ContainsKey("Categorias"))
                {
                    categoriasUnicas.Add(producto["Categorias"].ToString());
                }
            }

            foreach (var categoria in categoriasUnicas)
            {
                cmbCategoria.Items.Add(categoria);
            }
        }

        private void limpiarCombo()
        {
            txtBuscarNombre.Clear();
            txtBuscarCodigo.Clear();
            cmbCategoria.SelectedIndex = -1;
        }

        private void limpiarComboEliminar()
        {
            txtCodigoEliminar.Clear();
            txtCategoriaEliminar.Clear();
            txtStockEliminar.Clear();
            txtPrecioEliminar.Clear();
            txtNombreEliminar.Clear();
        }

        private void soloLectura()
        {
            txtCodigoEliminar.ReadOnly = true;
            txtNombreEliminar.ReadOnly = true;
            richDescripcionEliminar.ReadOnly = true;
            txtPrecioEliminar.ReadOnly = true;
            txtStockEliminar.ReadOnly = true;
            txtCategoriaEliminar.ReadOnly = true;
        }
        
    }
}
