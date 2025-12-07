using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Repositorios
{
    public class RepositorioCliente
    {
        private readonly Context _context;

        public RepositorioCliente(Context context)
        {
            _context = context;
        }

        public List<Cliente> ObtenerTodos()
        {
            return _context.Clientes.ToList();
        }

        public Cliente? ObtenerPorId(int id)
        {
            return _context.Clientes.Find(id);
        }

        public void Agregar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void Modificar(Cliente cliente)
        {
            _context.Entry(cliente).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var c = _context.Clientes.Find(id);
            if (c != null)
            {
                _context.Clientes.Remove(c);
                _context.SaveChanges();
            }
        }
    }
}
