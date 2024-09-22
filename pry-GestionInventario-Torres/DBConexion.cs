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
                //MessageBox.Show("Conexion abierta!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir la conexión: {ex.Message}");
            }
        }

        public void cerrarConexion()
        {
            try
            {
                conexion.Close();
                //MessageBox.Show("Conexion cerrada!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cerrar la conexión: {ex.Message}");
            }
        }

        public List<Dictionary<string, object>> obtenerDatos()
        {
            List<Dictionary<string, object>> listaProductos = new List<Dictionary<string, object>>();

            try
            {
                conexion.Open();
                string query = "SELECT * FROM Productos ORDER BY Id ASC";
                OleDbCommand comando = new OleDbCommand(query, conexion);
                OleDbDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    Dictionary<string, object> fila = new Dictionary<string, object>();

                    for (int i = 0; i < leer.FieldCount; i++)
                    {
                        string nombreColumna = leer.GetName(i);
                        object valor = leer[i];
                        fila[nombreColumna] = valor;
                    }
                    listaProductos.Add(fila);
                }
                leer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return listaProductos;
        }

        public void agregarProducto(string id, string nombre, string descripcion, string precio, string stock, string categorias)
        {
            try
            {
                abrirConexion();
                string query = "INSERT INTO Productos (Id, Nombre, Descripcion, Precio, Stock, Categorias) VALUES (?, ?, ?, ?, ?, ?)";
                using (OleDbCommand comando = new OleDbCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("?", id);
                    comando.Parameters.AddWithValue("?", nombre);
                    comando.Parameters.AddWithValue("?", descripcion);
                    comando.Parameters.AddWithValue("?", precio);
                    comando.Parameters.AddWithValue("?", stock);
                    comando.Parameters.AddWithValue("?", categorias);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el producto: {ex.Message}");

            }
            finally
            {
                cerrarConexion();
            }

        }

        public void modificarProducto(string id, string nombre = null, string descripcion = null, string precio = null, string stock = null, string categorias = null)
        {
            try
            {
                abrirConexion();

                //Lista para almacenar las partes del UPDATE
                List<string> update = new List<string>();

                //Lista para almacenar los parametros 
                List<string> parametros = new List<string>();

                if (!string.IsNullOrEmpty(nombre))
                {
                    update.Add("Nombre = ?");
                    parametros.Add(nombre);
                }
                if (!string.IsNullOrEmpty(descripcion))
                {
                    update.Add("Descripcion = ?");
                    parametros.Add(descripcion);
                }
                if (!string.IsNullOrEmpty(precio))
                {
                    update.Add("Precio = ?");
                    parametros.Add(precio);
                }
                if (!string.IsNullOrEmpty(stock))
                {
                    update.Add("Stock = ?");
                    parametros.Add(stock);
                }
                if (!string.IsNullOrEmpty(categorias))
                {
                    update.Add("Categorias = ?");
                    parametros.Add(categorias);
                }

                if (update.Count == 0)
                {
                    MessageBox.Show("No se especificaron campos para actualizar.");
                    return;
                }

                //Construir la consulta SQL 
                string query = $"UPDATE Productos SET {string.Join(", ", update)} WHERE Id = ?";

                using (OleDbCommand comando = new OleDbCommand(query, conexion))
                {
                    foreach (var parametro in parametros)
                    {
                        comando.Parameters.AddWithValue("?", parametro);
                    }

                    //Agregar el parametro del ID al final
                    comando.Parameters.AddWithValue("?", id);

                    int filas = comando.ExecuteNonQuery();

                    if (filas > 0)
                    {
                        MessageBox.Show($"El producto con código {id} ha sido modificado con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un producto con el ID proporcionado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el producto: {ex.Message}");
            }
            finally
            {
                cerrarConexion();
            }

        }

        public void eliminarProducto(int id)
        {
            try
            {
                abrirConexion();
                string query = "DELETE FROM Productos WHERE Id = ?";

                using (OleDbCommand comando = new OleDbCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("?", id);

                    int filas = comando.ExecuteNonQuery();

                    if (filas > 0)
                    {
                        MessageBox.Show($"El producto código {id} ha sido eliminado con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un producto con el ID proporcionado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el producto: {ex.Message}");
            }
            finally
            {
                cerrarConexion();
            }
        }

    }
}
