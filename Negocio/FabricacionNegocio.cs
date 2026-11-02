using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace Negocio
{
    public class FabricacionNegocio
    {
        private string cadenaConexion =
            @"Server=.\SQLEXPRESS; Database=MundoInflacesBD; Integrated Security=True;";
        //crear ciclo
        public string CrearCiclo(Fabricacion fabricacion)
        {
            if (fabricacion.cantidad <= 0) {
                return "Error: la cantidad debe ser mayor a 0";
            }

            if (string.IsNullOrWhiteSpace(fabricacion.estado))
            {
                return "Error: incluya el estado del ciclo de fabricacion.";
            }
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();

                    string query = @"INSERT INTO Fabricacion
                                (id_producto, id_empleado, inicio, fin, cantidad, estado)
                                VALUES
                                (@id_producto, @id_empleado, @inicio, @fin, @cantidad, @estado)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id_producto", fabricacion.id_producto);
                        cmd.Parameters.AddWithValue("@id_empleado", fabricacion.id_empleado);
                        cmd.Parameters.AddWithValue("@inicio", fabricacion.inicio);
                        cmd.Parameters.AddWithValue("@fin", fabricacion.fin);
                        cmd.Parameters.AddWithValue("@cantidad", fabricacion.cantidad);
                        cmd.Parameters.AddWithValue("@estado", fabricacion.estado);
                        cmd.ExecuteNonQuery();
                    }
                }
                return "Ciclo de Fabricacion creado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error de conexión o guardado en la base de datos: " + ex.Message;
            }
        }
        //listar ciclo
        public List<Fabricacion> ListarFabricacion()
        {
            List<Fabricacion> lista = new List<Fabricacion>();

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();

                string query = @"SELECT id_fabricacion, id_producto, id_empleado, inicio, fin,
                                        cantidad, estado
                                 FROM Fabricacion";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Fabricacion fabricacion = new Fabricacion
                        {
                            id_fabricacion = Convert.ToInt32(reader["id_fabricacion"]),
                            id_producto = Convert.ToInt32(reader["id_producto"]),
                            id_empleado = Convert.ToInt32(reader["id_empleado"]),
                            inicio = Convert.ToDateTime(reader["inicio"]),
                            fin = reader["fin"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["fin"]),
                            cantidad = Convert.ToInt32(reader["cantidad"]),
                            estado = reader["estado"].ToString(),
                        };

                        lista.Add(fabricacion);
                    }
                }
            }

            return lista;
        }
        //modificar ciclo
        public string ModificarCiclo(Fabricacion fabricacion)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();

                    string query = @"UPDATE Fabricacion
                             SET id_producto = @id_producto,
                                 id_empleado = @id_empleado,
                                 inicio = @inicio,
                                 fin = @fin,
                                 cantidad = @cantidad,
                                 estado = @estado
                             WHERE id_fabricacion = @id_fabricacion";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id_producto", fabricacion.id_producto);
                        cmd.Parameters.AddWithValue("@id_empleado", fabricacion.id_empleado);
                        cmd.Parameters.AddWithValue("@inicio", fabricacion.inicio);
                        cmd.Parameters.AddWithValue("@fin",(object)fabricacion.fin ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@cantidad", fabricacion.cantidad);
                        cmd.Parameters.AddWithValue("@estado", fabricacion.estado);

                        cmd.ExecuteNonQuery();
                    }
                }

                return "Éxito: El cico de fabricacion ha sido modificado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al modificar el ciclo de fabricacion: " + ex.Message;
            }
        }

        //eliminar ciclo
        public string EliminarCiclo(int idFabricacion)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();

                    string query = "DELETE FROM Fabricacion WHERE id_fabricacion = @id_fabricacion";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id_fabricacion", idFabricacion);
                        cmd.ExecuteNonQuery();
                    }
                }
                return "Éxito: El ciclo de fabricacion ha sido eliminado.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el ciclo de fabricacion: " + ex.Message;
            }
        }
    }
}
