using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Negocio
{
    public class PedidoNegocio
    {
        //cadena de conexion hacia base de datos
        private string cadenaConexion = @"Server=. \SQLEXPRESS; Database=MundoInflacesBD; Integrated Security=True;";

        public string RegistrarPedido(Pedidos nuevoPedido)

        {
            //validar reglas del negocio
            if (nuevoPedido.id_cliente <= 0)
            {
                return "Error: Seleccionar a un cliente es obligatorio.";
            }
                try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();
                    string query = @"INSERT INTO Pedidos (fecha_pedido, id_cliente, estado, total)
                                            VALUES(@fecha_pedido, @id_cliente, @estado, 0)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@fecha_pedido", nuevoPedido.fecha_pedido);
                        cmd.Parameters.AddWithValue("@id_cliente", nuevoPedido.id_cliente);
                        cmd.Parameters.AddWithValue("@estado", nuevoPedido.estado);
                        cmd.ExecuteNonQuery();
                    }
                }
                return "Éxito: El pedido ha sido registrado";
            }
            catch (Exception ex)
            {
                return "Error de conexión o guardado en la base de datos: " + ex.Message;
            }
        }
        public List<Pedidos> ListarPedidos()
        {
            List<Pedidos> lista = new List<Pedidos>();

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();

                string query = @"SELECT id_pedido, fecha_pedido, id_cliente, estado, total
                         FROM Pedidos";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Pedidos
                        {
                            id_pedido = Convert.ToInt32(reader["id_pedido"]),
                            fecha_pedido = Convert.ToDateTime(reader["fecha_pedido"]),
                            id_cliente = Convert.ToInt32(reader["id_cliente"]),
                            estado = reader["estado"].ToString(),
                            total = reader["total"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["total"])
                        }
                        );
                    }
                }
            }
            return lista;
        }

        public string ActualizarEstadoPedido(Pedidos pedidos, string nuevoEstado)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();

                    string query = @"UPDATE Pedidos
                             SET estado = @estado,
                             WHERE id_pedido = @id_pedido";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("estado", pedidos.estado);
                        cmd.Parameters.AddWithValue("@id_pedido", pedidos.id_pedido);
                        cmd.ExecuteNonQuery();
                    }
                }

                return "Éxito: El estado del pedido ha sido modificado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al modificar el estado del pedido: " + ex.Message;
            }
        }

        public string EliminarPedidoCompleto(int idPedido)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();
                    SqlTransaction trans = con.BeginTransaction();
                    string queryDetalle = "DELETE FROM Pedidos WHERE id_pedido = @id_pedido";
                    using (SqlCommand cmd = new SqlCommand(queryDetalle, con, trans))
                    {
                        cmd.Parameters.AddWithValue("@id_pedido", idPedido);
                        cmd.ExecuteNonQuery();
                    }

                }
                return "Éxito: El pedido ha sido eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el pedido: " + ex.Message;
            }
        }
    }
}
