namespace Vista.FormsGestion
{
    partial class FormClientes
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
            lblListaClientes = new Label();
            dgvClientes = new DataGridView();
            gbDatosCliente = new GroupBox();
            btnCopiar = new Button();
            btnLimpiar = new Button();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            btnGuardar = new Button();
            lblTipoCliente = new Label();
            btnModificar = new Button();
            lblDireccion = new Label();
            lblTelefono = new Label();
            cmbTipoCliente = new ComboBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            gbDatosCliente.SuspendLayout();
            SuspendLayout();
            // 
            // lblListaClientes
            // 
            lblListaClientes.AutoSize = true;
            lblListaClientes.Location = new Point(445, 12);
            lblListaClientes.Name = "lblListaClientes";
            lblListaClientes.Size = new Size(116, 20);
            lblListaClientes.TabIndex = 15;
            lblListaClientes.Text = "Lista de Clientes";
            // 
            // dgvClientes
            // 
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(445, 35);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(842, 607);
            dgvClientes.TabIndex = 14;
            // 
            // gbDatosCliente
            // 
            gbDatosCliente.Controls.Add(btnCopiar);
            gbDatosCliente.Controls.Add(btnLimpiar);
            gbDatosCliente.Controls.Add(txtTelefono);
            gbDatosCliente.Controls.Add(txtDireccion);
            gbDatosCliente.Controls.Add(btnGuardar);
            gbDatosCliente.Controls.Add(lblTipoCliente);
            gbDatosCliente.Controls.Add(btnModificar);
            gbDatosCliente.Controls.Add(lblDireccion);
            gbDatosCliente.Controls.Add(lblTelefono);
            gbDatosCliente.Controls.Add(cmbTipoCliente);
            gbDatosCliente.Controls.Add(lblNombre);
            gbDatosCliente.Controls.Add(txtNombre);
            gbDatosCliente.Location = new Point(12, 12);
            gbDatosCliente.Name = "gbDatosCliente";
            gbDatosCliente.Size = new Size(415, 630);
            gbDatosCliente.TabIndex = 13;
            gbDatosCliente.TabStop = false;
            gbDatosCliente.Text = "Datos del Cliente";
            // 
            // btnCopiar
            // 
            btnCopiar.Location = new Point(230, 454);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(112, 50);
            btnCopiar.TabIndex = 14;
            btnCopiar.Text = "Copiar";
            btnCopiar.UseVisualStyleBackColor = true;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(230, 533);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 50);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(150, 95);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(232, 27);
            txtTelefono.TabIndex = 9;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(150, 154);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(232, 27);
            txtDireccion.TabIndex = 8;
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
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Location = new Point(23, 217);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(89, 20);
            lblTipoCliente.TabIndex = 6;
            lblTipoCliente.Text = "Tipo Cliente";
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
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(23, 157);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "Direccion";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(23, 98);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Telefono";
            // 
            // cmbTipoCliente
            // 
            cmbTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoCliente.FormattingEnabled = true;
            cmbTipoCliente.Location = new Point(150, 214);
            cmbTipoCliente.Name = "cmbTipoCliente";
            cmbTipoCliente.Size = new Size(232, 28);
            cmbTipoCliente.TabIndex = 2;
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
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 669);
            Controls.Add(lblListaClientes);
            Controls.Add(dgvClientes);
            Controls.Add(gbDatosCliente);
            Name = "FormClientes";
            Text = "Clientes";
            WindowState = FormWindowState.Maximized;
            Load += FormClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            gbDatosCliente.ResumeLayout(false);
            gbDatosCliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblListaClientes;
        private DataGridView dgvClientes;
        private GroupBox gbDatosCliente;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private Button btnGuardar;
        private Label lblTipoCliente;
        private Button btnModificar;
        private Label lblDireccion;
        private ComboBox cmbTipoCliente;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblTelefono;
        private Button btnCopiar;
        private Button btnLimpiar;
    }
}