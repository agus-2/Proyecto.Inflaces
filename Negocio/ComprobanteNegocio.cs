using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace Negocio
{
    public class ComprobanteNegocio
    {
        private string cadenaConexion =
            @"Server=.\SQLEXPRESS; Database=MundoInflacesBD; Integrated Security=True;";

        //agregar comprobante
        public string AgregarComprobante(Comprobante comprobante)
        {
            if (comprobante.id_proveedor <= 0)
            {
                return "Debe seleccionar un proveedor válido.";
            }
            if (comprobante.fecha == default(DateTime)){
                    return "Asegurese de que la fecha sea correcta";
                }
            if (string.IsNullOrWhiteSpace(comprobante.tipo_comprobante))
            {
                return "El tipo de comprobante es obligatorio.";
            }
            if (string.IsNullOrWhiteSpace(comprobante.numero_comprobante))
            {
                return "El numero del comprobante es obligatorio.";
            }
            if (comprobante.total <= 0) 
            { 
                return "El Total debe ser mayor a cero."; 
            }

            try 
            { 
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open(); 
                string query = @"INSERT INTO Comprobante 
                                (id_proveedor, tipo_comprobante, numero_comprobante, fecha, total)
                                VALUES (@id_proveedor, @tipo_comprobante, @numero_comprobante, @fecha, @total)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            { 
                        cmd.Parameters.AddWithValue("@id_proveedor", comprobante.id_proveedor);
                        cmd.Parameters.AddWithValue("@tipo_comprobante", comprobante.tipo_comprobante.Trim());
                        cmd.Parameters.AddWithValue("@numero_comprobante", comprobante.numero_comprobante.Trim());
                        cmd.Parameters.AddWithValue("@fecha", comprobante.fecha); // Pasa directamente el DateTime
                        cmd.Parameters.AddWithValue("@total", comprobante.total);
                        cmd.ExecuteNonQuery(); 
            } 
            } return "Éxito: Comprobante registrado correctamente."; } 
            catch (Exception ex) 
            { 
                return "Error al registrar el comprobante: " + ex.Message; 
            } 
        }
        //listar comprobante
        public List<Comprobante> ListarComprobantes()
        {
            List<Comprobante> lista = new List<Comprobante>();

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();

                string query = @"SELECT id_proveedor,
                                        id_comprobante,
                                        fecha,
                                        tipo_comprobante,
                                        numero_comprobante,
                                        total
                                 FROM Comprobante";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Comprobante comprobante = new Comprobante
                            {
                                id_proveedor = Convert.ToInt32(reader["id_proveedor"]),
                                id_comprobante = Convert.ToInt32(reader["id_comprobante"]),
                                tipo_comprobante = reader["tipo_comprobante"].ToString(),
                                numero_comprobante = reader["numero_comprobante"].ToString(),
                                fecha = Convert.ToDateTime(reader["fecha"]),
                                total = Convert.ToDecimal(reader["total"]) 
                            };

                            lista.Add(comprobante);
                        }
                    }
                }
            }

            return lista;
        }
        //modificar comprobante
        public string ModificarComprobante(Comprobante comprobante)
        {
            if (comprobante.id_comprobante <= 0)
            {
                return "Error: Debe especificar un comprobante válido para modificar."; 
            } 
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();

                string query = @"UPDATE Comprobante
                                 SET id_proveedor = @id_proveedor,
                                     tipo_comprobante = @tipo_comprobante,
                                     numero_comprobante = @numero_comprobante,
                                     fecha = @fecha,
                                     total = @total
                                 WHERE id_comprobante = @id_comprobante";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id_comprobante", comprobante.id_comprobante);
                    cmd.Parameters.AddWithValue("@id_proveedor", comprobante.id_proveedor);
                    cmd.Parameters.AddWithValue("@tipo_comprobante", comprobante.tipo_comprobante);
                    cmd.Parameters.AddWithValue("@numero_comprobante", comprobante.numero_comprobante);
                    cmd.Parameters.AddWithValue("@fecha", comprobante.fecha);
                    cmd.Parameters.AddWithValue("@total", comprobante.total);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0) {
                        return "Comprobante modificado correctamente";
                    } else
                    {
                        return "No se encontro el comprobante para modificar";
                    }
                }
            }

        }
        //registrar det comprobante
        public string RegistrarDetComprobante(DetalleComprobante detComprobante) {
            if (detComprobante.id_materia_prima <= 0)
            {
                return "Debe seleccionar una materia prima.";
            }
            if (detComprobante.cantidad <=0)
            {
                return "Debe ingresar la cantidad de materia prima.";
            }

            if (detComprobante.precio_unitario <= 0)
            {
                return "El precio unitario debe ser mayor a cero.";
            }

            if (detComprobante.subtotal <= 0)
            {
                return "El subtotal debe ser mayor a cero.";
            }

            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();
                    string query = @"INSERT INTO Detalle_Comprobante 
                                (id_materia_prima, cantidad, precio_unitario, subtotal)
                                VALUES (@id_materia_prima, @cantidad, @precio_unitario, @subtotal)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id_materia_prima", detComprobante.id_materia_prima);
                        cmd.Parameters.AddWithValue("@cantidad", detComprobante.cantidad);
                        cmd.Parameters.AddWithValue("@precio_unitario", detComprobante.precio_unitario);
                        cmd.Parameters.AddWithValue("@subtotal", detComprobante.subtotal);
                        cmd.ExecuteNonQuery();
                    }
                }
                return "Éxito: Detlle de comprobante registrado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al registrar el detalle comprobante: " + ex.Message;
            }
        }
        //modificar det comprobante
        public string ModificarDetComprobante(DetalleComprobante detComprobante)
        {
            if (detComprobante.id_comprobante <= 0)
            {
                return "Error: Debe seleccionar un comprobante válido para modificar.";
            }
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();

                string query = @"UPDATE Detalle_Comprobante
                                 SET id_materia_prima = @id_materia_prima,
                                     cantidad = @cantidad,
                                     precio_unitario = @precio_unitario,
                                     subtotal = @subtotal
                                 WHERE id_comprobante = @id_comprobante";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id_materia_prima", detComprobante.id_materia_prima);
                    cmd.Parameters.AddWithValue("@cantidad", detComprobante.cantidad);
                    cmd.Parameters.AddWithValue("@precio_unitario", detComprobante.precio_unitario);
                    cmd.Parameters.AddWithValue("@subtotal", detComprobante.subtotal);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        return "Detalle de comprobante modificado correctamente";
                    }
                    else
                    {
                        return "No se encontro un comprobante existente para modificar";
                    }
                }
            }
        }
        //listar det comprobante
        public List<DetalleComprobante> ListarDetComprobante()
        {
            List<DetalleComprobante> lista = new List<DetalleComprobante>();

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();

                string query = @"SELECT id_comprobante,
                                        id_materia_prima,
                                        cantidad,
                                        precio_unitario,
                                        subtotal
                                 FROM Detalle_Comprobante";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DetalleComprobante detComprobante = new DetalleComprobante
                            {
                                id_materia_prima = Convert.ToInt32(reader["id_proveedor"]),
                                id_comprobante = Convert.ToInt32(reader["id_comprobante"]),
                                cantidad = Convert.ToInt32(reader["cantidad"]),
                                precio_unitario = Convert.ToDecimal(reader["precio_unitario"]),
                                subtotal = Convert.ToDecimal(reader["total"])
                            };

                            lista.Add(detComprobante);
                        }
                    }
                }
            }

            return lista;
        }

    }
}
