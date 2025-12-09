namespace Vista.FormsOperaciones
{
    partial class FormVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbCarrito = new GroupBox();
            dgvCarrito = new DataGridView();
            btnCancelar = new Button();
            btnVaciar = new Button();
            btnQuitar = new Button();
            btnConfirmar = new Button();
            gbDatosProducto = new GroupBox();
            lblStock = new Label();
            lblPrecio = new Label();
            lblCantidad = new Label();
            lblProducto = new Label();
            btnAgregar = new Button();
            txtCantidad = new TextBox();
            cmbProducto = new ComboBox();
            gbDatosVenta = new GroupBox();
            lblMetodoPago = new Label();
            cmbMetodoPago = new ComboBox();
            btnIniciar = new Button();
            lblFechaVenta = new Label();
            lblSucursal = new Label();
            lblCliente = new Label();
            cmbSucursal = new ComboBox();
            cmbCliente = new ComboBox();
            gbCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            gbDatosProducto.SuspendLayout();
            gbDatosVenta.SuspendLayout();
            SuspendLayout();
            // 
            // gbCarrito
            // 
            gbCarrito.Controls.Add(dgvCarrito);
            gbCarrito.Controls.Add(btnCancelar);
            gbCarrito.Controls.Add(btnVaciar);
            gbCarrito.Controls.Add(btnQuitar);
            gbCarrito.Controls.Add(btnConfirmar);
            gbCarrito.Location = new Point(414, 12);
            gbCarrito.Name = "gbCarrito";
            gbCarrito.Size = new Size(686, 652);
            gbCarrito.TabIndex = 19;
            gbCarrito.TabStop = false;
            gbCarrito.Text = "Carrito";
            // 
            // dgvCarrito
            // 
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(6, 26);
            dgvCarrito.MultiSelect = false;
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.ReadOnly = true;
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.Size = new Size(674, 512);
            dgvCarrito.TabIndex = 16;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(521, 565);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 56);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar Carga";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnVaciar
            // 
            btnVaciar.Location = new Point(362, 565);
            btnVaciar.Name = "btnVaciar";
            btnVaciar.Size = new Size(127, 56);
            btnVaciar.TabIndex = 15;
            btnVaciar.Text = "Vaciar Carrito";
            btnVaciar.UseVisualStyleBackColor = true;
            btnVaciar.Click += btnVaciar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(199, 565);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(127, 56);
            btnQuitar.TabIndex = 14;
            btnQuitar.Text = "Quitar Producto";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(40, 565);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(127, 56);
            btnConfirmar.TabIndex = 13;
            btnConfirmar.Text = "Confirmar Venta";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // gbDatosProducto
            // 
            gbDatosProducto.Controls.Add(lblStock);
            gbDatosProducto.Controls.Add(lblPrecio);
            gbDatosProducto.Controls.Add(lblCantidad);
            gbDatosProducto.Controls.Add(lblProducto);
            gbDatosProducto.Controls.Add(btnAgregar);
            gbDatosProducto.Controls.Add(txtCantidad);
            gbDatosProducto.Controls.Add(cmbProducto);
            gbDatosProducto.Enabled = false;
            gbDatosProducto.Location = new Point(12, 319);
            gbDatosProducto.Name = "gbDatosProducto";
            gbDatosProducto.Size = new Size(386, 345);
            gbDatosProducto.TabIndex = 18;
            gbDatosProducto.TabStop = false;
            gbDatosProducto.Text = "Datos del Producto";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(27, 140);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(95, 20);
            lblStock.TabIndex = 13;
            lblStock.Text = "Stock Disp: ...";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(27, 94);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(66, 20);
            lblPrecio.TabIndex = 9;
            lblPrecio.Text = "Precio: ...";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(27, 196);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(69, 20);
            lblCantidad.TabIndex = 8;
            lblCantidad.Text = "Cantidad";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(27, 49);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(69, 20);
            lblProducto.TabIndex = 5;
            lblProducto.Text = "Producto";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(124, 258);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(128, 56);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar al Carrito";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(143, 193);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(216, 27);
            txtCantidad.TabIndex = 4;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(143, 46);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(216, 28);
            cmbProducto.TabIndex = 3;
            cmbProducto.SelectionChangeCommitted += cmbProducto_SelectionChangeCommitted;
            // 
            // gbDatosVenta
            // 
            gbDatosVenta.Controls.Add(lblMetodoPago);
            gbDatosVenta.Controls.Add(cmbMetodoPago);
            gbDatosVenta.Controls.Add(btnIniciar);
            gbDatosVenta.Controls.Add(lblFechaVenta);
            gbDatosVenta.Controls.Add(lblSucursal);
            gbDatosVenta.Controls.Add(lblCliente);
            gbDatosVenta.Controls.Add(cmbSucursal);
            gbDatosVenta.Controls.Add(cmbCliente);
            gbDatosVenta.Location = new Point(12, 12);
            gbDatosVenta.Name = "gbDatosVenta";
            gbDatosVenta.Size = new Size(386, 301);
            gbDatosVenta.TabIndex = 17;
            gbDatosVenta.TabStop = false;
            gbDatosVenta.Text = "Datos de la Venta";
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Location = new Point(27, 147);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(120, 20);
            lblMetodoPago.TabIndex = 14;
            lblMetodoPago.Text = "Metodo de Pago";
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Location = new Point(153, 144);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(206, 28);
            cmbMetodoPago.TabIndex = 13;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(124, 224);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(128, 47);
            btnIniciar.TabIndex = 12;
            btnIniciar.Text = "Iniciar Venta";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // lblFechaVenta
            // 
            lblFechaVenta.AutoSize = true;
            lblFechaVenta.Location = new Point(27, 191);
            lblFechaVenta.Name = "lblFechaVenta";
            lblFechaVenta.Size = new Size(63, 20);
            lblFechaVenta.TabIndex = 4;
            lblFechaVenta.Text = "Fecha: ...";
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Location = new Point(27, 94);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(63, 20);
            lblSucursal.TabIndex = 3;
            lblSucursal.Text = "Sucursal";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(27, 44);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(55, 20);
            lblCliente.TabIndex = 2;
            lblCliente.Text = "Cliente";
            // 
            // cmbSucursal
            // 
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.Location = new Point(153, 91);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Size = new Size(206, 28);
            cmbSucursal.TabIndex = 1;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(153, 41);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(206, 28);
            cmbCliente.TabIndex = 0;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 695);
            Controls.Add(gbCarrito);
            Controls.Add(gbDatosProducto);
            Controls.Add(gbDatosVenta);
            Name = "FormVentas";
            Text = "Realizar Venta";
            WindowState = FormWindowState.Maximized;
            Load += FormVentas_Load;
            gbCarrito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            gbDatosProducto.ResumeLayout(false);
            gbDatosProducto.PerformLayout();
            gbDatosVenta.ResumeLayout(false);
            gbDatosVenta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbCarrito;
        private DataGridView dgvCarrito;
        private Button btnCancelar;
        private Button btnQuitar;
        private Button btnConfirmar;
        private GroupBox gbDatosProducto;
        private Label lblPrecio;
        private Label lblCantidad;
        private Label lblProducto;
        private Button btnAgregar;
        private TextBox txtCantidad;
        private ComboBox cmbProducto;
        private GroupBox gbDatosVenta;
        private Label lblMetodoPago;
        private ComboBox cmbMetodoPago;
        private Button btnIniciar;
        private Label lblFechaVenta;
        private Label lblSucursal;
        private Label lblCliente;
        private ComboBox cmbSucursal;
        private ComboBox cmbCliente;
        private Label lblStock;
        private Button btnVaciar;
    }
}