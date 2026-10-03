using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // necesario para interactuar con sql
using Entidades; // usamos el molde de la Capa de Entidades
using System.Web;

namespace Negocio
{
    // contiene las reglas de negocio y la conexion a sql
    public class ProveedorNegocio
    {
        // cadena de conexion hacia base de datos
        private string cadenaConexion = @"Server=.\SQLEXPRESS; Database=MundoInflacesBD; Integrated Security=True;";

        public string RegistrarProveedor(Proveedores nuevoProveedor)
        {
            // validar reglas del negocio
            if (string.IsNullOrWhiteSpace(nuevoProveedor.nombre_empresa))
            {
                return "Error: El nombre de la empresa es obligatorio.";
            }

            if (string.IsNullOrWhiteSpace(nuevoProveedor.cuit))
            {
                return "Error: El número de CUIT es obligatorio.";
            }

            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();

                    string query = @"INSERT INTO Proveedores
                                            (nombre_empresa, cuit, telefono, email, direccion)
                                            VALUES(@nombre_empresa, @cuit, @telefono, @email, @direccion)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre_empresa", nuevoProveedor.nombre_empresa);
                        cmd.Parameters.AddWithValue("@cuit", nuevoProveedor.cuit);
                        cmd.Parameters.AddWithValue("@telefono", (object)nuevoProveedor.telefono ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@email", (object)nuevoProveedor.email ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@direccion", (object)nuevoProveedor.direccion ?? DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }

                return "Éxito: El proveedor ha sido registrado correctamente en la base de datos.";
            }
            catch (Exception ex)
            {
                return "Error de conexión o guardado en la base de datos: " + ex.Message;
            }
        }

        public List<Proveedores> ListarProveedores()
        {
            List<Proveedores> lista = new List<Proveedores>();

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();

                string query = @"SELECT id_proveedor, nombre_empresa, cuit,
                                        telefono, email, direccion
                                 FROM Proveedores";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Proveedores proveedor = new Proveedores
                        {
                            id_proveedor = Convert.ToInt32(reader["id_proveedor"]),
                            nombre_empresa = reader["nombre_empresa"].ToString(),
                            cuit = reader["cuit"].ToString(),
                            telefono = reader["telefono"] == DBNull.Value
                                ? 0
                                : Convert.ToInt32(reader["telefono"]),
                            email = reader["email"] == DBNull.Value
                                ? null
                                : reader["email"].ToString(),
                            direccion = reader["direccion"] == DBNull.Value
                                ? null
                                : reader["direccion"].ToString()
                        };

                        lista.Add(proveedor);
                    }
                }
            }

            return lista;
        }

        public string EliminarProveedor(int idProveedor)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();

                    string query = "DELETE FROM Proveedores WHERE id_proveedor = @id_proveedor";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id_proveedor", idProveedor);
                        cmd.ExecuteNonQuery();
                    }
                }

                return "Éxito: El proveedor ha sido eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el proveedor: " + ex.Message;
            }
        }

        public string ModificarProveedor(Proveedores proveedor)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();

                    string query = @"UPDATE Proveedores
                             SET nombre_empresa = @nombre_empresa,
                                 cuit = @cuit,
                                 telefono = @telefono,
                                 email = @email,
                                 direccion = @direccion
                             WHERE id_proveedor = @id_proveedor";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id_proveedor", proveedor.id_proveedor);
                        cmd.Parameters.AddWithValue("@nombre_empresa", proveedor.nombre_empresa);
                        cmd.Parameters.AddWithValue("@cuit", proveedor.cuit);
                        cmd.Parameters.AddWithValue("@telefono", (object)proveedor.telefono ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@email", (object)proveedor.email ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@direccion", (object)proveedor.direccion ?? DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }

                return "Éxito: El proveedor ha sido modificado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al modificar el proveedor: " + ex.Message;
            }
        }
    }
}