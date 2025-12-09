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
    public partial class FormAlertas : Form
    {
        public FormAlertas()
        {
            InitializeComponent();
        }

        private void FormAlertas_Load(object sender, EventArgs e)
        {
            ActualizarAlertas();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ActualizarAlertas();
        }

        private void ActualizarAlertas()
        {
            dgvAlertas.DataSource = null;
            // Trae lotes vencidos O que vencen en la próxima semana
            dgvAlertas.DataSource = ControladorProducto.Instancia.ObtenerAlertasVencimiento();

            ConfigurarGrilla();
        }

        private void ConfigurarGrilla()
        {
            if (dgvAlertas.Columns["SucursalId"] != null) dgvAlertas.Columns["SucursalId"].Visible = false;
            if (dgvAlertas.Columns["Producto"] != null) dgvAlertas.Columns["Producto"].Visible = false;
            if (dgvAlertas.Columns["Sucursal"] != null) dgvAlertas.Columns["Sucursal"].Visible = false;

            if (dgvAlertas.Columns["FechaVencimiento"] != null)
                dgvAlertas.Columns["FechaVencimiento"].DisplayIndex = 0;

            if (dgvAlertas.Columns["CantidadActual"] != null)
                dgvAlertas.Columns["CantidadActual"].HeaderText = "Stock Restante";
        }

        private void dgvAlertas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAlertas.Columns[e.ColumnIndex].Name == "Producto")
            {
                var lote = (Lote)dgvAlertas.Rows[e.RowIndex].DataBoundItem;
                if (lote.Producto != null) e.Value = lote.Producto.Nombre;
            }

            if (dgvAlertas.Columns[e.ColumnIndex].Name == "Sucursal")
            {
                var lote = (Lote)dgvAlertas.Rows[e.RowIndex].DataBoundItem;
                if (lote.Sucursal != null) e.Value = lote.Sucursal.Nombre;
            }

            // Pintar toda la fila en base a la fecha
            var row = dgvAlertas.Rows[e.RowIndex];
            var loteActual = (Lote)row.DataBoundItem;

            if (loteActual != null)
            {
                // Rojo
                if (loteActual.FechaVencimiento.Date < DateTime.Today)
                {
                    row.DefaultCellStyle.BackColor = Color.Salmon;
                    row.DefaultCellStyle.ForeColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
                }
                // Amarillo
                else if (loteActual.FechaVencimiento.Date <= DateTime.Today.AddDays(7))
                {
                    row.DefaultCellStyle.BackColor = Color.LightYellow;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.DefaultCellStyle.SelectionBackColor = Color.Gold;
                }
            }
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            if (dgvAlertas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un lote para dar de baja.");
                return;
            }

            var lote = (Lote)dgvAlertas.SelectedRows[0].DataBoundItem;

            // Pregunta de seguridad
            var confirmacion = MessageBox.Show(
                $"¿Confirmar baja por vencimiento del producto?\n" +
                $"Stock a eliminar: {lote.CantidadActual}\n" +
                $"Vencimiento: {lote.FechaVencimiento.ToShortDateString()}",
                "Confirmar Baja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    ControladorProducto.Instancia.RegistrarVencimiento(lote.LoteId);

                    MessageBox.Show("Stock dado de baja correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarAlertas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al dar de baja: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
