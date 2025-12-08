namespace Vista
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            menuGestion = new ToolStripMenuItem();
            menuProductos = new ToolStripMenuItem();
            menuRubros = new ToolStripMenuItem();
            menuClientes = new ToolStripMenuItem();
            menuProveedores = new ToolStripMenuItem();
            menuSucursales = new ToolStripMenuItem();
            menuOperaciones = new ToolStripMenuItem();
            menuVenta = new ToolStripMenuItem();
            menuCompra = new ToolStripMenuItem();
            menuAlertas = new ToolStripMenuItem();
            menuReportes = new ToolStripMenuItem();
            menuHistorialVentas = new ToolStripMenuItem();
            menuHistorialCompras = new ToolStripMenuItem();
            menuIntegrantes = new ToolStripMenuItem();
            menuSalir = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuGestion, menuOperaciones, menuReportes, menuIntegrantes, menuSalir });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 28);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // menuGestion
            // 
            menuGestion.DropDownItems.AddRange(new ToolStripItem[] { menuProductos, menuRubros, menuClientes, menuProveedores, menuSucursales });
            menuGestion.Name = "menuGestion";
            menuGestion.Size = new Size(125, 24);
            menuGestion.Text = "Gestión (ABMs)";
            // 
            // menuProductos
            // 
            menuProductos.Name = "menuProductos";
            menuProductos.Size = new Size(224, 26);
            menuProductos.Text = "Productos";
            menuProductos.Click += menuProductos_Click;
            // 
            // menuRubros
            // 
            menuRubros.Name = "menuRubros";
            menuRubros.Size = new Size(224, 26);
            menuRubros.Text = "Rubros";
            menuRubros.Click += menuRubros_Click;
            // 
            // menuClientes
            // 
            menuClientes.Name = "menuClientes";
            menuClientes.Size = new Size(224, 26);
            menuClientes.Text = "Clientes";
            menuClientes.Click += menuClientes_Click;
            // 
            // menuProveedores
            // 
            menuProveedores.Name = "menuProveedores";
            menuProveedores.Size = new Size(224, 26);
            menuProveedores.Text = "Proveedores";
            // 
            // menuSucursales
            // 
            menuSucursales.Name = "menuSucursales";
            menuSucursales.Size = new Size(224, 26);
            menuSucursales.Text = "Sucursales";
            // 
            // menuOperaciones
            // 
            menuOperaciones.DropDownItems.AddRange(new ToolStripItem[] { menuVenta, menuCompra, menuAlertas });
            menuOperaciones.Name = "menuOperaciones";
            menuOperaciones.Size = new Size(106, 24);
            menuOperaciones.Text = "Operaciones";
            // 
            // menuVenta
            // 
            menuVenta.Name = "menuVenta";
            menuVenta.Size = new Size(311, 26);
            menuVenta.Text = "Nueva Venta";
            // 
            // menuCompra
            // 
            menuCompra.Name = "menuCompra";
            menuCompra.Size = new Size(311, 26);
            menuCompra.Text = "Registrar Compra (Ingreso Stock)";
            // 
            // menuAlertas
            // 
            menuAlertas.Name = "menuAlertas";
            menuAlertas.Size = new Size(311, 26);
            menuAlertas.Text = "Alertas de Stock/Vencimiento";
            // 
            // menuReportes
            // 
            menuReportes.DropDownItems.AddRange(new ToolStripItem[] { menuHistorialVentas, menuHistorialCompras });
            menuReportes.Name = "menuReportes";
            menuReportes.Size = new Size(82, 24);
            menuReportes.Text = "Reportes";
            // 
            // menuHistorialVentas
            // 
            menuHistorialVentas.Name = "menuHistorialVentas";
            menuHistorialVentas.Size = new Size(232, 26);
            menuHistorialVentas.Text = "Historial de Ventas";
            // 
            // menuHistorialCompras
            // 
            menuHistorialCompras.Name = "menuHistorialCompras";
            menuHistorialCompras.Size = new Size(232, 26);
            menuHistorialCompras.Text = "Historial de Compras";
            // 
            // menuIntegrantes
            // 
            menuIntegrantes.Name = "menuIntegrantes";
            menuIntegrantes.Size = new Size(97, 24);
            menuIntegrantes.Text = "Integrantes";
            // 
            // menuSalir
            // 
            menuSalir.Name = "menuSalir";
            menuSalir.Size = new Size(52, 24);
            menuSalir.Text = "Salir";
            menuSalir.Click += menuSalir_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechStore - Sistema de Gestión";
            WindowState = FormWindowState.Maximized;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem menuGestion;
        private ToolStripMenuItem menuProductos;
        private ToolStripMenuItem menuRubros;
        private ToolStripMenuItem menuClientes;
        private ToolStripMenuItem menuProveedores;
        private ToolStripMenuItem menuSucursales;
        private ToolStripMenuItem menuOperaciones;
        private ToolStripMenuItem menuVenta;
        private ToolStripMenuItem menuCompra;
        private ToolStripMenuItem menuReportes;
        private ToolStripMenuItem menuIntegrantes;
        private ToolStripMenuItem menuSalir;
        private ToolStripMenuItem menuAlertas;
        private ToolStripMenuItem menuHistorialVentas;
        private ToolStripMenuItem menuHistorialCompras;
    }
}
