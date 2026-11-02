using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fabricacion
    {
        public int id_fabricacion { get; set; }
        public int id_producto { get; set; }
        public int id_empleado { get; set; }
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }
        public int cantidad { get; set; }
        public string estado { get; set; }
    }
}
