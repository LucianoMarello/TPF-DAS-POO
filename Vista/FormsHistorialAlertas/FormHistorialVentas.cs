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

namespace Vista.FormsHistorialAlertas
{
    public partial class FormHistorialVentas : Form
    {
        public FormHistorialVentas()
        {
            InitializeComponent();
        }

        private void FormHistorialVentas_Load(object sender, EventArgs e)
        {
            dtpInicio.Value = DateTime.Now.AddDays(-30);
            dtpFin.Value = DateTime.Now;

            CargarCombosFiltro();
            FiltrarVentas();
        }

        private void CargarCombosFiltro()
        {
            //SUCURSALES
            var listaSucursales = ControladorVenta.Instancia.ObtenerSucursales();
            var opcionesSucursal = new List<Sucursal>(listaSucursales);
            opcionesSucursal.Insert(0, new Sucursal { SucursalId = 0, Nombre = "Todas" });

            cmbFiltroSucursal.DataSource = opcionesSucursal;
            cmbFiltroSucursal.DisplayMember = "Nombre";
            cmbFiltroSucursal.ValueMember = "SucursalId";
            cmbFiltroSucursal.SelectedIndex = 0;

            //PRODUCTOS
            var listaProductos = ControladorProducto.Instancia.ObtenerProductos();
            var opcionesProducto = new List<Producto>(listaProductos);
            opcionesProducto.Insert(0, new Producto { ProductoId = 0, Nombre = "Todos" });

            cmbFiltroProducto.DataSource = opcionesProducto;
            cmbFiltroProducto.DisplayMember = "Nombre";
            cmbFiltroProducto.ValueMember = "ProductoId";
            cmbFiltroProducto.SelectedIndex = 0;

            //CLIENTES
            var listaClientes = ControladorPersonas.Instancia.ObtenerClientes();
            var opcionesCliente = new List<Cliente>(listaClientes);
            opcionesCliente.Insert(0, new Cliente { PersonaId = 0, Nombre = "Todos" });

            cmbFiltroCliente.DataSource = opcionesCliente;
            cmbFiltroCliente.DisplayMember = "Nombre";
            cmbFiltroCliente.ValueMember = "PersonaId";
            cmbFiltroCliente.SelectedIndex = 0;
        }

        private void FiltrarVentas()
        {
            if (cmbFiltroSucursal.SelectedValue == null ||
                cmbFiltroProducto.SelectedValue == null ||
                cmbFiltroCliente.SelectedValue == null) return;

            int idSucursal = (int)cmbFiltroSucursal.SelectedValue;
            int idProducto = (int)cmbFiltroProducto.SelectedValue;
            int idCliente = (int)cmbFiltroCliente.SelectedValue;

            var historial = ControladorVenta.Instancia.ObtenerHistorialVentas();

            var filtrado = historial.Where(x =>
                //Fecha
                x.FechaMovimiento.Date >= dtpInicio.Value.Date &&
                x.FechaMovimiento.Date <= dtpFin.Value.Date &&

                //Sucursal
                (idSucursal == 0 || x.SucursalId == idSucursal) &&

                //Cliente
                (idCliente == 0 || x.ClienteId == idCliente) &&

                //Producto
                (idProducto == 0 || x.Detalles.Any(d => d.ProductoId == idProducto))
            ).ToList();

            var listaVisual = filtrado.Select(x => new
            {
                NroVenta = x.MovimientoId,
                Fecha = x.FechaMovimiento,
                Cliente = x.Cliente != null ? x.Cliente.Nombre : "N/A",
                Sucursal = x.Sucursal != null ? x.Sucursal.Nombre : "N/A",
                MetodoPago = x.MetodoPago,
                Total = x.Total,
                ObjetoReal = x // Guardamos el objeto para el detalle
            }).ToList();

            dgvVentas.DataSource = null;
            dgvVentas.DataSource = listaVisual;

            ConfigurarGrillaMaestra();
            dgvDetalles.DataSource = null;
        }

        private void ConfigurarGrillaMaestra()
        {
            if (dgvVentas.Columns["ObjetoReal"] != null) dgvVentas.Columns["ObjetoReal"].Visible = false;
            if (dgvVentas.Columns["Total"] != null) dgvVentas.Columns["Total"].DefaultCellStyle.Format = "C2";
            if (dgvVentas.Columns["Fecha"] != null) dgvVentas.Columns["Fecha"].Width = 120;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarVentas();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtpInicio.Value = DateTime.Now.AddDays(-30);
            dtpFin.Value = DateTime.Now;
            if (cmbFiltroSucursal.Items.Count > 0) cmbFiltroSucursal.SelectedIndex = 0;
            if (cmbFiltroProducto.Items.Count > 0) cmbFiltroProducto.SelectedIndex = 0;
            if (cmbFiltroCliente.Items.Count > 0) cmbFiltroCliente.SelectedIndex = 0;

            FiltrarVentas();
        }

        private void dgvVentas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                var venta = (Venta)dgvVentas.SelectedRows[0].Cells["ObjetoReal"].Value;
                CargarDetalles(venta);
            }
        }

        private void CargarDetalles(Venta venta)
        {
            var detallesVisuales = venta.Detalles.Select(d => new
            {
                Producto = d.Producto != null ? d.Producto.Nombre : "Desconocido",
                Cantidad = d.Cantidad,
                PrecioUnitario = d.PrecioUnitario,
                Subtotal = d.Subtotal
            }).ToList();

            dgvDetalles.DataSource = null;
            dgvDetalles.DataSource = detallesVisuales;

            if (dgvDetalles.Columns["PrecioUnitario"] != null) dgvDetalles.Columns["PrecioUnitario"].DefaultCellStyle.Format = "C2";
            if (dgvDetalles.Columns["Subtotal"] != null) dgvDetalles.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una venta.");
                return;
            }

            try
            {
                var ventaSeleccionada = (Venta)dgvVentas.SelectedRows[0].Cells["ObjetoReal"].Value;
                GeneradorFactura.GenerarTicket(ventaSeleccionada);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar ticket: " + ex.Message);
            }
        }

        private void btnMasVendidos_Click(object sender, EventArgs e)
        {
            string reporte = ControladorVenta.Instancia.ObtenerRankingMasVendidos();
            MessageBox.Show(reporte, "Ranking de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
