using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Repositorios
{
    public class RepositorioSucursal
    {
        private readonly Context _context;

        public RepositorioSucursal(Context context)
        {
            _context = context;
        }

        public List<Sucursal> ObtenerTodos()
        {
            return _context.Sucursales.ToList();
        }

        public Sucursal? ObtenerPorId(int id)
        {
            return _context.Sucursales.Find(id);
        }

        public void Agregar(Sucursal s)
        {
            _context.Sucursales.Add(s);
            _context.SaveChanges();
        }

        public void Modificar(Sucursal s)
        {
            var local = _context.Sucursales.Local.FirstOrDefault(x => x.SucursalId == s.SucursalId);
            if (local != null) _context.Entry(local).State = Microsoft.EntityFrameworkCore.EntityState.Detached;

            _context.Entry(s).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
