using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry_GestionInventario_Torres
{
    internal class DBConexion
    {
        OleDbCommand comando;
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        string cadena;

        public DBConexion()
        {           
            cadena = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Productos.accdb;"; 
            conexion = new OleDbConnection(cadena);
        }

        public void abrirConexion()
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Conexion abierta!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir la conexión: {ex.Message}");
            }

        }

    }
}
