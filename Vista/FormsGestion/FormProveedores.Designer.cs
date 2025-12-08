namespace Vista.FormsGestion
{
    partial class FormProveedores
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
            lblListaProveedores = new Label();
            dgvProveedores = new DataGridView();
            gbDatosProveedores = new GroupBox();
            btnCopiar = new Button();
            btnLimpiar = new Button();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            lblDireccion = new Label();
            lblTelefono = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            gbDatosProveedores.SuspendLayout();
            SuspendLayout();
            // 
            // lblListaProveedores
            // 
            lblListaProveedores.AutoSize = true;
            lblListaProveedores.Location = new Point(445, 12);
            lblListaProveedores.Name = "lblListaProveedores";
            lblListaProveedores.Size = new Size(146, 20);
            lblListaProveedores.TabIndex = 18;
            lblListaProveedores.Text = "Lista de Proveedores";
            // 
            // dgvProveedores
            // 
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(445, 35);
            dgvProveedores.MultiSelect = false;
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.Size = new Size(842, 607);
            dgvProveedores.TabIndex = 17;
            // 
            // gbDatosProveedores
            // 
            gbDatosProveedores.Controls.Add(btnCopiar);
            gbDatosProveedores.Controls.Add(btnLimpiar);
            gbDatosProveedores.Controls.Add(txtTelefono);
            gbDatosProveedores.Controls.Add(txtDireccion);
            gbDatosProveedores.Controls.Add(btnGuardar);
            gbDatosProveedores.Controls.Add(btnModificar);
            gbDatosProveedores.Controls.Add(lblDireccion);
            gbDatosProveedores.Controls.Add(lblTelefono);
            gbDatosProveedores.Controls.Add(lblNombre);
            gbDatosProveedores.Controls.Add(txtNombre);
            gbDatosProveedores.Location = new Point(12, 12);
            gbDatosProveedores.Name = "gbDatosProveedores";
            gbDatosProveedores.Size = new Size(415, 630);
            gbDatosProveedores.TabIndex = 16;
            gbDatosProveedores.TabStop = false;
            gbDatosProveedores.Text = "Datos del Proveedor";
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
            btnLimpiar.Click += btnLimpiar_Click;
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
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 671);
            Controls.Add(lblListaProveedores);
            Controls.Add(dgvProveedores);
            Controls.Add(gbDatosProveedores);
            Name = "FormProveedores";
            Text = "Proveedores";
            WindowState = FormWindowState.Maximized;
            Load += FormProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            gbDatosProveedores.ResumeLayout(false);
            gbDatosProveedores.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblListaProveedores;
        private DataGridView dgvProveedores;
        private GroupBox gbDatosProveedores;
        private Button btnCopiar;
        private Button btnLimpiar;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private Button btnGuardar;
        private Button btnModificar;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblNombre;
        private TextBox txtNombre;
    }
}