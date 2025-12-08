namespace Vista.FormsGestion
{
    partial class FormRubros
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
            lblListaRubros = new Label();
            dgvRubros = new DataGridView();
            gbDatosRubro = new GroupBox();
            btnCopiar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            txtDescripcion = new TextBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            lblDescripcion = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvRubros).BeginInit();
            gbDatosRubro.SuspendLayout();
            SuspendLayout();
            // 
            // lblListaRubros
            // 
            lblListaRubros.AutoSize = true;
            lblListaRubros.Location = new Point(445, 12);
            lblListaRubros.Name = "lblListaRubros";
            lblListaRubros.Size = new Size(110, 20);
            lblListaRubros.TabIndex = 15;
            lblListaRubros.Text = "Lista de Rubros";
            // 
            // dgvRubros
            // 
            dgvRubros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRubros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRubros.Location = new Point(445, 35);
            dgvRubros.MultiSelect = false;
            dgvRubros.Name = "dgvRubros";
            dgvRubros.ReadOnly = true;
            dgvRubros.RowHeadersWidth = 51;
            dgvRubros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRubros.Size = new Size(842, 607);
            dgvRubros.TabIndex = 14;
            // 
            // gbDatosRubro
            // 
            gbDatosRubro.Controls.Add(btnCopiar);
            gbDatosRubro.Controls.Add(btnLimpiar);
            gbDatosRubro.Controls.Add(btnEliminar);
            gbDatosRubro.Controls.Add(txtDescripcion);
            gbDatosRubro.Controls.Add(btnGuardar);
            gbDatosRubro.Controls.Add(btnModificar);
            gbDatosRubro.Controls.Add(lblDescripcion);
            gbDatosRubro.Controls.Add(lblNombre);
            gbDatosRubro.Controls.Add(txtNombre);
            gbDatosRubro.Location = new Point(12, 12);
            gbDatosRubro.Name = "gbDatosRubro";
            gbDatosRubro.Size = new Size(415, 630);
            gbDatosRubro.TabIndex = 13;
            gbDatosRubro.TabStop = false;
            gbDatosRubro.Text = "Datos del Rubro";
            // 
            // btnCopiar
            // 
            btnCopiar.Location = new Point(230, 533);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(112, 36);
            btnCopiar.TabIndex = 13;
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
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(23, 93);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripción";
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
            // FormRubros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 656);
            Controls.Add(lblListaRubros);
            Controls.Add(dgvRubros);
            Controls.Add(gbDatosRubro);
            Name = "FormRubros";
            Text = "Rubros";
            WindowState = FormWindowState.Maximized;
            Load += FormRubros_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRubros).EndInit();
            gbDatosRubro.ResumeLayout(false);
            gbDatosRubro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblListaRubros;
        private DataGridView dgvRubros;
        private GroupBox gbDatosRubro;
        private Button btnLimpiar;
        private Button btnEliminar;
        private TextBox txtDescripcion;
        private Button btnGuardar;
        private Button btnModificar;
        private Label lblDescripcion;
        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnCopiar;
    }
}