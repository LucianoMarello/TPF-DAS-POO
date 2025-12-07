using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ItemVentaDTO
    {
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
    }

    public class ItemCompraDTO
    {
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal Costo { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}
