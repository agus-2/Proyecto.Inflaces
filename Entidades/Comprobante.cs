using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comprobante
    {
        public int id_proveedor { get; set; }
        public int id_comprobante { get; set; }
        public DateTime fecha { get; set; }
        public string tipo_comprobante { get; set; }
        public string numero_comprobante { get; set; }
        public decimal total { get; set; }
    }
}
