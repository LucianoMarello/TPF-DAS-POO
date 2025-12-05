using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lote
    {
        [Key]
        public int LoteId { get; set; }
        public int CantidadActual { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaIngreso { get; set; } = DateTime.Now;
        public int ProductoId { get; set; }
        public virtual Producto Producto { get; set; }
        public int SucursalId { get; set; }
        public virtual Sucursal Sucursal { get; set; }

        public bool EstaVencido()
        {
            return DateTime.Now.Date > FechaVencimiento.Date;
        }

        public bool ProximoAVencer()
        {
            int dias = 7;
            return !EstaVencido() && DateTime.Now.Date.AddDays(dias) >= FechaVencimiento.Date;
        }
    }
}
