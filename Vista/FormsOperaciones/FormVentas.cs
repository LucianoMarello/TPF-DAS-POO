using Controladora;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.FormsOperaciones
{
    public partial class FormVentas : Form
    {
        private List<ItemVentaDTO> _carrito;
        private int _stockDisponibleActual = 0;

        public FormVentas()
        {
            InitializeComponent();
            _carrito = new List<ItemVentaDTO>();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            CargarCombos();
            gbDatosProducto.Enabled = false;
            btnConfirmar.Enabled = false;
        }

        private void CargarCombos()
        {
            // 1. Clientes
            cmbCliente.DataSource = ControladorPersonas.Instancia.ObtenerClientes();
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "PersonaId"; // Ojo: Verifica si usas PersonaId o ClienteId según tu herencia

            // 2. Sucursales
            cmbSucursal.DataSource = ControladorVenta.Instancia.ObtenerSucursales();
            cmbSucursal.DisplayMember = "Nombre";
            cmbSucursal.ValueMember = "SucursalId";

            // 3. Método de Pago (Enum)
            cmbMetodoPago.DataSource = Enum.GetValues(typeof(MetodoPago));

            // 4. Productos
            cmbProducto.DataSource = ControladorProducto.Instancia.ObtenerProductos();
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "ProductoId";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedItem == null || cmbSucursal.SelectedItem == null)
            {
                MessageBox.Show("Seleccione Cliente y Sucursal.");
                return;
            }

            gbDatosVenta.Enabled = false; //bloquea gb de Datos
            gbDatosProducto.Enabled = true;
            btnConfirmar.Enabled = true;

            // Forzar actualización de stock del primer producto seleccionado
            cmbProducto_SelectionChangeCommitted(sender, e);
        }

        private void cmbProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedValue == null) return;

            int idProd = (int)cmbProducto.SelectedValue;
            int idSuc = (int)cmbSucursal.SelectedValue;

            var producto = (Producto)cmbProducto.SelectedItem;
            lblPrecio.Text = $"Precio: {producto.Precio:C2}";

            var stockSucursal = ControladorProducto.Instancia.ConsultarStockPorSucursal(idSuc);
            var itemStock = stockSucursal.FirstOrDefault(x => x.ProductoId == idProd);

            _stockDisponibleActual = itemStock != null ? itemStock.StockTotal : 0;

            lblStock.Text = $"Stock Disp: {_stockDisponibleActual}";

            //color
            lblStock.ForeColor = _stockDisponibleActual > 0 ? Color.Black : Color.Red;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem == null) return;
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Cantidad inválida."); return;
            }

            int idProd = (int)cmbProducto.SelectedValue;
            int cantidadEnCarrito = _carrito.Where(x => x.ProductoId == idProd).Sum(x => x.Cantidad);

            if ((cantidad + cantidadEnCarrito) > _stockDisponibleActual)
            {
                MessageBox.Show($"Stock insuficiente. Disponible real: {_stockDisponibleActual}. Ya en carrito: {cantidadEnCarrito}.");
                return;
            }

            var item = new ItemVentaDTO
            {
                ProductoId = idProd,
                Cantidad = cantidad
            };

            _carrito.Add(item);
            ActualizarGrilla();
            txtCantidad.Text = "";
            cmbProducto.Focus();
        }

        private void ActualizarGrilla()
        {
            var visualList = _carrito.Select(dto => new
            {
                Producto = ((Producto)cmbProducto.Items.Cast<Producto>().First(p => p.ProductoId == dto.ProductoId)).Nombre,
                Cantidad = dto.Cantidad,
                PrecioUnitarioEstimado = ((Producto)cmbProducto.Items.Cast<Producto>().First(p => p.ProductoId == dto.ProductoId)).Precio,
                SubtotalEstimado = ((Producto)cmbProducto.Items.Cast<Producto>().First(p => p.ProductoId == dto.ProductoId)).Precio * dto.Cantidad,
                ObjetoReal = dto
            }).ToList();

            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = visualList;

            if (dgvCarrito.Columns["ObjetoReal"] != null) dgvCarrito.Columns["ObjetoReal"].Visible = false;
            if (dgvCarrito.Columns["PrecioUnitarioEstimado"] != null) dgvCarrito.Columns["PrecioUnitarioEstimado"].DefaultCellStyle.Format = "C2";
            if (dgvCarrito.Columns["SubtotalEstimado"] != null) dgvCarrito.Columns["SubtotalEstimado"].DefaultCellStyle.Format = "C2";
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.SelectedRows.Count > 0)
            {
                var item = (ItemVentaDTO)dgvCarrito.SelectedRows[0].Cells["ObjetoReal"].Value;
                _carrito.Remove(item);
                ActualizarGrilla();
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            if (_carrito.Count > 0)
            {
                var confirmacion = MessageBox.Show("¿Desea quitar todos los productos del carrito?", "Vaciar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    _carrito.Clear();
                    ActualizarGrilla();
                    txtCantidad.Text = "";
                    cmbProducto.Focus();
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (_carrito.Count == 0) return;

            // Datos para pasar al form flotante
            string cliente = cmbCliente.Text;
            int clienteId = (int)cmbCliente.SelectedValue;
            string sucursal = cmbSucursal.Text;
            int sucursalId = (int)cmbSucursal.SelectedValue;
            MetodoPago pago = (MetodoPago)cmbMetodoPago.SelectedItem;

            // Llamamos al flotante (Igual que en compras)
            FormConfirmarVenta form = new FormConfirmarVenta(_carrito, cliente, clienteId, sucursal, sucursalId, pago);

            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Venta registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Reset
                _carrito.Clear();
                ActualizarGrilla();
                gbDatosVenta.Enabled = true;
                gbDatosProducto.Enabled = false;
                btnConfirmar.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _carrito.Clear();
            ActualizarGrilla();

            gbDatosVenta.Enabled = true;
            gbDatosProducto.Enabled = false;
            btnConfirmar.Enabled = false;
            txtCantidad.Text = "";
            lblStock.Text = "Stock Disp: -";
            lblPrecio.Text = "Precio: -";
        }
    }
}
