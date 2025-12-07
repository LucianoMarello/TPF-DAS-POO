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
    }
}
