using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace pry_GestionInventario_Torres
{
    public partial class ReporteInventario : Form
    {
        public ReporteInventario()
        {
            InitializeComponent();
        }

        private void ReporteInventario_Load(object sender, EventArgs e)
        {
            cargarDatosEnGrafico();
        }

        private void cargarDatosEnGrafico()
        {
            DBConexion db = new DBConexion();
            List<Dictionary<string, object>> listaProductos = db.obtenerDatos();

            Dictionary<string, double> sumarStockPorCategoria = new Dictionary<string, double>();

            foreach (var producto in listaProductos)
            {
                string categoria = producto["Categorias"].ToString();
                double stock = Convert.ToDouble(producto["Stock"]);

                if (sumarStockPorCategoria.ContainsKey(categoria))
                {
                    sumarStockPorCategoria[categoria] += stock;
                }
                else
                {
                    sumarStockPorCategoria[categoria] = stock;
                }                
            }

            chartCategoria.Series.Clear();
            chartCategoria.Series.Add("Categorias");

            foreach (var categoria in sumarStockPorCategoria)
            {               
                double cantidad = categoria.Value;
                chartCategoria.Series[0].Points.AddXY(categoria.Key, categoria.Value);
                chartCategoria.Series[0].Points.Last().ToolTip = $"Cantidad: {cantidad}";
            }

        }

    }
}
