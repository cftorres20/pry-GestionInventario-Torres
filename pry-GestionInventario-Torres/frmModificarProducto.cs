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
    public partial class frmModificarProducto : Form
    {
        public frmModificarProducto()
        {
            InitializeComponent();            
        }

        List<string> encabezado = new List<string>() { "Id", "Nombre", "Descripcion", "Precio", "Stock", "Categorias" };

        private void frmModificarProducto_Load(object sender, EventArgs e)
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
                buscaPorCategoria(buscarCategoria);
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            string modificarId = txtCodigoModificar.Text;
            string modificarNombre = CapitalizarPrimeraLetra(txtNombreModificar.Text);
            string modificarDescripcion = richDescripcionModificar.Text;
            string modificarPrecio = txtPrecioModificar.Text;
            string modificarStock = txtStockModificar.Text;
            string modificarCategoria = CapitalizarPrimeraLetra(txtCategoriaModificar.Text);

            if (string.IsNullOrEmpty(modificarId) || !int.TryParse(modificarId, out _))
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DBConexion db = new DBConexion();
            db.modificarProducto(modificarId, modificarNombre, modificarDescripcion, modificarPrecio, modificarStock, modificarCategoria);

            limpiarCombo();
            limpiarComboModificar();

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

        private void dgvProductos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cargarCombo();

            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvProductos.Rows[e.RowIndex];

                txtCodigoModificar.Text = filaSeleccionada.Cells["colId"].Value.ToString();
                txtNombreModificar.Text = filaSeleccionada.Cells["colNombre"].Value.ToString();
                richDescripcionModificar.Text = filaSeleccionada.Cells["colDescripcion"].Value.ToString();
                txtPrecioModificar.Text = filaSeleccionada.Cells["colPrecio"].Value.ToString();
                txtStockModificar.Text = filaSeleccionada.Cells["colStock"].Value.ToString();
                txtCategoriaModificar.Text = filaSeleccionada.Cells["colCategorias"].Value.ToString();
            }
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvProductos.Rows[e.RowIndex];

                txtCodigoModificar.Text = filaSeleccionada.Cells["colId"].Value.ToString();
                txtNombreModificar.Text = filaSeleccionada.Cells["colNombre"].Value.ToString();
                richDescripcionModificar.Text = filaSeleccionada.Cells["colDescripcion"].Value.ToString();
                txtPrecioModificar.Text = filaSeleccionada.Cells["colPrecio"].Value.ToString();
                txtStockModificar.Text = filaSeleccionada.Cells["colStock"].Value.ToString();
                cmbCategoria.SelectedValue = filaSeleccionada.Cells["colCategorias"].Value.ToString();
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

        public string CapitalizarPrimeraLetra(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input; // Retorna la cadena tal cual si está vacía o es nula

            // Capitaliza la primera letra y mantiene el resto en minúsculas
            return char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }

        private void limpiarComboModificar()
        {
            txtCategoriaModificar.Clear();
            txtCodigoModificar.Clear();
            txtNombreModificar.Clear();
            richDescripcionModificar.Clear();
            txtPrecioModificar.Clear();
            txtStockModificar.Clear();   
            dgvProductos.Rows.Clear();
        }

    }    
}
