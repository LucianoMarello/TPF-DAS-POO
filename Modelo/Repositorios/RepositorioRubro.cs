using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Repositorios
{
    public class RepositorioRubro
    {
        private readonly Context _context;

        public RepositorioRubro(Context context)
        {
            _context = context;
        }

        public List<Rubro> ObtenerTodos()
        {
            return _context.Rubros.ToList();
        }

        public Rubro? ObtenerPorId(int id)
        {
           
            return _context.Rubros.Find(id);
        }
        public void Agregar(Rubro rubro)
        {
            _context.Rubros.Add(rubro);
            _context.SaveChanges();
        }

        public void Modificar(Rubro rubro)
        {
            _context.Entry(rubro).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var rubro = _context.Rubros.Find(id);
            if (rubro != null)
            {
                _context.Rubros.Remove(rubro);
                _context.SaveChanges();
            }
        }
    }
}
