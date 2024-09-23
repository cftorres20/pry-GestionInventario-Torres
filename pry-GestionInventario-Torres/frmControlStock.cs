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
    public partial class frmControlStock : Form
    {
        public frmControlStock()
        {
            InitializeComponent();
        }

        List<string> encabezado = new List<string>() { "Id", "Nombre", "Descripcion", "Precio", "Stock", "Categorias" };

        private void frmControlStock_Load(object sender, EventArgs e)
        {
            lblDetalle.Text = "Se informan productos con un Stock menor o igual a 5 unidades.";

            foreach (var c in encabezado)
            {
                dgvProductos.Columns.Add($"col{c}", c.ToString());
            }
        }

        private void btnConsultarStock_Click(object sender, EventArgs e)
        {
            consultaStock();
        }
        private void consultaStock()
        {
            DBConexion db = new DBConexion();
            List<Dictionary<string, object>> listaProductos = db.obtenerDatos();

            dgvProductos.Rows.Clear();

            foreach (var productos in listaProductos)
            {
                int stock = int.Parse(productos["Stock"].ToString());

                if (stock <= 5)
                {
                    dgvProductos.Rows.Add(
                        productos["Id"].ToString(),
                        productos["Nombre"].ToString(),
                        productos["Descripcion"].ToString(),
                        productos["Precio"].ToString(),
                        productos["Stock"].ToString(),
                        productos["Categorias"].ToString()
                        );
                }
            }

            MessageBox.Show("Se verifican productos a reponer.", "Alerta de bajo stock ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
