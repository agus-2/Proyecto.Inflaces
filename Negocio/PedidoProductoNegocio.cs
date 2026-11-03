using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class PedidoProductoNegocio
    {
        //cadena de conexion hacia base de datos
        private string cadenaConexion = @"Server=. \SQLEXPRESS; Database=MundoInflacesBD; Integrated Security=True;";
        public List<PedidoProducto> ListarPedidoProducto()
        {
            List<PedidoProducto> lista = new List<PedidoProducto>();

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();

                string query = @"SELECT id_pedido, id_producto, cantidad, precio_unitario, subtotal
                         FROM Pedido_Producto";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new PedidoProducto
                        {
                            id_pedido = Convert.ToInt32(reader["id_pedido"]),
                            id_producto = Convert.ToInt32(reader["id_producto"]),
                            cantidad = Convert.ToInt32(reader["cantidad"]),
                            precio_unitario = reader["precio_unitario"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["precio_unitario"]),
                            subtotal = reader["subtotal"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["subtotal"])
                        }
                        );
                    }
                }
            }
            return lista;
        }

        public string RegistrarProductoEnPedido(PedidoProducto pedpod)
        {
            if (pedpod.id_pedido <= 0)
            {
                return "Debe seleccionar un pedido válido.";
            }
            if (pedpod.id_producto <= 0)
            {
                return "Debe seleccionar un producto válido.";
            }

            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();

                    string query = @"INSERT INTO Pedido_Producto
                                            (id_pedido, id_producto, cantidad, precio_unitario, subtotal)
                                            VALUES(@id_pedido, @id_producto, @cantidad, @precio_unitario, @subtotal)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id_pedido", pedpod.id_pedido);
                        cmd.Parameters.AddWithValue("@id_producto", pedpod.id_producto);
                        cmd.Parameters.AddWithValue("@cantidad", pedpod.cantidad);
                        cmd.Parameters.AddWithValue("@precio_unitario", pedpod.precio_unitario);
                        cmd.Parameters.AddWithValue("@subtotal", pedpod.subtotal);

                        cmd.ExecuteNonQuery();
                    }
                }

                return "Éxito: El producto ha sido registrado correctamente en el pedido.";
            }
            catch (Exception ex)
            {
                return "Error de conexión o guardado en la base de datos: " + ex.Message;
            }
        }

        public string EliminarProductoDePedido(PedidoProducto pedpod)
        {
            if (pedpod.id_pedido <= 0 || pedpod.id_producto <= 0)
            {
                return "Debe indicar un pedido y un producto válido";
            }
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();

                    string query = "DELETE FROM Pedido_Producto" +
                        "WHERE id_pedido = @id_pedido AND id_producto = @id_producto";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id_pedido", pedpod.id_pedido);
                        cmd.Parameters.AddWithValue("@id_producto", pedpod.id_producto);
                        cmd.ExecuteNonQuery();

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            return "Éxito: el producto ha sido eliminado del pedido correctamente.";
                        }
                        else
                        {
                            return "No se encontro esa combinacion de pedido y producto";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar el pedido del producto: " + ex.Message;
            }
        }
    }
}
