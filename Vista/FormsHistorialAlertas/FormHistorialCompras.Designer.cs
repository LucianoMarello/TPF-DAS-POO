namespace Vista.FormsHistorialAlertas
{
    partial class FormHistorialCompras
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
            gbFiltros = new GroupBox();
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
            dgvIngresos = new DataGridView();
            dgvDetalles = new DataGridView();
            lblIngresos = new Label();
            lblDetalleCompra = new Label();
            gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            SuspendLayout();
            // 
            // gbFiltros
            // 
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
            gbFiltros.TabIndex = 0;
            gbFiltros.TabStop = false;
            gbFiltros.Text = "Filtros de Búsqueda";
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
            btnLimpiar.Location = new Point(177, 368);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(115, 47);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Ver Todo";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(39, 368);
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
            // dgvIngresos
            // 
            dgvIngresos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngresos.Location = new Point(360, 35);
            dgvIngresos.MultiSelect = false;
            dgvIngresos.Name = "dgvIngresos";
            dgvIngresos.ReadOnly = true;
            dgvIngresos.RowHeadersWidth = 51;
            dgvIngresos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIngresos.Size = new Size(618, 328);
            dgvIngresos.TabIndex = 15;
            dgvIngresos.SelectionChanged += dgvIngresos_SelectionChanged;
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
            dgvDetalles.TabIndex = 16;
            // 
            // lblIngresos
            // 
            lblIngresos.AutoSize = true;
            lblIngresos.Location = new Point(360, 12);
            lblIngresos.Name = "lblIngresos";
            lblIngresos.Size = new Size(176, 20);
            lblIngresos.TabIndex = 6;
            lblIngresos.Text = "COMPRAS REGISTRADAS";
            // 
            // lblDetalleCompra
            // 
            lblDetalleCompra.AutoSize = true;
            lblDetalleCompra.Location = new Point(360, 393);
            lblDetalleCompra.Name = "lblDetalleCompra";
            lblDetalleCompra.Size = new Size(285, 20);
            lblDetalleCompra.TabIndex = 17;
            lblDetalleCompra.Text = "DETALLE DE LA COMPRA SELECCIONADA";
            // 
            // FormHistorialCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 681);
            Controls.Add(lblDetalleCompra);
            Controls.Add(lblIngresos);
            Controls.Add(dgvDetalles);
            Controls.Add(dgvIngresos);
            Controls.Add(gbFiltros);
            Name = "FormHistorialCompras";
            Text = "Historial de Compras";
            WindowState = FormWindowState.Maximized;
            Load += FormHistorialCompras_Load;
            gbFiltros.ResumeLayout(false);
            gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbFiltros;
        private Button btnLimpiar;
        private Button btnFiltrar;
        private DateTimePicker dtpFin;
        private DateTimePicker dtpInicio;
        private DataGridView dgvIngresos;
        private DataGridView dgvDetalles;
        private Label lblFin;
        private Label lblInicio;
        private Label lblIngresos;
        private Label lblDetalleCompra;
        private Label lblProducto;
        private Label lblSucursal;
        private ComboBox cmbFiltroProducto;
        private ComboBox cmbFiltroSucursal;
    }
}