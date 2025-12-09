namespace Vista.FormsOperaciones
{
    partial class FormConfirmarVenta
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
            dgvDetalle = new DataGridView();
            lblProductos = new Label();
            btnVolver = new Button();
            btnConfirmarFinal = new Button();
            lblPago = new Label();
            lblSucursal = new Label();
            lblCliente = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // dgvDetalle
            // 
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(12, 237);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(406, 228);
            dgvDetalle.TabIndex = 14;
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Location = new Point(23, 214);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(75, 20);
            lblProductos.TabIndex = 13;
            lblProductos.Text = "Productos";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(240, 484);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(124, 55);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "Cancelar y volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnConfirmarFinal
            // 
            btnConfirmarFinal.Location = new Point(68, 484);
            btnConfirmarFinal.Name = "btnConfirmarFinal";
            btnConfirmarFinal.Size = new Size(124, 55);
            btnConfirmarFinal.TabIndex = 11;
            btnConfirmarFinal.Text = "Confirmar Compra";
            btnConfirmarFinal.UseVisualStyleBackColor = true;
            btnConfirmarFinal.Click += btnConfirmarFinal_Click;
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Location = new Point(23, 120);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(42, 20);
            lblPago.TabIndex = 10;
            lblPago.Text = "Pago";
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Location = new Point(23, 70);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(63, 20);
            lblSucursal.TabIndex = 9;
            lblSucursal.Text = "Sucursal";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(23, 24);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(55, 20);
            lblCliente.TabIndex = 8;
            lblCliente.Text = "Cliente";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(23, 167);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "Total";
            // 
            // FormConfirmarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 556);
            Controls.Add(lblTotal);
            Controls.Add(dgvDetalle);
            Controls.Add(lblProductos);
            Controls.Add(btnVolver);
            Controls.Add(btnConfirmarFinal);
            Controls.Add(lblPago);
            Controls.Add(lblSucursal);
            Controls.Add(lblCliente);
            Name = "FormConfirmarVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormConfirmarVenta";
            Load += FormConfirmarVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDetalle;
        private Label lblProductos;
        private Button btnVolver;
        private Button btnConfirmarFinal;
        private Label lblPago;
        private Label lblSucursal;
        private Label lblCliente;
        private Label lblTotal;
    }
}