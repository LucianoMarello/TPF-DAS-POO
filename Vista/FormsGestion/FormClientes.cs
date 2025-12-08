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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            CargarComboTiposClientes();
        }

        private void ActualizarGrilla()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = ControladorPersonas.Instancia.ObtenerClientes();

            if (dgvClientes.Columns["HistorialVentas"] != null)
                dgvClientes.Columns["HistorialVentas"].Visible = false;
        }

        private void CargarComboTiposClientes()
        {
            cmbTipoCliente.DataSource = null;
            cmbTipoCliente.DataSource = Enum.GetValues(typeof(TipoCliente));

        }

        private void LimpiarCampos()
        {
            dgvClientes.ClearSelection();
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            if (cmbTipoCliente.Items.Count > 0) cmbTipoCliente.SelectedIndex = 0;
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
                TipoCliente tipo = (TipoCliente)cmbTipoCliente.SelectedItem;

                ControladorPersonas.Instancia.AgregarCliente(nombre, telefono, direccion, tipo);

                MessageBox.Show("Cliente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el cliente que desea modificar desde la grilla.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Nombre, Direccion y Telefono son obligatorios.");
                return;
            }

            try
            {
                var clienteOriginal = (Cliente)dgvClientes.SelectedRows[0].DataBoundItem;
                int idParaModificar = clienteOriginal.PersonaId;

                string nombre = txtNombre.Text;
                string direccion = txtDireccion.Text;
                string telefono = txtTelefono.Text;
                TipoCliente tipo = (TipoCliente)cmbTipoCliente.SelectedItem;

                var clienteModificado = new Cliente
                {
                    PersonaId = idParaModificar,
                    Nombre = nombre,
                    Telefono = telefono,
                    Direccion = direccion,
                    Tipo = tipo
                };

                ControladorPersonas.Instancia.ModificarCliente(clienteModificado);

                MessageBox.Show("Cliente modificado correctamente.");
                LimpiarCampos();
                ActualizarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                var cliente = (Cliente)dgvClientes.SelectedRows[0].DataBoundItem;

                txtNombre.Text = cliente.Nombre;
                txtTelefono.Text = cliente.Telefono;
                txtDireccion.Text = cliente.Direccion;
            }
        }

    }
}
