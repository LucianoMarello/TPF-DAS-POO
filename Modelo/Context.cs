using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class Context : DbContext
    {
        private string connection = "Data Source=ASUS-MARELLO\\SQLEXPRESS;Initial Catalog=TPF-DAS;Integrated Security=True;Encrypt=False";

        //Definicion de Tablas
        public DbSet<Rubro> Rubros { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Lote> Lotes { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Ingreso> Ingresos { get; set; }
        public DbSet<DetalleVenta> DetallesVenta { get; set; }
        public DbSet<DetalleIngreso> DetallesIngreso { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
         => options.UseSqlServer(connection);
    }
}
