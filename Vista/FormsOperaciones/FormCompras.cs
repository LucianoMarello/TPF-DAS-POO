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
    public partial class FormCompras : Form
    {
        private List<ItemCompraDTO> _carrito;

        public FormCompras()
        {
            InitializeComponent();
            _carrito = new List<ItemCompraDTO>();
        }

        private void FormCompras_Load(object sender, EventArgs e)
        {
            lblFechaIngreso.Text = $"Fecha: {DateTime.Now.ToShortDateString()}";
            CargarCombos();
            gbDatosProducto.Enabled = false;
            btnComprar.Enabled = false;
        }

        private void CargarCombos()
        {
            // Proveedores
            cmbProveedor.DataSource = ControladorPersonas.Instancia.ObtenerProveedores();
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "PersonaId";

            // Sucursales
            cmbSucursal.DataSource = ControladorVenta.Instancia.ObtenerSucursales();
            cmbSucursal.DisplayMember = "Nombre";
            cmbSucursal.ValueMember = "SucursalId";

            // Productos
            cmbProducto.DataSource = ControladorProducto.Instancia.ObtenerProductos();
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "ProductoId";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (cmbProveedor.SelectedItem == null || cmbSucursal.SelectedItem == null)
            {
                MessageBox.Show("Seleccione Proveedor y Sucursal.");
                return;
            }

            gbDatosIngreso.Enabled = false;
            gbDatosProducto.Enabled = true;
            btnComprar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _carrito.Clear();
            ActualizarGrilla();
            LimpiarCamposProducto();
            gbDatosIngreso.Enabled = true;
            gbDatosProducto.Enabled = false;
            btnComprar.Enabled = false;
        }

        private void chkVencimiento_CheckedChanged(object sender, EventArgs e)
        {
            dtpVencimiento.Enabled = chkVencimiento.Checked;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem == null) return;

            if (!int.TryParse(txtCantidad.Text, out int cant) || cant <= 0)
            { MessageBox.Show("Cantidad incorrecta"); return; }

            if (!decimal.TryParse(txtCosto.Text, out decimal costo) || costo <= 0)
            { MessageBox.Show("Costo incorrecto"); return; }

            // Si el check está apagado, se le asigna una fecha muy lejana (No Perecedero)
            DateTime fechaVenc = chkVencimiento.Checked ? dtpVencimiento.Value.Date : DateTime.Now.AddYears(10);

            var item = new ItemCompraDTO
            {
                ProductoId = (int)cmbProducto.SelectedValue,
                Cantidad = cant,
                Costo = costo,
                FechaVencimiento = fechaVenc
            };

            _carrito.Add(item);
            ActualizarGrilla();
            LimpiarCamposProducto();
        }

        private void ActualizarGrilla()
        {
            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = _carrito;
        }

        private void LimpiarCamposProducto()
        {
            txtCantidad.Text = "";
            txtCosto.Text = "";
            chkVencimiento.Checked = false;
            cmbProducto.Focus();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.SelectedRows.Count > 0)
            {
                var item = (ItemCompraDTO)dgvCarrito.SelectedRows[0].DataBoundItem;
                _carrito.Remove(item);
                ActualizarGrilla();
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            _carrito.Clear();
            ActualizarGrilla();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (_carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.");
                return;
            }

            // Datos de Ingreso
            int idProv = (int)cmbProveedor.SelectedValue;
            string nombreProv = cmbProveedor.Text;
            int idSuc = (int)cmbSucursal.SelectedValue;
            string nombreSuc = cmbSucursal.Text;

            FormConfirmarCompra formConfirmar = new FormConfirmarCompra(_carrito, idProv, nombreProv, idSuc, nombreSuc);

            DialogResult respuesta = formConfirmar.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                MessageBox.Show("¡Compra Registrada!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //resetea el form
                _carrito.Clear();
                ActualizarGrilla();
                gbDatosIngreso.Enabled = true;
                gbDatosProducto.Enabled = false;
                btnComprar.Enabled = false;
            }
        }
    }
}
