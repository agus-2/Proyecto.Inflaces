using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Negocio
{
    public class ProductoNegocio
    {
        private string cadenaConexion = @"Server=.\SQLEXPRESS; Database=MundoInflacesBD; Integrated Security=True;";

        public string RegistrarProducto(Productos nuevoProducto)
        {
            if (string.IsNullOrWhiteSpace(nuevoProducto.nombre))
            {
                return "Error: El nombre del producto es obligatorio.";
            }

            if (nuevoProducto.talle <= 0)
            {
                return "Error: El talle debe ser mayor a 0.";
            }

            if (nuevoProducto.precio <= 0)
            {
                return "Error: El precio debe ser mayor a 0.";
            }

            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();

                    string query = @"INSERT INTO Productos
                                            (nombre, descripcion, talle, precio, stock)
                                            VALUES(@nombre, @descripcion, @talle, @precio, @stock)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nuevoProducto.nombre);
                        cmd.Parameters.AddWithValue("@descripcion", (object)nuevoProducto.descripcion ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@talle", nuevoProducto.talle);
                        cmd.Parameters.AddWithValue("@precio", nuevoProducto.precio);
                        cmd.Parameters.AddWithValue("@stock", nuevoProducto.stock);

                        cmd.ExecuteNonQuery();
                    }
                }

                return "Éxito: El producto ha sido registrado correctamente en la base de datos.";
            }
            catch (Exception ex)
            {
                return "Error de conexión o guardado en la base de datos: " + ex.Message;
            }
        }

        public List<Productos> ListarProductos()
        {
            List<Productos> lista = new List<Productos>();

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();

                string query = @"SELECT id_producto, nombre, descripcion,
                                        talle, precio, stock
                                 FROM Productos";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Productos producto = new Productos
                        {
                            id_producto = Convert.ToInt32(reader["id_producto"]),
                            nombre = reader["nombre"].ToString(),
                            descripcion = reader["descripcion"] == DBNull.Value
                                ? null
                                : reader["descripcion"].ToString(),
                            talle = Convert.ToInt32(reader["talle"]),
                            precio = Convert.ToDecimal(reader["precio"]),
                            stock = Convert.ToInt32(reader["stock"])
                        };

                        lista.Add(producto);
                    }
                }
            }

            return lista;
        }

        public string EliminarProducto(int idProducto)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();

                    string query = "DELETE FROM Productos WHERE id_producto = @id_producto";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id_producto", idProducto);
                        cmd.ExecuteNonQuery();
                    }
                }

                return "Éxito: El producto ha sido eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el producto: " + ex.Message;
            }
        }

        public string ModificarProducto(Productos producto)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();

                    string query = @"UPDATE Productos
                             SET nombre = @nombre,
                                 descripcion = @descripcion,
                                 talle = @talle,
                                 precio = @precio,
                                 stock = @stock
                             WHERE id_producto = @id_producto";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id_producto", producto.id_producto);
                        cmd.Parameters.AddWithValue("@nombre", producto.nombre);
                        cmd.Parameters.AddWithValue("@descripcion", (object)producto.descripcion ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@talle", producto.talle);
                        cmd.Parameters.AddWithValue("@precio", producto.precio);
                        cmd.Parameters.AddWithValue("@stock", producto.stock);

                        cmd.ExecuteNonQuery();
                    }
                }

                return "Éxito: El producto ha sido modificado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al modificar el producto: " + ex.Message;
            }
        }
    }
}