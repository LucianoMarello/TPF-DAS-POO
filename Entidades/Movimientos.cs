using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Movimientos
    {
        [Key]
        public int MovimientoId { get; set; }
        public DateTime FechaMovimiento { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }
        public int SucursalId { get; set; }
        public virtual Sucursal Sucursal { get; set; }
    }

    public class Ingreso : Movimientos
    {

        public int ProveedorId { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        public virtual ICollection<DetalleIngreso> Detalles { get; set; }
    }

    public class Venta : Movimientos
    {
        public MetodoPago MetodoPago { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<DetalleVenta> Detalles { get; set; }
    }

    public enum MetodoPago
    {
        Efectivo,
        Tarjeta,
        Transferencia
    }
}
