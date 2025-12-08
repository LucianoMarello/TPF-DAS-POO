namespace Vista.FormsGestion
{
    partial class FormProductos
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
            gbDatosProducto = new GroupBox();
            btnCopiar = new Button();
            btnLimpiar = new Button();
            txtStockMin = new TextBox();
            txtCosto = new TextBox();
            btnEliminar = new Button();
            txtDescripcion = new TextBox();
            btnGuardar = new Button();
            lblRubros = new Label();
            btnModificar = new Button();
            lblStockMin = new Label();
            lblCosto = new Label();
            lblDescripcion = new Label();
            cmbRubro = new ComboBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            dgvProductos = new DataGridView();
            lblListaProductos = new Label();
            gbDatosProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // gbDatosProducto
            // 
            gbDatosProducto.Controls.Add(btnCopiar);
            gbDatosProducto.Controls.Add(btnLimpiar);
            gbDatosProducto.Controls.Add(txtStockMin);
            gbDatosProducto.Controls.Add(txtCosto);
            gbDatosProducto.Controls.Add(btnEliminar);
            gbDatosProducto.Controls.Add(txtDescripcion);
            gbDatosProducto.Controls.Add(btnGuardar);
            gbDatosProducto.Controls.Add(lblRubros);
            gbDatosProducto.Controls.Add(btnModificar);
            gbDatosProducto.Controls.Add(lblStockMin);
            gbDatosProducto.Controls.Add(lblCosto);
            gbDatosProducto.Controls.Add(lblDescripcion);
            gbDatosProducto.Controls.Add(cmbRubro);
            gbDatosProducto.Controls.Add(lblNombre);
            gbDatosProducto.Controls.Add(txtNombre);
            gbDatosProducto.Location = new Point(12, 12);
            gbDatosProducto.Name = "gbDatosProducto";
            gbDatosProducto.Size = new Size(415, 630);
            gbDatosProducto.TabIndex = 0;
            gbDatosProducto.TabStop = false;
            gbDatosProducto.Text = "Datos del Producto";
            // 
            // btnCopiar
            // 
            btnCopiar.Location = new Point(230, 533);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(112, 36);
            btnCopiar.TabIndex = 12;
            btnCopiar.Text = "Copiar";
            btnCopiar.UseVisualStyleBackColor = true;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(230, 575);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 36);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtStockMin
            // 
            txtStockMin.Location = new Point(199, 378);
            txtStockMin.Name = "txtStockMin";
            txtStockMin.Size = new Size(183, 27);
            txtStockMin.TabIndex = 9;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(150, 267);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(232, 27);
            txtCosto.TabIndex = 8;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(230, 454);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 50);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(150, 90);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(232, 149);
            txtDescripcion.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(55, 454);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 50);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblRubros
            // 
            lblRubros.AutoSize = true;
            lblRubros.Location = new Point(23, 326);
            lblRubros.Name = "lblRubros";
            lblRubros.Size = new Size(49, 20);
            lblRubros.TabIndex = 6;
            lblRubros.Text = "Rubro";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(55, 533);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 50);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // lblStockMin
            // 
            lblStockMin.AutoSize = true;
            lblStockMin.Location = new Point(23, 381);
            lblStockMin.Name = "lblStockMin";
            lblStockMin.Size = new Size(144, 20);
            lblStockMin.TabIndex = 5;
            lblStockMin.Text = "Stock Mínimo Alerta";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(23, 270);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(69, 20);
            lblCosto.TabIndex = 4;
            lblCosto.Text = "Costo ($)";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(23, 93);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripción";
            // 
            // cmbRubro
            // 
            cmbRubro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRubro.FormattingEnabled = true;
            cmbRubro.Location = new Point(150, 323);
            cmbRubro.Name = "cmbRubro";
            cmbRubro.Size = new Size(232, 28);
            cmbRubro.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(23, 43);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(232, 27);
            txtNombre.TabIndex = 0;
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(445, 35);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(842, 607);
            dgvProductos.TabIndex = 1;
            // 
            // lblListaProductos
            // 
            lblListaProductos.AutoSize = true;
            lblListaProductos.Location = new Point(445, 12);
            lblListaProductos.Name = "lblListaProductos";
            lblListaProductos.Size = new Size(130, 20);
            lblListaProductos.TabIndex = 12;
            lblListaProductos.Text = "Lista de Productos";
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1376, 681);
            Controls.Add(lblListaProductos);
            Controls.Add(dgvProductos);
            Controls.Add(gbDatosProducto);
            Name = "FormProductos";
            Text = "Productos";
            WindowState = FormWindowState.Maximized;
            Load += FormProductos_Load;
            gbDatosProducto.ResumeLayout(false);
            gbDatosProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbDatosProducto;
        private Button btnGuardar;
        private ComboBox cmbRubro;
        private Label lblNombre;
        private TextBox txtNombre;
        private DataGridView dgvProductos;
        private TextBox txtStockMin;
        private TextBox txtCosto;
        private TextBox txtDescripcion;
        private Label lblRubros;
        private Label lblStockMin;
        private Label lblCosto;
        private Label lblDescripcion;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnModificar;
        private Label lblListaProductos;
        private Button btnCopiar;
    }
}