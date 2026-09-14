using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Inflaces.Gestion
{
    public class Conexion
    {
        private string cadenaConexion = "DESKTOP-6AAK0II\\SQLEXPRESS; Database=MundoInflacesBD; Integrated Security=True;";
        public SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            try
            {
                //si esta cerrada la abrimos
                if (conexion.State == ConnectionState.Closed) {
                    conexion.Open();
                }
                return conexion;
            }
            catch(Exception ex){
                //lo que muestra si hay un error
                throw new Exception("Error: No se pudo conectar a la base de datos de Mundo Inflaces. " + ex.Message);
            }
        }
    }
}
