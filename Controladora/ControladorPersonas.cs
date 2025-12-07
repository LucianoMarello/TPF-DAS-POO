using Entidades;
using Modelo;
using Modelo.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladorPersonas
    {
        // --- SINGLETON ---
        private static ControladorPersonas? _instancia;
        public static ControladorPersonas Instancia
        {
            get { if (_instancia == null) _instancia = new ControladorPersonas(); return _instancia; }
        }

        private Context _context;
        private RepositorioCliente _repoCliente;
        private RepositorioProveedor _repoProveedor;

        private ControladorPersonas()
        {
            _context = new Context();
            _repoCliente = new RepositorioCliente(_context);
            _repoProveedor = new RepositorioProveedor(_context);
        }

        //Clientes
        public List<Cliente> ObtenerClientes() => _repoCliente.ObtenerTodos();

        public void AgregarCliente(string nombre, string telefono, string direccion, TipoCliente tipo)
        {
            //hace falta validar los otros strings? de los demas metodos tambien???
            if (string.IsNullOrWhiteSpace(nombre)) throw new Exception("Nombre requerido.");

            var cliente = new Cliente
            {
                Nombre = nombre,
                Telefono = telefono,
                Direccion = direccion,
                Tipo = tipo,
            };
            _repoCliente.Agregar(cliente);
        }

        public void ModificarCliente(Cliente cliente) => _repoCliente.Modificar(cliente);

        //Proveedores
        public List<Proveedor> ObtenerProveedores() => _repoProveedor.ObtenerTodos();

        public void AgregarProveedor(string nombre, string telefono, string direccion)
        {
            if (string.IsNullOrWhiteSpace(nombre)) throw new Exception("Nombre requerido.");

            var proveedor = new Proveedor
            {
                Nombre = nombre,
                Telefono = telefono,
                Direccion = direccion
            };
            _repoProveedor.Agregar(proveedor);
        }

        public void ModificarProveedor(Proveedor proveedor) => _repoProveedor.Modificar(proveedor);
    }
}
