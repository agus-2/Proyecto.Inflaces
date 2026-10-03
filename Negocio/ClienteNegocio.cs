using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // necesario para interactuar con sql
using Entidades;// usamos el molde de la Capa de Entidades
using System.Web;

namespace Negocio
{
    //contiene las reglas de negocio y la conexion a sql -- se verifica las reglas y se pasan los datos se guardan en la base de datos
    public class ClienteNegocio
    {
        //cadena de conexion hacia base de datos
        private string cadenaConexion = @"Server=. \SQLEXPRESS; Database=MundoInflacesBD; Integrated Security=True;";
        public string RegistrarCliente(Clientes nuevoCliente)

        {
            //validar reglas del negocio
            if (string.IsNullOrWhiteSpace(nuevoCliente.nombre_completo))
            {
                return "Error: El nombre completo del cliente es obligatorio.";
            }
            if (string.IsNullOrWhiteSpace(nuevoCliente.cuit))
            {
                return "Error: El número de CUIT es obligatorio.";
            }
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();
                    string query = @"INSERT INTO Clientes
                                            (nombre_completo, cuit, tipo_cliente, email, telefono, direccion)
                                            VALUES(@nombre_completo, @cuit, @tipo_cliente, @email, @telefono, @direccion)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre_completo", nuevoCliente.nombre_completo);
                        cmd.Parameters.AddWithValue("@cuit", nuevoCliente.cuit);
                        cmd.Parameters.AddWithValue("@tipo_cliente", nuevoCliente.tipo_cliente);
                        cmd.Parameters.AddWithValue("@telefono", (object)nuevoCliente.telefono ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@email", (object)nuevoCliente.email ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@direccion", (object)nuevoCliente.direccion ?? DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                }
                return "Éxito: El cliente ha sido registrado correctamente en la base de datos.";
            }
            catch (Exception ex)
            {
                return "Error de conexión o guardado en la base de datos: " + ex.Message;
            }
        }
        public List<Clientes> ListarClientes()
        {
            List<Clientes> lista = new List<Clientes>();

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();

                string query = @"SELECT id_cliente, nombre_completo, cuit,
                                tipo_cliente, email, telefono, direccion
                         FROM Clientes";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Clientes cliente = new Clientes
                        {
                            id_cliente = Convert.ToInt32(reader["id_cliente"]),
                            nombre_completo = reader["nombre_completo"].ToString(),
                            cuit = reader["cuit"].ToString(),
                            tipo_cliente = Convert.ToBoolean(reader["tipo_cliente"]),
                            email = reader["email"] == DBNull.Value ? null : reader["email"].ToString(),
                            telefono = reader["telefono"] == DBNull.Value ? null : reader["telefono"].ToString(),
                            direccion = reader["direccion"] == DBNull.Value ? null : reader["direccion"].ToString()
                        };

                        lista.Add(cliente);
                    }
                }

            }

            return lista;
        }

        public string EliminarCliente(int idCliente)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();

                    string query = "DELETE FROM Clientes WHERE id_cliente = @id_cliente";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                        cmd.ExecuteNonQuery();
                    }
                }

                return "Éxito: El cliente ha sido eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el cliente: " + ex.Message;
            }
        }
        public string ModificarCliente(Clientes cliente)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();

                    string query = @"UPDATE Clientes
                             SET nombre_completo = @nombre_completo,
                                 cuit = @cuit,
                                 tipo_cliente = @tipo_cliente,
                                 email = @email,
                                 telefono = @telefono,
                                 direccion = @direccion
                             WHERE id_cliente = @id_cliente";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id_cliente", cliente.id_cliente);
                        cmd.Parameters.AddWithValue("@nombre_completo", cliente.nombre_completo);
                        cmd.Parameters.AddWithValue("@cuit", cliente.cuit);
                        cmd.Parameters.AddWithValue("@tipo_cliente", cliente.tipo_cliente);
                        cmd.Parameters.AddWithValue("@telefono", (object)cliente.telefono ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@email", (object)cliente.email ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@direccion", (object)cliente.direccion ?? DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }

                return "Éxito: El cliente ha sido modificado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al modificar el cliente: " + ex.Message;
            }
        }
    }
}