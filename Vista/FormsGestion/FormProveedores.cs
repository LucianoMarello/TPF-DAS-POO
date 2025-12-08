using Controladora;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.FormsGestion
{
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = ControladorPersonas.Instancia.ObtenerProveedores();

            if (dgvProveedores.Columns["IngresosRealizados"] != null)
                dgvProveedores.Columns["IngresosRealizados"].Visible = false;
        }

        private void LimpiarCampos()
        {
            dgvProveedores.ClearSelection();
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Debe completar Nombre, Direccion y Telefono.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string patronTelefono = @"^[0-9\s\-\+\(\)]{7,20}$";
            if (!Regex.IsMatch(txtTelefono.Text, patronTelefono))
            {
                MessageBox.Show("El teléfono tiene un formato inválido. Use números, guiones o paréntesis.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string nombre = txtNombre.Text;
                string direccion = txtDireccion.Text;
                string telefono = txtTelefono.Text;

                ControladorPersonas.Instancia.AgregarProveedor(nombre, telefono, direccion);

                MessageBox.Show("Proveedor registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dgvProveedores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el proveedor que desea modificar desde la grilla.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Nombre, Direccion y Telefono son obligatorios.");
                return;
            }

            try
            {
                var proveedorOriginal = (Proveedor)dgvProveedores.SelectedRows[0].DataBoundItem;
                int idParaModificar = proveedorOriginal.PersonaId;

                string nombre = txtNombre.Text;
                string direccion = txtDireccion.Text;
                string telefono = txtTelefono.Text;

                var proveedorModificado = new Proveedor
                {
                    PersonaId = idParaModificar,
                    Nombre = nombre,
                    Telefono = telefono,
                    Direccion = direccion,
                };

                ControladorPersonas.Instancia.ModificarProveedor(proveedorModificado);

                MessageBox.Show("Proveedor modificado correctamente.");
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
            if (dgvProveedores.SelectedRows.Count > 0)
            {
                var proveedor = (Proveedor)dgvProveedores.SelectedRows[0].DataBoundItem;

                txtNombre.Text = proveedor.Nombre;
                txtTelefono.Text = proveedor.Telefono;
                txtDireccion.Text = proveedor.Direccion;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
