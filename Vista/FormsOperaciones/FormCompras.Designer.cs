namespace Vista.FormsOperaciones
{
    partial class FormCompras
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
            gbDatosIngreso = new GroupBox();
            btnIniciar = new Button();
            lblFechaIngreso = new Label();
            lblSucursal = new Label();
            lblProveedor = new Label();
            cmbSucursal = new ComboBox();
            cmbProveedor = new ComboBox();
            btnCancelar = new Button();
            gbDatosProducto = new GroupBox();
            chkVencimiento = new CheckBox();
            btnLimpiarProducto = new Button();
            lblCosto = new Label();
            lblCantidad = new Label();
            lblProducto = new Label();
            btnAgregar = new Button();
            dtpVencimiento = new DateTimePicker();
            txtCosto = new TextBox();
            txtCantidad = new TextBox();
            cmbProducto = new ComboBox();
            btnComprar = new Button();
            btnQuitar = new Button();
            btnVaciar = new Button();
            gbCarrito = new GroupBox();
            dgvCarrito = new DataGridView();
            gbDatosIngreso.SuspendLayout();
            gbDatosProducto.SuspendLayout();
            gbCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // gbDatosIngreso
            // 
            gbDatosIngreso.Controls.Add(btnIniciar);
            gbDatosIngreso.Controls.Add(lblFechaIngreso);
            gbDatosIngreso.Controls.Add(lblSucursal);
            gbDatosIngreso.Controls.Add(lblProveedor);
            gbDatosIngreso.Controls.Add(cmbSucursal);
            gbDatosIngreso.Controls.Add(cmbProveedor);
            gbDatosIngreso.Location = new Point(12, 12);
            gbDatosIngreso.Name = "gbDatosIngreso";
            gbDatosIngreso.Size = new Size(386, 267);
            gbDatosIngreso.TabIndex = 0;
            gbDatosIngreso.TabStop = false;
            gbDatosIngreso.Text = "Datos del Ingreso";
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(121, 190);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(128, 47);
            btnIniciar.TabIndex = 12;
            btnIniciar.Text = "Iniciar Compra";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Location = new Point(27, 144);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(63, 20);
            lblFechaIngreso.TabIndex = 4;
            lblFechaIngreso.Text = "Fecha: ...";
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
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(27, 44);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(77, 20);
            lblProveedor.TabIndex = 2;
            lblProveedor.Text = "Proveedor";
            // 
            // cmbSucursal
            // 
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.Location = new Point(143, 91);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Size = new Size(216, 28);
            cmbSucursal.TabIndex = 1;
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(143, 41);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(216, 28);
            cmbProveedor.TabIndex = 0;
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
            // gbDatosProducto
            // 
            gbDatosProducto.Controls.Add(chkVencimiento);
            gbDatosProducto.Controls.Add(btnLimpiarProducto);
            gbDatosProducto.Controls.Add(lblCosto);
            gbDatosProducto.Controls.Add(lblCantidad);
            gbDatosProducto.Controls.Add(lblProducto);
            gbDatosProducto.Controls.Add(btnAgregar);
            gbDatosProducto.Controls.Add(dtpVencimiento);
            gbDatosProducto.Controls.Add(txtCosto);
            gbDatosProducto.Controls.Add(txtCantidad);
            gbDatosProducto.Controls.Add(cmbProducto);
            gbDatosProducto.Enabled = false;
            gbDatosProducto.Location = new Point(12, 285);
            gbDatosProducto.Name = "gbDatosProducto";
            gbDatosProducto.Size = new Size(386, 379);
            gbDatosProducto.TabIndex = 1;
            gbDatosProducto.TabStop = false;
            gbDatosProducto.Text = "Datos del Producto";
            // 
            // chkVencimiento
            // 
            chkVencimiento.AutoSize = true;
            chkVencimiento.Location = new Point(27, 208);
            chkVencimiento.Name = "chkVencimiento";
            chkVencimiento.Size = new Size(167, 24);
            chkVencimiento.TabIndex = 12;
            chkVencimiento.Text = "¿Tiene Vencimiento?";
            chkVencimiento.UseVisualStyleBackColor = true;
            chkVencimiento.CheckedChanged += chkVencimiento_CheckedChanged;
            // 
            // btnLimpiarProducto
            // 
            btnLimpiarProducto.Location = new Point(210, 292);
            btnLimpiarProducto.Name = "btnLimpiarProducto";
            btnLimpiarProducto.Size = new Size(127, 56);
            btnLimpiarProducto.TabIndex = 11;
            btnLimpiarProducto.Text = "Limpiar Datos";
            btnLimpiarProducto.UseVisualStyleBackColor = true;
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(27, 159);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(47, 20);
            lblCosto.TabIndex = 9;
            lblCosto.Text = "Costo";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(27, 103);
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
            btnAgregar.Location = new Point(51, 292);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(127, 56);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar al Carrito";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.Enabled = false;
            dtpVencimiento.Location = new Point(27, 238);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(332, 27);
            dtpVencimiento.TabIndex = 6;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(143, 156);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(216, 27);
            txtCosto.TabIndex = 5;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(143, 100);
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
            // 
            // btnComprar
            // 
            btnComprar.Location = new Point(40, 565);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(127, 56);
            btnComprar.TabIndex = 13;
            btnComprar.Text = "Ir a Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
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
            // gbCarrito
            // 
            gbCarrito.Controls.Add(dgvCarrito);
            gbCarrito.Controls.Add(btnCancelar);
            gbCarrito.Controls.Add(btnVaciar);
            gbCarrito.Controls.Add(btnQuitar);
            gbCarrito.Controls.Add(btnComprar);
            gbCarrito.Location = new Point(414, 12);
            gbCarrito.Name = "gbCarrito";
            gbCarrito.Size = new Size(686, 652);
            gbCarrito.TabIndex = 16;
            gbCarrito.TabStop = false;
            gbCarrito.Text = "Carrito de Compras";
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
            // FormCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 694);
            Controls.Add(gbCarrito);
            Controls.Add(gbDatosProducto);
            Controls.Add(gbDatosIngreso);
            Name = "FormCompras";
            Text = "Registrar Ingreso";
            WindowState = FormWindowState.Maximized;
            Load += FormCompras_Load;
            gbDatosIngreso.ResumeLayout(false);
            gbDatosIngreso.PerformLayout();
            gbDatosProducto.ResumeLayout(false);
            gbDatosProducto.PerformLayout();
            gbCarrito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDatosIngreso;
        private ComboBox cmbSucursal;
        private ComboBox cmbProveedor;
        private Label lblProveedor;
        private GroupBox gbDatosProducto;
        private Button btnAgregar;
        private DateTimePicker dtpVencimiento;
        private TextBox txtCosto;
        private TextBox txtCantidad;
        private ComboBox cmbProducto;
        private Label lblFechaIngreso;
        private Label lblSucursal;
        private Label lblCosto;
        private Label lblCantidad;
        private Label lblProducto;
        private Button btnLimpiarProducto;
        private Button btnIniciar;
        private CheckBox chkVencimiento;
        private Button btnCancelar;
        private Button btnComprar;
        private Button btnQuitar;
        private Button btnVaciar;
        private GroupBox gbCarrito;
        private DataGridView dgvCarrito;
    }
}