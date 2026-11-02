using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes
    {
        public int id_cliente { get; set; }
        public string nombre_completo {get; set; }
        public string cuit { get; set; }
        public bool tipo_cliente { get; set; } //true= Mayorista - false=Minorista
        public string email { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
    }
}
