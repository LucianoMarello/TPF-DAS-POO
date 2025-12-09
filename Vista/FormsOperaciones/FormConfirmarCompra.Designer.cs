namespace Vista.FormsOperaciones
{
    partial class FormConfirmarCompra
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
            lblProveedor = new Label();
            lblSucursal = new Label();
            lblTotal = new Label();
            btnConfirmarFinal = new Button();
            btnVolver = new Button();
            lblProductos = new Label();
            dgvDetalle = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(23, 23);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(77, 20);
            lblProveedor.TabIndex = 0;
            lblProveedor.Text = "Proveedor";
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Location = new Point(23, 69);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(63, 20);
            lblSucursal.TabIndex = 1;
            lblSucursal.Text = "Sucursal";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(23, 119);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total";
            // 
            // btnConfirmarFinal
            // 
            btnConfirmarFinal.Location = new Point(68, 432);
            btnConfirmarFinal.Name = "btnConfirmarFinal";
            btnConfirmarFinal.Size = new Size(124, 55);
            btnConfirmarFinal.TabIndex = 4;
            btnConfirmarFinal.Text = "Confirmar Compra";
            btnConfirmarFinal.UseVisualStyleBackColor = true;
            btnConfirmarFinal.Click += btnConfirmarFinal_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(240, 432);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(124, 55);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Cancelar y volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Location = new Point(23, 162);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(75, 20);
            lblProductos.TabIndex = 6;
            lblProductos.Text = "Productos";
            // 
            // dgvDetalle
            // 
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(12, 185);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(406, 228);
            dgvDetalle.TabIndex = 7;
            // 
            // FormConfirmarCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 511);
            Controls.Add(dgvDetalle);
            Controls.Add(lblProductos);
            Controls.Add(btnVolver);
            Controls.Add(btnConfirmarFinal);
            Controls.Add(lblTotal);
            Controls.Add(lblSucursal);
            Controls.Add(lblProveedor);
            Name = "FormConfirmarCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirmacion de Compra";
            Load += FormConfirmarCompra_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProveedor;
        private Label lblSucursal;
        private Label lblTotal;
        private Button btnConfirmarFinal;
        private Button btnVolver;
        private Label lblProductos;
        private DataGridView dgvDetalle;
    }
}