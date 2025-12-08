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

namespace Vista.FormsGestion
{
    public partial class FormSucursales : Form
    {
        public FormSucursales()
        {
            InitializeComponent();
        }

        private void FormSucursales_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            dgvSucursales.DataSource = null;
            dgvSucursales.DataSource = ControladorVenta.Instancia.ObtenerSucursales();

            if (dgvSucursales.Columns["Lotes"] != null) dgvSucursales.Columns["Lotes"].Visible = false;
            if (dgvSucursales.Columns["VentasRealizadas"] != null) dgvSucursales.Columns["VentasRealizadas"].Visible = false;
        }

        private void LimpiarCampos()
        {
            dgvSucursales.ClearSelection();
            dgvStock.ClearSelection();
            txtNombre.Text = "";
            txtDireccion.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Complete todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ControladorVenta.Instancia.AgregarSucursal(txtNombre.Text, txtDireccion.Text);

                MessageBox.Show("Sucursal guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                ActualizarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvSucursales.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una sucursal para modificar.");
                return;
            }

            try
            {
                var original = (Sucursal)dgvSucursales.SelectedRows[0].DataBoundItem;

                var sucursalModificada = new Sucursal
                {
                    SucursalId = original.SucursalId,
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text
                };

                ControladorVenta.Instancia.ModificarSucursal(sucursalModificada);

                MessageBox.Show("Sucursal modificada.");
                LimpiarCampos();
                ActualizarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (dgvSucursales.SelectedRows.Count > 0)
            {
                var sucursal = (Sucursal)dgvSucursales.SelectedRows[0].DataBoundItem;
                txtNombre.Text = sucursal.Nombre;
                txtDireccion.Text = sucursal.Direccion;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvSucursales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvSucursales.SelectedRows.Count > 0)
            {
                var sucursalSeleccionada = (Sucursal)dgvSucursales.SelectedRows[0].DataBoundItem;
                CargarStock(sucursalSeleccionada.SucursalId, sucursalSeleccionada.Nombre);
            }
        }

        private void CargarStock(int sucursalId, string nombreSucursal)
        {
            try
            {
                var stock = ControladorProducto.Instancia.ConsultarStockPorSucursal(sucursalId);

                dgvStock.DataSource = null;
                dgvStock.DataSource = stock;

                if (dgvStock.Columns["Precio"] != null) dgvStock.Columns["Precio"].DefaultCellStyle.Format = "C2";
                if (dgvStock.Columns["StockTotal"] != null) dgvStock.Columns["StockTotal"].HeaderText = "STOCK";
                lblListaProductos.Text = $"Stock de Productos en Sucursal: {nombreSucursal}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblListaProductos.Text = "Stock de Productos";
                dgvStock.DataSource = null;
            }
        }
    }
}
