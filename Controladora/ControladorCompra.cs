using Entidades;
using Modelo;
using Modelo.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladorCompra
    {
        // Singleton
        private static ControladorCompra? _instancia;
        public static ControladorCompra Instancia
        {
            get { if (_instancia == null) _instancia = new ControladorCompra(); return _instancia; }
        }

        private Context _context;
        private RepositorioIngreso _repoIngreso;
        private RepositorioLote _repoLote;
        private RepositorioProveedor _repoProveedor;

        private ControladorCompra()
        {
            _context = new Context();
            _repoIngreso = new RepositorioIngreso(_context);
            _repoLote = new RepositorioLote(_context);
            _repoProveedor = new RepositorioProveedor(_context);
        }

        public void RegistrarCompra(int proveedorId, int sucursalId, List<ItemCompraDTO> items)
        {
            if (items == null || items.Count == 0) throw new Exception("Lista de compra vacía.");

            // Validar Proveedor
            var proveedor = _repoProveedor.ObtenerPorId(proveedorId);
            if (proveedor == null) throw new Exception("Proveedor no encontrado.");

            // 1. Crear Cabecera
            var ingreso = new Ingreso
            {
                ProveedorId = proveedorId,
                SucursalId = sucursalId,
                FechaMovimiento = DateTime.Now,
                Total = 0,
                Detalles = new List<DetalleIngreso>()
            };

            decimal totalCompra = 0;

            // 2. Procesar Items (Crear Histórico + Crear Lote Nuevo)
            foreach (var item in items)
            {
                // A. Detalle Histórico (Inmutable)
                var detalle = new DetalleIngreso
                {
                    ProductoId = item.ProductoId,
                    CantidadOriginal = item.Cantidad,
                    CostoUnitario = item.Costo
                };
                ingreso.Detalles.Add(detalle);
                totalCompra += (item.Cantidad * item.Costo);

                // B. Crear LOTE (Stock Vivo)
                var nuevoLote = new Lote
                {
                    ProductoId = item.ProductoId,
                    SucursalId = sucursalId,
                    CantidadActual = item.Cantidad,
                    FechaIngreso = DateTime.Now,
                    FechaVencimiento = item.FechaVencimiento
                };

                // Guardamos el lote. Al ser parte del mismo contexto, se guarda todo junto al final
                _repoLote.Agregar(nuevoLote);
            }

            ingreso.Total = totalCompra;

            // 3. Guardar Todo
            _repoIngreso.Agregar(ingreso);
        }

        public List<Ingreso> ObtenerHistorialCompras() => _repoIngreso.ObtenerHistorial();

        public Ingreso? ObtenerCompraPorId(int id) => _repoIngreso.ObtenerPorId(id);
    }
}
