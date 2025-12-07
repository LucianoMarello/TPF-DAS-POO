using Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Repositorios
{
    public class RepositorioProducto
    {
        private readonly Context _context;

        public RepositorioProducto(Context context)
        {
            _context = context;
        }

        public List<Producto> ObtenerTodos()
        {
            return _context.Productos.Include(p => p.Rubro).ToList();
        }

        public Producto? ObtenerPorId(int id)
        {
            return _context.Productos.Find(id);
        }

        public void Agregar(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
        }

        public void Modificar(Producto producto)
        {
            _context.Entry(producto).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var producto = _context.Productos.Find(id);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
                _context.SaveChanges();
            }
        }
    }
}
