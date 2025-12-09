using Vista.FormsGestion;
using Vista.FormsHistorialAlertas;
using Vista.FormsOperaciones;

namespace Vista
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormulario<T>() where T : Form, new()
        {
            //Busca si el formulario ya está abierto
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(T))
                {
                    form.Activate();
                    return;
                }
            }
            Form formulario = new T();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormProductos>();
        }

        private void menuRubros_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormRubros>();
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormClientes>();
        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormProveedores>();
        }

        private void menuSucursales_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormSucursales>();
        }

        private void menuVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormVentas>();
        }

        private void menuCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormCompras>();
        }

        private void menuAlertas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormAlertas>();
        }

        private void menuHistorialVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormHistorialVentas>();
        }

        private void menuHistorialCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormHistorialCompras>();
        }
    }
}
