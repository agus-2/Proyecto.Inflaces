using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedidos
    {
        public int id_pedido { get; set; }
        public DateTime fecha_pedido { get; set; }
        public int id_cliente { get; set; }
        public string estado { get; set; }
        public decimal total { get; set; }
    }
}
