using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }
        [MaxLength(500)]
        public string Descripcion { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }
        public int StockMinimoAlerta { get; set; }
        public int RubroId { get; set; }
        public virtual Rubro Rubro { get; set; }
        public virtual ICollection<Lote> Lotes { get; set; }
    }
}
