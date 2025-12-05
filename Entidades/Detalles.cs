using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleIngreso
    {
        [Key]
        public int DetalleIngresoId { get; set; }
        public int CantidadOriginal { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal CostoUnitario { get; set; }
        public int IngresoId { get; set; }
        public virtual Ingreso Ingreso { get; set; }
        public int ProductoId { get; set; }
        public virtual Producto Producto { get; set; }
    }

    public class DetalleVenta
    {
        [Key]
        public int DetalleVentaId { get; set; }
        public int Cantidad { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioUnitario { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Subtotal { get; set; }
        public int VentaId { get; set; }
        public virtual Venta Venta { get; set; }
        public int ProductoId { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
