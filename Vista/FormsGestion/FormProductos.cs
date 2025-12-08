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
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            CargarComboRubros();
        }

        private void ActualizarGrilla()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = ControladorProducto.Instancia.ObtenerProductos();

            if (dgvProductos.Columns["Rubro"] != null) dgvProductos.Columns["Rubro"].Visible = false;
            if (dgvProductos.Columns["Lotes"] != null) dgvProductos.Columns["Lotes"].Visible = false;

            // Formato de Moneda para el Precio
            if (dgvProductos.Columns["Precio"] != null)
                dgvProductos.Columns["Precio"].DefaultCellStyle.Format = "C2";
        }

        private void CargarComboRubros()
        {
            cmbRubro.DataSource = null;
            cmbRubro.DataSource = ControladorProducto.Instancia.ObtenerRubros();
            cmbRubro.DisplayMember = "Nombre"; // Lo que ve el usuario
            cmbRubro.ValueMember = "RubroId";  // El valor real (ID)
        }

        private void LimpiarCampos()
        {
            dgvProductos.ClearSelection();
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtCosto.Text = "";
            txtStockMin.Text = "";
            if (cmbRubro.Items.Count > 0) cmbRubro.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCosto.Text))
            {
                MessageBox.Show("Debe completar Nombre y Costo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string nombre = txtNombre.Text;
                string desc = txtDescripcion.Text;
                if (!decimal.TryParse(txtCosto.Text, out decimal costo))
                {
                    MessageBox.Show("El costo debe ser un número válido.");
                    return;
                }
                if (!int.TryParse(txtStockMin.Text, out int stockMin)) stockMin = 0;
                if (cmbRubro.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un Rubro.");
                    return;
                }
                int rubroId = (int)cmbRubro.SelectedValue;

                ControladorProducto.Instancia.AgregarProducto(nombre, desc, costo, rubroId, stockMin);

                MessageBox.Show("Producto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el producto que desea modificar desde la grilla.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCosto.Text))
            {
                MessageBox.Show("Nombre y Costo son obligatorios.");
                return;
            }

            try
            {
                var productoOriginal = (Producto)dgvProductos.SelectedRows[0].DataBoundItem;
                int idParaModificar = productoOriginal.ProductoId;

                string nombre = txtNombre.Text;
                string desc = txtDescripcion.Text;
                decimal costo = decimal.Parse(txtCosto.Text);
                int rubroId = (int)cmbRubro.SelectedValue;
                int stockMin = int.Parse(txtStockMin.Text);

                decimal precioVenta = costo * 1.5m;

                var productoModificado = new Producto
                {
                    ProductoId = idParaModificar,
                    Nombre = nombre,
                    Descripcion = desc,
                    Precio = precioVenta,
                    RubroId = rubroId,
                    StockMinimoAlerta = stockMin,
                };

                ControladorProducto.Instancia.ModificarProducto(productoModificado);

                MessageBox.Show("Producto modificado correctamente.");
                LimpiarCampos();
                ActualizarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                var producto = (Producto)dgvProductos.SelectedRows[0].DataBoundItem;

                var confirmacion = MessageBox.Show($"¿Seguro que desea eliminar '{producto.Nombre}'?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        ControladorProducto.Instancia.EliminarProducto(producto.ProductoId);
                        ActualizarGrilla();
                        MessageBox.Show("Eliminado correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto de la lista.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                var producto = (Producto)dgvProductos.SelectedRows[0].DataBoundItem;

                txtNombre.Text = producto.Nombre;
                txtDescripcion.Text = producto.Descripcion;
                txtCosto.Text = (producto.Precio / 1.5m).ToString("0.00");
                txtStockMin.Text = producto.StockMinimoAlerta.ToString();
                cmbRubro.SelectedValue = producto.RubroId;
            }
        }
    }
}
