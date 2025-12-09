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
    public partial class FormHistorialCompras : Form
    {
        public FormHistorialCompras()
        {
            InitializeComponent();
        }

        private void FormHistorialCompras_Load(object sender, EventArgs e)
        {
            //fecha por defecto: últimos 30 días
            dtpInicio.Value = DateTime.Now.AddDays(-30);
            dtpFin.Value = DateTime.Now;

            CargarCombosFiltro();
            FiltrarCompras();
        }

        private void CargarCombosFiltro()
        {
            var listaSucursales = ControladorVenta.Instancia.ObtenerSucursales();
            var opcionesSucursal = new List<Sucursal>(listaSucursales);

            opcionesSucursal.Insert(0, new Sucursal { SucursalId = 0, Nombre = "Todas" });

            cmbFiltroSucursal.DataSource = opcionesSucursal;
            cmbFiltroSucursal.DisplayMember = "Nombre";
            cmbFiltroSucursal.ValueMember = "SucursalId";
            cmbFiltroSucursal.SelectedIndex = 0; // Seleccionar "Todas" por defecto

            var listaProductos = ControladorProducto.Instancia.ObtenerProductos();
            var opcionesProducto = new List<Producto>(listaProductos);

            opcionesProducto.Insert(0, new Producto { ProductoId = 0, Nombre = "Todos" });

            cmbFiltroProducto.DataSource = opcionesProducto;
            cmbFiltroProducto.DisplayMember = "Nombre";
            cmbFiltroProducto.ValueMember = "ProductoId";
            cmbFiltroProducto.SelectedIndex = 0;
        }

        private void FiltrarCompras()
        {
            if (cmbFiltroSucursal.SelectedValue == null || cmbFiltroProducto.SelectedValue == null) return;

            int idSucursal = (int)cmbFiltroSucursal.SelectedValue;
            int idProducto = (int)cmbFiltroProducto.SelectedValue;

            var historial = ControladorCompra.Instancia.ObtenerHistorialCompras();

            var filtrado = historial.Where(x =>
                x.FechaMovimiento.Date >= dtpInicio.Value.Date &&
                x.FechaMovimiento.Date <= dtpFin.Value.Date &&
                (idSucursal == 0 || x.SucursalId == idSucursal) &&
                (idProducto == 0 || x.Detalles.Any(d => d.ProductoId == idProducto))
            ).ToList();

            var listaVisual = filtrado.Select(x => new
            {
                NroIngreso = x.MovimientoId,
                Fecha = x.FechaMovimiento,
                Proveedor = x.Proveedor != null ? x.Proveedor.Nombre : "N/A",
                Sucursal = x.Sucursal != null ? x.Sucursal.Nombre : "N/A",
                Total = x.Total,
                ObjetoReal = x
            }).ToList();

            dgvIngresos.DataSource = null;
            dgvIngresos.DataSource = listaVisual;

            ConfigurarGrillaMaestra();

            dgvDetalles.DataSource = null;
        }

        private void ConfigurarGrillaMaestra()
        {
            // Ocultar columna del objeto real
            if (dgvIngresos.Columns["ObjetoReal"] != null)
                dgvIngresos.Columns["ObjetoReal"].Visible = false;

            // Formato Moneda
            if (dgvIngresos.Columns["Total"] != null)
                dgvIngresos.Columns["Total"].DefaultCellStyle.Format = "C2";

            // Ordenar columnas visualmente
            if (dgvIngresos.Columns["NroIngreso"] != null) dgvIngresos.Columns["NroIngreso"].HeaderText = "Nro";
            if (dgvIngresos.Columns["Fecha"] != null) dgvIngresos.Columns["Fecha"].Width = 120;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarCompras();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //resetea fechas a un rango muy amplio
            dtpInicio.Value = DateTime.Now.AddYears(-5);
            dtpFin.Value = DateTime.Now;

            if (cmbFiltroSucursal.Items.Count > 0) cmbFiltroSucursal.SelectedIndex = 0;
            if (cmbFiltroProducto.Items.Count > 0) cmbFiltroProducto.SelectedIndex = 0;

            FiltrarCompras();
        }

        private void dgvIngresos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvIngresos.SelectedRows.Count > 0)
            {
                var ingresoSeleccionado = (Ingreso)dgvIngresos.SelectedRows[0].Cells["ObjetoReal"].Value;
                CargarDetalles(ingresoSeleccionado);
            }
        }

        private void CargarDetalles(Ingreso ingreso)
        {
            var detallesVisuales = ingreso.Detalles.Select(d => new
            {
                Producto = d.Producto != null ? d.Producto.Nombre : "Desconocido",
                Cantidad = d.CantidadOriginal,
                CostoUnitario = d.CostoUnitario,
                Subtotal = d.CantidadOriginal * d.CostoUnitario
            }).ToList();

            dgvDetalles.DataSource = null;
            dgvDetalles.DataSource = detallesVisuales;

            // Formato Moneda
            if (dgvDetalles.Columns["CostoUnitario"] != null)
                dgvDetalles.Columns["CostoUnitario"].DefaultCellStyle.Format = "C2";

            if (dgvDetalles.Columns["Subtotal"] != null)
                dgvDetalles.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
        }
    }
}
