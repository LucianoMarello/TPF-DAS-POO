using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Repositorios
{
    public class RepositorioProveedor
    {
        private readonly Context _context;

        public RepositorioProveedor(Context context)
        {
            _context = context;
        }

        public List<Proveedor> ObtenerTodos()
        {
            return _context.Proveedores.ToList();
        }

        public Proveedor? ObtenerPorId(int id)
        {
            return _context.Proveedores.Find(id);
        }

        public void Agregar(Proveedor proveedor)
        {
            _context.Proveedores.Add(proveedor);
            _context.SaveChanges();
        }

        public void Modificar(Proveedor proveedor)
        {
            _context.Entry(proveedor).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
