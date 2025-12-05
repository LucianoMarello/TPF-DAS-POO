using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int StockMinimoAlerta { get; set; }
        public int RubroId { get; set; }
        public virtual Rubro Rubro { get; set; }
        public virtual ICollection<Lote> Lotes { get; set; }
    }
}
