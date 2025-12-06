using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Repositorios
{
    public class RepositorioLotes
    {
        private readonly Context _context;

        public RepositorioLotes(Context context)
        {
            _context = context;
        }

        public List<Lote> ObtenerTodos()
        {
            return _context.Lotes.Include(p => p.Producto).Include(p => p.Sucursal).ToList();
        }

        public Lote ObtenerPorId(int id)
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
            return _context.Lotes
                .Where(l => l.ProductoId == productoId
                && l.SucursalId == sucursalId
                && l.CantidadActual > 0
                && !l.EstaVencido())
                .OrderBy(l => l.FechaVencimiento)
                .ToList();
        }

        public int ObtenerStockTotal(int productoId, int sucursalId)
        {
            return _context.Lotes
                .Where(l => l.ProductoId == productoId
                && l.SucursalId == sucursalId
                && l.CantidadActual > 0
                && !l.EstaVencido())
                .Sum(l => l.CantidadActual);
        }

        public List<Lote> ObtenerProximosAVencer()
        {
            return _context.Lotes
                .Where(l => l.ProximoAVencer()
                && l.CantidadActual > 0)
                .Include(l => l.Producto)
                .Include(l => l.Sucursal)
                .OrderBy(l => l.FechaVencimiento)
                .ToList();
        }
    }
}
