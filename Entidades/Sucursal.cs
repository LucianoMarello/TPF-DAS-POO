using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {
        [Key]
        public int SucursalId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }
        [MaxLength(250)]
        public string Direccion { get; set; }
        public virtual ICollection<Lote> Lotes { get; set; }
        public virtual ICollection<Venta> VentasRealizadas { get; set; }
    }
}
