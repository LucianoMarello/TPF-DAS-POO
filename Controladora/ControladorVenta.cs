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
    public class ControladorVenta
    {
        //Singleton
        private static ControladorVenta? _instancia;
        public static ControladorVenta Instancia
        {
            get { if (_instancia == null) _instancia = new ControladorVenta(); return _instancia; }
        }

        private Context _context;
        private RepositorioVenta _repoVenta;
        private RepositorioProducto _repoProducto;
        private RepositorioCliente _repoCliente;
        private RepositorioLote _repoLote;
        private RepositorioSucursal _repoSucursal;

        private ControladorVenta()
        {
            _context = new Context();
            _repoVenta = new RepositorioVenta(_context);
            _repoProducto = new RepositorioProducto(_context);
            _repoCliente = new RepositorioCliente(_context);
            _repoLote = new RepositorioLote(_context);
            _repoSucursal = new RepositorioSucursal(_context);
        }

        //SUCURSAL
        public List<Sucursal> ObtenerSucursales() => _repoSucursal.ObtenerTodos();
        public Sucursal? ObtenerSucursalPorId(int id) => _repoSucursal.ObtenerPorId(id);

        public void AgregarSucursal(string nombre, string direccion)
        {
            if (string.IsNullOrWhiteSpace(nombre)) throw new Exception("El nombre de la sucursal es obligatorio.");
            if (string.IsNullOrWhiteSpace(direccion)) throw new Exception("La dirección es obligatoria.");

            var sucursal = new Sucursal
            {
                Nombre = nombre,
                Direccion = direccion
            };

            _repoSucursal.Agregar(sucursal);
        }

        public void ModificarSucursal(Sucursal sucursal)
        {
            _repoSucursal.Modificar(sucursal);
        }

        //VENTA
        public void CrearVenta(int clienteId, int sucursalId, MetodoPago metodoPago, List<ItemVentaDTO> items)
        {
            if (items == null || items.Count == 0) throw new Exception("El carrito está vacío.");

            // 1. Validar Cliente
            var cliente = _repoCliente.ObtenerPorId(clienteId);
            if (cliente == null) throw new Exception("Cliente no encontrado.");

            // 2. Preparar Cabecera
            var venta = new Venta
            {
                ClienteId = clienteId,
                SucursalId = sucursalId,
                FechaMovimiento = DateTime.Now,
                MetodoPago = metodoPago,
                Detalles = new List<DetalleVenta>(),
                Total = 0
            };

            // 3. Procesar Items y Descontar Stock (Algoritmo FEFO)
            foreach (var item in items)
            {
                var producto = _repoProducto.ObtenerPorId(item.ProductoId);
                if (producto == null) throw new Exception($"Producto ID {item.ProductoId} no existe.");

                // Buscar lotes: De la sucursal correcta, con stock > 0 y NO vencidos
                var lotesDisponibles = _repoLote.ObtenerLotesParaVenta(item.ProductoId, sucursalId);

                int stockTotal = lotesDisponibles.Sum(l => l.CantidadActual);
                if (stockTotal < item.Cantidad)
                    throw new Exception($"Stock insuficiente para {producto.Nombre}. Pedido: {item.Cantidad}, Disp: {stockTotal}.");

                int porDescontar = item.Cantidad;

                foreach (var lote in lotesDisponibles)
                {
                    if (porDescontar <= 0) break;

                    int tomar = Math.Min(porDescontar, lote.CantidadActual);

                    lote.CantidadActual -= tomar;
                    _repoLote.Modificar(lote);

                    porDescontar -= tomar;
                }

                // Agregar Detalle a la Venta
                var subtotal = producto.Precio * item.Cantidad;
                venta.Detalles.Add(new DetalleVenta
                {
                    ProductoId = item.ProductoId,
                    Cantidad = item.Cantidad,
                    PrecioUnitario = producto.Precio,
                    Subtotal = subtotal
                });

                venta.Total += subtotal;
            }

            venta.Total = cliente.CalcularDescuento(venta.Total);

            // 5. Guardar Transacción Completa
            _repoVenta.Agregar(venta);
        }

        public List<Venta> ObtenerHistorialVentas() => _repoVenta.ObtenerHistorial();

        public Venta? ObtenerVentaPorId(int id) => _repoVenta.ObtenerPorId(id);
    }
}
