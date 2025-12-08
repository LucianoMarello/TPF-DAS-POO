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
    public partial class FormRubros : Form
    {
        public FormRubros()
        {
            InitializeComponent();
        }

        private void FormRubros_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            dgvRubros.DataSource = null;
            dgvRubros.DataSource = ControladorProducto.Instancia.ObtenerRubros();
        }

        private void LimpiarCampos()
        {
            dgvRubros.ClearSelection();
            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Debe completar Nombre y Descripcion.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string nombre = txtNombre.Text;
                string desc = txtDescripcion.Text;

                ControladorProducto.Instancia.AgregarRubro(nombre, desc);

                MessageBox.Show("Rubro guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dgvRubros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el rubro que desea modificar desde la grilla.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Nombre y Descripcion son obligatorios.");
                return;
            }

            try
            {
                var rubroOriginal = (Rubro)dgvRubros.SelectedRows[0].DataBoundItem;
                int idParaModificar = rubroOriginal.RubroId;

                string nombre = txtNombre.Text;
                string desc = txtDescripcion.Text;

                var rubroModificado = new Rubro
                {
                    RubroId = idParaModificar,
                    Nombre = nombre,
                    Descripcion = desc,
                };

                ControladorProducto.Instancia.ModificarRubro(rubroModificado);

                MessageBox.Show("Rubro modificado correctamente.");
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
            if (dgvRubros.SelectedRows.Count > 0)
            {
                var rubro = (Rubro)dgvRubros.SelectedRows[0].DataBoundItem;

                var confirmacion = MessageBox.Show($"¿Seguro que desea eliminar '{rubro.Nombre}'?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        ControladorProducto.Instancia.EliminarRubro(rubro.RubroId);
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
                MessageBox.Show("Seleccione un rubro de la lista.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (dgvRubros.SelectedRows.Count > 0)
            {
                var rubro = (Rubro)dgvRubros.SelectedRows[0].DataBoundItem;

                txtNombre.Text = rubro.Nombre;
                txtDescripcion.Text = rubro.Descripcion;
            }
        }

    }
}
