using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Repositorios
{
    public class RepositorioLote
    {
        private readonly Context _context;

        public RepositorioLote(Context context)
        {
            _context = context;
        }

        public List<Lote> ObtenerTodos()
        {
            return _context.Lotes.Include(p => p.Producto).Include(p => p.Sucursal).ToList();
        }

        public Lote? ObtenerPorId(int id)
        {
            return _context.Lotes.Find(id);
        }

        public void Agregar(Lote l)
        {
            _context.Lotes.Add(l);
            _context.SaveChanges();
        }

        public void Modificar(Lote l)
        {
            _context.Entry(l).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var lote = _context.Lotes.Find(id);
            if (lote != null)
            {
                _context.Lotes.Remove(lote);
                _context.SaveChanges();
            }
        }

        public List<Lote> ObtenerLotesParaVenta(int productoId, int sucursalId)
        {
            DateTime hoy = DateTime.Now;

            return _context.Lotes
                .Where(l => l.ProductoId == productoId
                && l.SucursalId == sucursalId
                && l.CantidadActual > 0
                && l.FechaVencimiento > hoy)
                .OrderBy(l => l.FechaVencimiento)
                .ToList();
        }

        public int ObtenerStockTotal(int productoId, int sucursalId)
        {
            DateTime hoy = DateTime.Now;
            return _context.Lotes
                .Where(l => l.ProductoId == productoId
                && l.SucursalId == sucursalId
                && l.CantidadActual > 0
                && l.FechaVencimiento > hoy)
                .Sum(l => l.CantidadActual);
        }

        public List<Lote> ObtenerProximosAVencer()
        {
            DateTime hoy = DateTime.Now;
            var limite = hoy.AddDays(7);

            return _context.Lotes
                .Include(l => l.Producto)
                .Include(l => l.Sucursal)
                .Where(l => l.CantidadActual > 0
                && l.FechaVencimiento > hoy
                && l.FechaVencimiento <= limite)
                .OrderBy(l => l.FechaVencimiento)
                .ToList();
        }
    }
}
