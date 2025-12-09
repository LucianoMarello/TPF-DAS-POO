namespace Vista.FormsHistorialAlertas
{
    partial class FormAlertas
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
            lblTitulo = new Label();
            btnRefrescar = new Button();
            dgvAlertas = new DataGridView();
            btnDarBaja = new Button();
            lblReferencia = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAlertas).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(297, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(257, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "ALERTAS DE STOCK Y VENCIMIENTOS";
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(21, 469);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(140, 43);
            btnRefrescar.TabIndex = 1;
            btnRefrescar.Text = "Refrescar Lista";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // dgvAlertas
            // 
            dgvAlertas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlertas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlertas.Location = new Point(12, 58);
            dgvAlertas.MultiSelect = false;
            dgvAlertas.Name = "dgvAlertas";
            dgvAlertas.ReadOnly = true;
            dgvAlertas.RowHeadersWidth = 51;
            dgvAlertas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlertas.Size = new Size(828, 405);
            dgvAlertas.TabIndex = 2;
            dgvAlertas.CellFormatting += dgvAlertas_CellFormatting;
            // 
            // btnDarBaja
            // 
            btnDarBaja.Location = new Point(355, 489);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(141, 61);
            btnDarBaja.TabIndex = 3;
            btnDarBaja.Text = "DAR BAJA POR VENCIMIENTO";
            btnDarBaja.UseVisualStyleBackColor = true;
            btnDarBaja.Click += btnDarBaja_Click;
            // 
            // lblReferencia
            // 
            lblReferencia.AutoSize = true;
            lblReferencia.Location = new Point(21, 529);
            lblReferencia.Name = "lblReferencia";
            lblReferencia.Size = new Size(175, 40);
            lblReferencia.TabIndex = 4;
            lblReferencia.Text = "Rojo: Vencido\r\nAmarillo: Vence en 7 días";
            // 
            // FormAlertas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 588);
            Controls.Add(lblReferencia);
            Controls.Add(btnDarBaja);
            Controls.Add(dgvAlertas);
            Controls.Add(btnRefrescar);
            Controls.Add(lblTitulo);
            Name = "FormAlertas";
            Text = "Alertas";
            WindowState = FormWindowState.Maximized;
            Load += FormAlertas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlertas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnRefrescar;
        private DataGridView dgvAlertas;
        private Button btnDarBaja;
        private Label lblReferencia;
    }
}