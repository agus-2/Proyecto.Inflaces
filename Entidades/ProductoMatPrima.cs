using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoMatPrima
    {
        public int id_producto { get; set; }
        public int id_materia_prima { get; set; }
        public decimal cantidad_necesaria { get; set; }
    }
}
