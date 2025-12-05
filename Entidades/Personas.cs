namespace Entidades
{
    public abstract class Persona
    {
        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
    }

    public class Proveedor : Persona
    {
        public virtual ICollection<Ingreso> IngresosRealizados { get; set; }
    }

    public class Cliente : Persona
    {
        public TipoCliente Tipo { get; set; }
        public virtual ICollection<Venta> HistorialVentas { get; set; }

        public decimal CalcularDescuento(decimal monto)
        {
            if(Tipo == TipoCliente.Mayorista)
            {
                return monto * 0.85m; // 15% de descuento para mayoristas
            }
            else
            {
                return monto * 0.95m; // 5% de descuento para minoristas
            }
        }
    }

    public enum TipoCliente
    {
        Minorista,
        Mayorista
    }
}
