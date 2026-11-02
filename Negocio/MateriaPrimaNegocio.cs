using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Negocio
{
    public class MateriaPrimaNegocio
    {
        private string cadenaConexion =
            @"Server=.\SQLEXPRESS; Database=MundoInflacesBD; Integrated Security=True;";

        public string RegistrarMateriaPrima(Materia_Prima nuevaMateriaPrima)
        {
            if (string.IsNullOrWhiteSpace(nuevaMateriaPrima.nombre))
            {
                return "Error: El nombre de la materia prima es obligatorio.";
            }

            if (nuevaMateriaPrima.stock < 5)
            {
                return "Error: El stock debe ser igual o mayor a 5.";
            }

            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();

                    string query = @"INSERT INTO Materia_Prima
                                     (nombre, descripcion, stock)
                                     VALUES
                                     (@nombre, @descripcion, @stock)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue(
                            "@nombre",
                            nuevaMateriaPrima.nombre);

                        cmd.Parameters.AddWithValue(
                            "@descripcion",
                            (object)nuevaMateriaPrima.descripcion ?? DBNull.Value);

                        cmd.Parameters.AddWithValue(
                            "@stock",
                            nuevaMateriaPrima.stock);

                        cmd.ExecuteNonQuery();
                    }
                }

                return "Éxito: La materia prima ha sido registrada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error de conexión o guardado en la base de datos: " + ex.Message;
            }
        }

        public List<Materia_Prima> ListarMateriasPrimas()
        {
            List<Materia_Prima> lista = new List<Materia_Prima>();

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();

                string query = @"SELECT id_materia_prima,
                                        nombre,
                                        descripcion,
                                        stock
                                 FROM Materia_Prima";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Materia_Prima materiaPrima = new Materia_Prima
                        {
                            id_materia_prima =
                                Convert.ToInt32(reader["id_materia_prima"]),

                            nombre =
                                reader["nombre"].ToString(),

                            descripcion =
                                reader["descripcion"] == DBNull.Value
                                    ? null
                                    : reader["descripcion"].ToString(),

                            stock =
                                Convert.ToInt32(reader["stock"])
                        };

                        lista.Add(materiaPrima);
                    }
                }
            }

            return lista;
        }

        public string ModificarMateriaPrima(Materia_Prima materiaPrima)
        {
            if (string.IsNullOrWhiteSpace(materiaPrima.nombre))
            {
                return "Error: El nombre de la materia prima es obligatorio.";
            }

            if (materiaPrima.stock < 5)
            {
                return "Error: El stock debe ser igual o mayor a 5.";
            }

            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();

                    string query = @"UPDATE Materia_Prima
                                     SET nombre = @nombre,
                                         descripcion = @descripcion,
                                         stock = @stock
                                     WHERE id_materia_prima = @id_materia_prima";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue(
                            "@id_materia_prima",
                            materiaPrima.id_materia_prima);

                        cmd.Parameters.AddWithValue(
                            "@nombre",
                            materiaPrima.nombre);

                        cmd.Parameters.AddWithValue(
                            "@descripcion",
                            (object)materiaPrima.descripcion ?? DBNull.Value);

                        cmd.Parameters.AddWithValue(
                            "@stock",
                            materiaPrima.stock);

                        cmd.ExecuteNonQuery();
                    }
                }

                return "Éxito: La materia prima ha sido modificada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al modificar la materia prima: " + ex.Message;
            }
        }

        public string EliminarMateriaPrima(int idMateriaPrima)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();

                    string query =
                        "DELETE FROM Materia_Prima WHERE id_materia_prima = @id_materia_prima";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue(
                            "@id_materia_prima",
                            idMateriaPrima);

                        cmd.ExecuteNonQuery();
                    }
                }

                return "Éxito: La materia prima ha sido eliminada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar la materia prima: " + ex.Message;
            }
        }
    }
}