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
    public partial class FormConfirmarVenta : Form
    {
        private List<ItemVentaDTO> _items;
        private int _clienteId;
        private int _sucursalId;
        private MetodoPago _metodoPago;

        public FormConfirmarVenta(List<ItemVentaDTO> items, string nomCli, int idCli, string nomSuc, int idSuc, MetodoPago pago)
        {
            InitializeComponent();

            _items = items;
            _clienteId = idCli;
            _sucursalId = idSuc;
            _metodoPago = pago;

            lblCliente.Text = "Cliente: " + nomCli;
            lblSucursal.Text = "Sucursal: " + nomSuc;
            lblPago.Text = "Pago: " + pago.ToString();
        }

        private void FormConfirmarVenta_Load(object sender, EventArgs e)
        {
            CalculoVisual();
        }

        private void CalculoVisual()
        {
            decimal totalBruto = 0;

            var listaVisual = new List<object>();

            foreach (var item in _items)
            {
                var prod = ControladorProducto.Instancia.ObtenerProductoPorId(item.ProductoId);
                decimal subtotal = prod.Precio * item.Cantidad;
                totalBruto += subtotal;

                listaVisual.Add(new
                {
                    Producto = prod.Nombre,
                    Cantidad = item.Cantidad,
                    Precio = prod.Precio,
                    Subtotal = subtotal
                });
            }

            dgvDetalle.DataSource = listaVisual;

            // Formato
            if (dgvDetalle.Columns["Precio"] != null) dgvDetalle.Columns["Precio"].DefaultCellStyle.Format = "C2";
            if (dgvDetalle.Columns["Subtotal"] != null) dgvDetalle.Columns["Subtotal"].DefaultCellStyle.Format = "C2";

            lblTotal.Text = $"Total Bruto: {totalBruto:C2} (Sujeto a descuentos)";
        }

        private void btnConfirmarFinal_Click(object sender, EventArgs e)
        {
            try
            {
                ControladorVenta.Instancia.CrearVenta(_clienteId, _sucursalId, _metodoPago, _items);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
