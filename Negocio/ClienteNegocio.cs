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
        private string cadenaConexion = "DESKTOP-6AAK0II\\SQLEXPRESS; Database=MundoInflacesBD; Integrated Security=True;";
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

                    using(SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre_completo", nombre_completo);
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
    }
};