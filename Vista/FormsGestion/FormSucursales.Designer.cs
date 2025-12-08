namespace Vista.FormsGestion
{
    partial class FormSucursales
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
            lblListaProductos = new Label();
            dgvStock = new DataGridView();
            gbDatosSucursal = new GroupBox();
            lblListaSucursales = new Label();
            dgvSucursales = new DataGridView();
            txtDireccion = new TextBox();
            btnCopiar = new Button();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            btnModificar = new Button();
            lblDireccion = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            gbDatosSucursal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).BeginInit();
            SuspendLayout();
            // 
            // lblListaProductos
            // 
            lblListaProductos.AutoSize = true;
            lblListaProductos.Location = new Point(445, 12);
            lblListaProductos.Name = "lblListaProductos";
            lblListaProductos.Size = new Size(221, 20);
            lblListaProductos.TabIndex = 18;
            lblListaProductos.Text = "Stock de Productos en Sucursal: ";
            // 
            // dgvStock
            // 
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new Point(445, 35);
            dgvStock.MultiSelect = false;
            dgvStock.Name = "dgvStock";
            dgvStock.ReadOnly = true;
            dgvStock.RowHeadersWidth = 51;
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStock.Size = new Size(842, 607);
            dgvStock.TabIndex = 17;
            // 
            // gbDatosSucursal
            // 
            gbDatosSucursal.Controls.Add(lblListaSucursales);
            gbDatosSucursal.Controls.Add(dgvSucursales);
            gbDatosSucursal.Controls.Add(txtDireccion);
            gbDatosSucursal.Controls.Add(btnCopiar);
            gbDatosSucursal.Controls.Add(btnLimpiar);
            gbDatosSucursal.Controls.Add(btnGuardar);
            gbDatosSucursal.Controls.Add(btnModificar);
            gbDatosSucursal.Controls.Add(lblDireccion);
            gbDatosSucursal.Controls.Add(lblNombre);
            gbDatosSucursal.Controls.Add(txtNombre);
            gbDatosSucursal.Location = new Point(12, 12);
            gbDatosSucursal.Name = "gbDatosSucursal";
            gbDatosSucursal.Size = new Size(415, 630);
            gbDatosSucursal.TabIndex = 16;
            gbDatosSucursal.TabStop = false;
            gbDatosSucursal.Text = "Datos de la Sucursal";
            // 
            // lblListaSucursales
            // 
            lblListaSucursales.AutoSize = true;
            lblListaSucursales.Location = new Point(23, 301);
            lblListaSucursales.Name = "lblListaSucursales";
            lblListaSucursales.Size = new Size(132, 20);
            lblListaSucursales.TabIndex = 19;
            lblListaSucursales.Text = "Lista de Sucursales";
            // 
            // dgvSucursales
            // 
            dgvSucursales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSucursales.Location = new Point(0, 324);
            dgvSucursales.MultiSelect = false;
            dgvSucursales.Name = "dgvSucursales";
            dgvSucursales.ReadOnly = true;
            dgvSucursales.RowHeadersWidth = 51;
            dgvSucursales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSucursales.Size = new Size(415, 306);
            dgvSucursales.TabIndex = 19;
            dgvSucursales.CellClick += dgvSucursales_CellClick;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(150, 90);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(232, 27);
            txtDireccion.TabIndex = 14;
            // 
            // btnCopiar
            // 
            btnCopiar.Location = new Point(230, 147);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(114, 50);
            btnCopiar.TabIndex = 13;
            btnCopiar.Text = "Copiar";
            btnCopiar.UseVisualStyleBackColor = true;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(230, 216);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(114, 50);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(55, 147);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 50);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(55, 216);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 50);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(23, 93);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 3;
            lblDireccion.Text = "Dirección";
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
            // FormSucursales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 668);
            Controls.Add(lblListaProductos);
            Controls.Add(dgvStock);
            Controls.Add(gbDatosSucursal);
            Name = "FormSucursales";
            Text = "a";
            WindowState = FormWindowState.Maximized;
            Load += FormSucursales_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            gbDatosSucursal.ResumeLayout(false);
            gbDatosSucursal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblListaProductos;
        private DataGridView dgvStock;
        private GroupBox gbDatosSucursal;
        private Button btnCopiar;
        private Button btnLimpiar;
        private Button btnGuardar;
        private Button btnModificar;
        private Label lblDireccion;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private Label lblListaSucursales;
        private DataGridView dgvSucursales;
    }
}