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
    public partial class FormConfirmarCompra : Form
    {
        private List<ItemCompraDTO> _items;
        private int _proveedorId;
        private int _sucursalId;

        public FormConfirmarCompra(List<ItemCompraDTO> items, int idProv, string nomProv, int idSuc, string nomSuc)
        {
            InitializeComponent();

            _items = items;
            _proveedorId = idProv;
            _sucursalId = idSuc;

            lblProveedor.Text = "Proveedor: " + nomProv;
            lblSucursal.Text = "Destino: " + nomSuc;
        }

        private void FormConfirmarCompra_Load(object sender, EventArgs e)
        {
            ActualizarResumen();
        }

        private void ActualizarResumen()
        {
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = _items;

            if (dgvDetalle.Columns["ProductoId"] != null) dgvDetalle.Columns["ProductoId"].Visible = false;
            if (dgvDetalle.Columns["Costo"] != null) dgvDetalle.Columns["Costo"].DefaultCellStyle.Format = "C2";

            decimal total = _items.Sum(x => x.Cantidad * x.Costo);
            lblTotal.Text = $"TOTAL A PAGAR: {total:C2}";
        }

        private void btnConfirmarFinal_Click(object sender, EventArgs e)
        {
            try
            {
                ControladorCompra.Instancia.RegistrarCompra(_proveedorId, _sucursalId, _items);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la compra: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
