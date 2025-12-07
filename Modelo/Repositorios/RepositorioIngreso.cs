using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Repositorios
{
    public class RepositorioIngreso
    {
        private readonly Context _context;

        public RepositorioIngreso(Context context)
        {
            _context = context;
        }

        public void Agregar(Ingreso ingreso)
        {
            _context.Ingresos.Add(ingreso);
            _context.SaveChanges();
        }

        public List<Ingreso> ObtenerHistorial()
        {
            return _context.Ingresos
                           .Include(i => i.Proveedor)
                           .Include(i => i.Sucursal)
                           .OrderByDescending(i => i.FechaMovimiento)
                           .ToList();
        }

        public Ingreso? ObtenerPorId(int id)
        {
            return _context.Ingresos
                           .Include(i => i.Proveedor)
                           .Include(i => i.Detalles)
                           .ThenInclude(d => d.Producto)
                           .FirstOrDefault(i => i.MovimientoId == id);
        }
    }
}
