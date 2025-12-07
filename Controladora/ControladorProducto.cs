using Entidades;
using Microsoft.EntityFrameworkCore;
using Modelo;
using Modelo.Repositorios;

namespace Controladora
{
    public class ControladorProducto
    {
        //Patron Singleton
        private static ControladorProducto? _instancia;
        public static ControladorProducto Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ControladorProducto();
                }
                return _instancia;
            }
        }

        private Context _context;
        private RepositorioProducto _repoProducto;
        private RepositorioRubro _repoRubro;
        private RepositorioLote _repoLote;

        private ControladorProducto()
        {
            _context = new Context();
            _repoProducto = new RepositorioProducto(_context);
            _repoRubro = new RepositorioRubro(_context);
            _repoLote = new RepositorioLote(_context);
        }

        //PRODUCTOS
        public List<Producto> ObtenerProductos() => _repoProducto.ObtenerTodos();

        public Producto? ObtenerProductoPorId(int id) => _repoProducto.ObtenerPorId(id);

        public void AgregarProducto(string nombre, string descripcion, decimal precioCosto, int rubroId, int stockMinimo)
        {
            if (string.IsNullOrWhiteSpace(nombre)) throw new Exception("Nombre requerido.");
            if (precioCosto <= 0) throw new Exception("El precio debe ser mayor a 0.");

            // REGLA DE NEGOCIO: Precio Venta = Compra + 50%
            decimal precioVenta = precioCosto * 1.5m;

            var nuevo = new Producto
            {
                Nombre = nombre,
                Descripcion = descripcion,
                Precio = precioVenta,
                RubroId = rubroId,
                StockMinimoAlerta = stockMinimo
            };

            _repoProducto.Agregar(nuevo);
        }

        public void ModificarProducto(Producto producto)
        {
            _repoProducto.Modificar(producto);
        }

        public void EliminarProducto(int id)
        {
            // Validación: No borrar si hay stock físico
            int stockTotal = _repoLote.ObtenerStockTotal(id);
            if (stockTotal > 0) throw new Exception($"No se puede eliminar un producto con stock activo. Stock = {stockTotal}. ");

            _repoProducto.Eliminar(id);
        }

        public List<Producto> ObtenerProductosBajoStock()
        {
            // Filtra en memoria los que tienen stock total menor al mínimo
            var productos = _repoProducto.ObtenerTodos();
            return productos.Where(p =>
                _repoLote.ObtenerStockTotalPorSucursal(p.ProductoId, 1) <= p.StockMinimoAlerta
            ).ToList();
        }

        //RUBROS
        public List<Rubro> ObtenerRubros() => _repoRubro.ObtenerTodos();
        
        public Rubro? ObtenerRubroPorId(int id) => _repoRubro.ObtenerPorId(id);

        public void AgregarRubro(string nombre, string descripcion)
        {
            if (string.IsNullOrWhiteSpace(nombre)) throw new Exception("Nombre de rubro requerido.");
            var rubro = new Rubro { Nombre = nombre, Descripcion = descripcion };
            _repoRubro.Agregar(rubro);
        }

        public void ModificarRubro(Rubro rubro)
        {
            _repoRubro.Modificar(rubro);
        }

        public void EliminarRubro(int id)
        {
            var productosAsociados = _repoProducto.ObtenerTodos().Any(p => p.RubroId == id);
            if (productosAsociados) throw new Exception("No se puede eliminar un rubro con productos asociados.");

            _repoRubro.Eliminar(id);
        }

        //LOTES
        public List<Lote> ObtenerLotes() => _repoLote.ObtenerTodos();

        public Lote? ObtenerLotePorId(int id) => _repoLote.ObtenerPorId(id);

        public List<Lote> ObtenerAlertasVencimiento()
        {
            return _repoLote.ObtenerProximosAVencer();
        }

    }
}
