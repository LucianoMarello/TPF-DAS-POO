using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Repositorios
{
    public class RepositorioVenta
    {
        private readonly Context _context;

        public RepositorioVenta(Context context)
        {
            _context = context;
        }

        public void Agregar(Venta venta)
        {
            _context.Ventas.Add(venta);
            _context.SaveChanges();
        }

        public List<Venta> ObtenerHistorial()
        {
            return _context.Ventas
                           .Include(v => v.Cliente)
                           .Include(v => v.Sucursal)
                           .Include(v => v.Detalles)
                           .ThenInclude(d => d.Producto)
                           .OrderByDescending(v => v.FechaMovimiento)
                           .ToList();
        }

        public Venta? ObtenerPorId(int id)
        {
            return _context.Ventas
                           .Include(v => v.Cliente)
                           .Include(v => v.Detalles)
                           .ThenInclude(d => d.Producto)
                           .FirstOrDefault(v => v.MovimientoId == id);
        }
    }
}
