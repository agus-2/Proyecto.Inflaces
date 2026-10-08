using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Negocio
{
    public class EmpleadoNegocio
    {
        private string cadenaConexion =
            @"Server=.\SQLEXPRESS; Database=MundoInflacesBD; Integrated Security=True;";

        // LOGIN
        public Empleados IniciarSesion(string usuario, string contraseña)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();

                string query = @"SELECT id_empleado,
                                        nombre,
                                        apellido,
                                        dni,
                                        telefono,
                                        puesto,
                                        usuario,
                                        contraseña
                                 FROM Empleados
                                 WHERE usuario = @usuario
                                 AND contraseña = @contraseña
                                 AND (puesto = 'Gerente' OR puesto = 'Supervisor')";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Empleados
                            {
                                id_empleado = Convert.ToInt32(reader["id_empleado"]),
                                nombre = reader["nombre"].ToString(),
                                apellido = reader["apellido"].ToString(),
                                dni = Convert.ToInt32(reader["dni"]),
                                telefono = reader["telefono"] == DBNull.Value
                                    ? null
                                    : reader["telefono"].ToString(),
                                puesto = reader["puesto"].ToString(),
                                usuario = reader["usuario"].ToString(),
                                contraseña = reader["contraseña"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

        // AGREGAR EMPLEADO
        public string RegistrarEmpleado(Empleados empleado)
        {
            if (string.IsNullOrWhiteSpace(empleado.nombre))
                return "El nombre es obligatorio.";

            if (string.IsNullOrWhiteSpace(empleado.apellido))
                return "El apellido es obligatorio.";

            if (empleado.dni <= 0)
                return "El DNI debe ser válido.";

            if (string.IsNullOrWhiteSpace(empleado.puesto))
                return "El puesto es obligatorio.";

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();

                string query = @"INSERT INTO Empleados
                                (nombre, apellido, dni, telefono, puesto, usuario, contraseña)
                                VALUES
                                (@nombre, @apellido, @dni, @telefono, @puesto, @usuario, @contraseña)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", empleado.nombre);
                    cmd.Parameters.AddWithValue("@apellido", empleado.apellido);
                    cmd.Parameters.AddWithValue("@dni", empleado.dni);
                    cmd.Parameters.AddWithValue("@telefono",
                        string.IsNullOrWhiteSpace(empleado.telefono)
                            ? (object)DBNull.Value
                            : empleado.telefono);
                    cmd.Parameters.AddWithValue("@puesto", empleado.puesto);
                    cmd.Parameters.AddWithValue("@usuario",
                        string.IsNullOrWhiteSpace(empleado.usuario)
                            ? (object)DBNull.Value
                            : empleado.usuario);
                    cmd.Parameters.AddWithValue("@contraseña",
                        string.IsNullOrWhiteSpace(empleado.contraseña)
                            ? (object)DBNull.Value
                            : empleado.contraseña);

                    cmd.ExecuteNonQuery();
                }
            }

            return "Empleado registrado correctamente.";
        }

        // LISTAR EMPLEADOS
        public List<Empleados> ListarEmpleados()
        {
            List<Empleados> lista = new List<Empleados>();

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();

                string query = @"SELECT id_empleado,
                                        nombre,
                                        apellido,
                                        dni,
                                        telefono,
                                        puesto,
                                        usuario,
                                        contraseña
                                 FROM Empleados";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Empleados empleado = new Empleados
                            {
                                id_empleado = Convert.ToInt32(reader["id_empleado"]),
                                nombre = reader["nombre"].ToString(),
                                apellido = reader["apellido"].ToString(),
                                dni = Convert.ToInt32(reader["dni"]),
                                telefono = reader["telefono"] == DBNull.Value
                                    ? null
                                    : reader["telefono"].ToString(),
                                puesto = reader["puesto"].ToString(),
                                usuario = reader["usuario"] == DBNull.Value
                                    ? null
                                    : reader["usuario"].ToString(),
                                contraseña = reader["contraseña"] == DBNull.Value
                                    ? null
                                    : reader["contraseña"].ToString()
                            };

                            lista.Add(empleado);
                        }
                    }
                }
            }

            return lista;
        }

        // MODIFICAR EMPLEADO
        public string ModificarEmpleado(Empleados empleado)
        {
            if (string.IsNullOrWhiteSpace(empleado.nombre))
                return "El nombre es obligatorio.";

            if (string.IsNullOrWhiteSpace(empleado.apellido))
                return "El apellido es obligatorio.";

            if (empleado.dni <= 0)
                return "El DNI debe ser válido.";

            if (string.IsNullOrWhiteSpace(empleado.puesto))
                return "El puesto es obligatorio.";

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();

                string query = @"UPDATE Empleados
                                 SET nombre = @nombre,
                                     apellido = @apellido,
                                     dni = @dni,
                                     telefono = @telefono,
                                     puesto = @puesto,
                                     usuario = @usuario,
                                     contraseña = @contraseña
                                 WHERE id_empleado = @id_empleado";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id_empleado", empleado.id_empleado);
                    cmd.Parameters.AddWithValue("@nombre", empleado.nombre);
                    cmd.Parameters.AddWithValue("@apellido", empleado.apellido);
                    cmd.Parameters.AddWithValue("@dni", empleado.dni);
                    cmd.Parameters.AddWithValue("@telefono",
                        string.IsNullOrWhiteSpace(empleado.telefono)
                            ? (object)DBNull.Value
                            : empleado.telefono);
                    cmd.Parameters.AddWithValue("@puesto", empleado.puesto);
                    cmd.Parameters.AddWithValue("@usuario",
                        string.IsNullOrWhiteSpace(empleado.usuario)
                            ? (object)DBNull.Value
                            : empleado.usuario);
                    cmd.Parameters.AddWithValue("@contraseña",
                        string.IsNullOrWhiteSpace(empleado.contraseña)
                            ? (object)DBNull.Value
                            : empleado.contraseña);

                    cmd.ExecuteNonQuery();
                }
            }

            return "Empleado modificado correctamente.";
        }

        // ELIMINAR EMPLEADO
        public string EliminarEmpleado(int idEmpleado)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();

                string query = @"DELETE FROM Empleados
                                 WHERE id_empleado = @id_empleado";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id_empleado", idEmpleado);

                    cmd.ExecuteNonQuery();
                }
            }

            return "Empleado eliminado correctamente.";
        }
    }
}