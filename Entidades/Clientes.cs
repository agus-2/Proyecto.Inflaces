using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes
    {
        public int id_cliente { get; set;}
        public string nombre_completo {get; set;}
        public int cuit { get; set;}
        public bool tipo_cliente { get; set;}
        public string email { get; set;}
        public int telefono { get; set;}
        public string direccion { get; set;}
    }
}
