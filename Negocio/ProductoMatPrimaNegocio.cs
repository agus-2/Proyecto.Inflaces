using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace Negocio
{
    public class ProductoMatPrimaNegocio
    {
        private string cadenaConexion =
            @"Server=.\SQLEXPRESS; Database=MundoInflacesBD; Integrated Security=True;";
        
        public string AgregarItem(ProductoMatPrima prodMatPrima)
        {
            if (prodMatPrima.cantidad_necesaria <= 0)
            {
                return "Error: la cantidad debe ser mayor a 0";
            }
            if (prodMatPrima.id_producto <= 0)
            {
                return "Error: seleccione un producto";
            }
            if (prodMatPrima.id_materia_prima <= 0)
            {
                return "Error: seleccione una materia prima";
            }
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();

                    string query = @"INSERT INTO Producto_Materia_Prima
                                (id_producto, id_materia_prima, cantidad_necesaria)
                                VALUES
                                (@id_producto, @id_materia_prima, @cantidad_necesaria)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id_producto", prodMatPrima.id_producto);
                        cmd.Parameters.AddWithValue("@id_materia_prima", prodMatPrima.id_materia_prima);
                        cmd.Parameters.AddWithValue("@cantidad_necesaria", prodMatPrima.cantidad_necesaria);
                        cmd.ExecuteNonQuery();
                    }
                }
                return "Producto/Materia Prima creada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error de conexión o guardado en la base de datos: " + ex.Message;
            }
        }
        
        public List<ProductoMatPrima> ListarProdMatPrima()
        {
            List<ProductoMatPrima> lista = new List<ProductoMatPrima>();

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();

                string query = @"SELECT id_producto, id_materia_prima, cantidad_necesaria
                                 FROM Producto_Materia_Prima";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ProductoMatPrima prdmatprima = new ProductoMatPrima
                        {
                            id_materia_prima = Convert.ToInt32(reader["id_materia_prima"]),
                            id_producto = Convert.ToInt32(reader["id_producto"]),
                            cantidad_necesaria = Convert.ToInt32(reader["cantidad_necesaria"]),
                        };

                        lista.Add(prdmatprima);
                    }
                }
            }
            return lista;
        }

        public string EliminarItem(ProductoMatPrima prodMat)
        {
            if (prodMat.id_producto <= 0 || prodMat.id_materia_prima <= 0)
            {
                return "Debe indicar un producto y una materia prima";
            }
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();

                    string query = "DELETE FROM Producto_Materia_Prima" +
                        "WHERE id_materia_prima = @id_materia_prima AND id_producto = @id_producto";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id_materia_prima", prodMat.id_materia_prima);
                        cmd.Parameters.AddWithValue("@id_producto", prodMat.id_producto);
                        cmd.ExecuteNonQuery();

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            return "Éxito: se elimino el producto/materia prima correctamente.";
                        }
                        else
                        {
                            return "No se encontro esa combinacion de materia prima y producto";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar el producto/materia prima: " + ex.Message;
            }
        }
    }
}
