namespace Vista.FormsHistorialAlertas
{
    partial class FormHistorialVentas
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
            lblDetalleVenta = new Label();
            lblVentas = new Label();
            dgvDetalles = new DataGridView();
            dgvVentas = new DataGridView();
            gbFiltros = new GroupBox();
            lblCliente = new Label();
            cmbFiltroCliente = new ComboBox();
            lblProducto = new Label();
            lblSucursal = new Label();
            cmbFiltroProducto = new ComboBox();
            cmbFiltroSucursal = new ComboBox();
            lblFin = new Label();
            lblInicio = new Label();
            btnLimpiar = new Button();
            btnFiltrar = new Button();
            dtpFin = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            gbFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // lblDetalleVenta
            // 
            lblDetalleVenta.AutoSize = true;
            lblDetalleVenta.Location = new Point(360, 393);
            lblDetalleVenta.Name = "lblDetalleVenta";
            lblDetalleVenta.Size = new Size(270, 20);
            lblDetalleVenta.TabIndex = 22;
            lblDetalleVenta.Text = "DETALLE DE LA VENTA SELECCIONADA";
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.Location = new Point(360, 12);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(152, 20);
            lblVentas.TabIndex = 19;
            lblVentas.Text = "VENTAS REALIZADAS";
            // 
            // dgvDetalles
            // 
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Location = new Point(360, 416);
            dgvDetalles.MultiSelect = false;
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.ReadOnly = true;
            dgvDetalles.RowHeadersWidth = 51;
            dgvDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalles.Size = new Size(630, 253);
            dgvDetalles.TabIndex = 21;
            // 
            // dgvVentas
            // 
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(360, 35);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(618, 328);
            dgvVentas.TabIndex = 20;
            dgvVentas.SelectionChanged += dgvVentas_SelectionChanged;
            // 
            // gbFiltros
            // 
            gbFiltros.Controls.Add(lblCliente);
            gbFiltros.Controls.Add(cmbFiltroCliente);
            gbFiltros.Controls.Add(lblProducto);
            gbFiltros.Controls.Add(lblSucursal);
            gbFiltros.Controls.Add(cmbFiltroProducto);
            gbFiltros.Controls.Add(cmbFiltroSucursal);
            gbFiltros.Controls.Add(lblFin);
            gbFiltros.Controls.Add(lblInicio);
            gbFiltros.Controls.Add(btnLimpiar);
            gbFiltros.Controls.Add(btnFiltrar);
            gbFiltros.Controls.Add(dtpFin);
            gbFiltros.Controls.Add(dtpInicio);
            gbFiltros.Location = new Point(12, 12);
            gbFiltros.Name = "gbFiltros";
            gbFiltros.Size = new Size(322, 657);
            gbFiltros.TabIndex = 18;
            gbFiltros.TabStop = false;
            gbFiltros.Text = "Filtros de Búsqueda";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(23, 346);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(55, 20);
            lblCliente.TabIndex = 11;
            lblCliente.Text = "Cliente";
            // 
            // cmbFiltroCliente
            // 
            cmbFiltroCliente.FormattingEnabled = true;
            cmbFiltroCliente.Location = new Point(23, 369);
            cmbFiltroCliente.Name = "cmbFiltroCliente";
            cmbFiltroCliente.Size = new Size(269, 28);
            cmbFiltroCliente.TabIndex = 10;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(23, 265);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(69, 20);
            lblProducto.TabIndex = 9;
            lblProducto.Text = "Producto";
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Location = new Point(23, 188);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(63, 20);
            lblSucursal.TabIndex = 8;
            lblSucursal.Text = "Sucursal";
            // 
            // cmbFiltroProducto
            // 
            cmbFiltroProducto.FormattingEnabled = true;
            cmbFiltroProducto.Location = new Point(23, 288);
            cmbFiltroProducto.Name = "cmbFiltroProducto";
            cmbFiltroProducto.Size = new Size(269, 28);
            cmbFiltroProducto.TabIndex = 7;
            // 
            // cmbFiltroSucursal
            // 
            cmbFiltroSucursal.FormattingEnabled = true;
            cmbFiltroSucursal.Location = new Point(23, 211);
            cmbFiltroSucursal.Name = "cmbFiltroSucursal";
            cmbFiltroSucursal.Size = new Size(269, 28);
            cmbFiltroSucursal.TabIndex = 6;
            // 
            // lblFin
            // 
            lblFin.AutoSize = true;
            lblFin.Location = new Point(23, 112);
            lblFin.Name = "lblFin";
            lblFin.Size = new Size(47, 20);
            lblFin.TabIndex = 5;
            lblFin.Text = "Hasta";
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Location = new Point(23, 43);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(51, 20);
            lblInicio.TabIndex = 4;
            lblInicio.Text = "Desde";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(177, 426);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(115, 47);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Ver Todo";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(39, 426);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(115, 47);
            btnFiltrar.TabIndex = 2;
            btnFiltrar.Text = "Buscar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // dtpFin
            // 
            dtpFin.Location = new Point(23, 135);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(269, 27);
            dtpFin.TabIndex = 1;
            // 
            // dtpInicio
            // 
            dtpInicio.Location = new Point(23, 66);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(269, 27);
            dtpInicio.TabIndex = 0;
            // 
            // FormHistorialVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 705);
            Controls.Add(lblDetalleVenta);
            Controls.Add(lblVentas);
            Controls.Add(dgvDetalles);
            Controls.Add(dgvVentas);
            Controls.Add(gbFiltros);
            Name = "FormHistorialVentas";
            Text = "Historial de Ventas";
            WindowState = FormWindowState.Maximized;
            Load += FormHistorialVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            gbFiltros.ResumeLayout(false);
            gbFiltros.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDetalleVenta;
        private Label lblVentas;
        private DataGridView dgvDetalles;
        private DataGridView dgvVentas;
        private GroupBox gbFiltros;
        private Label lblProducto;
        private Label lblSucursal;
        private ComboBox cmbFiltroProducto;
        private ComboBox cmbFiltroSucursal;
        private Label lblFin;
        private Label lblInicio;
        private Button btnLimpiar;
        private Button btnFiltrar;
        private DateTimePicker dtpFin;
        private DateTimePicker dtpInicio;
        private Label lblCliente;
        private ComboBox cmbFiltroCliente;
    }
}