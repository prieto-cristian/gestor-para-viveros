using presentacion;
using System.Runtime.InteropServices;
namespace GestorParaViveros
{
    public partial class frmVentanaPrincipal : Form
    {
        private static Color ColorFondoBotonesPorDefecto = Color.FromArgb(24, 30, 54);
        

        public frmVentanaPrincipal()
        {
            InitializeComponent();
            CambiarDisenioBotonActual(btnInicio);

            lblTitulo.Text = "Inicio";
            this.pnlCargadorDeFormularios.Controls.Clear();
            frmInicioResumen frmInicioResumen = new frmInicioResumen() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; ;
            frmInicioResumen.FormBorderStyle = FormBorderStyle.None;
            this.pnlCargadorDeFormularios.Controls.Add(frmInicioResumen);
            frmInicioResumen.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            CambiarDisenioBotonActual((Button)sender);

            lblTitulo.Text = "Inicio";
            this.pnlCargadorDeFormularios.Controls.Clear();
            frmInicioResumen frmInicioResumen = new frmInicioResumen() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; ;
            frmInicioResumen.FormBorderStyle = FormBorderStyle.None;
            this.pnlCargadorDeFormularios.Controls.Add(frmInicioResumen);
            frmInicioResumen.Show();
        }

        private void btnAnaliticas_Click(object sender, EventArgs e)
        {
            CambiarDisenioBotonActual((Button)sender);
        }
        private void CambiarDisenioBotonActual(Button boton)
        {
            pnlNav.Height = boton.Height;
            pnlNav.Top = boton.Top;
            pnlNav.Left = boton.Left;
            boton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            CambiarDisenioBotonActual((Button)sender);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            CambiarDisenioBotonActual((Button)sender);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            CambiarDisenioBotonActual((Button)sender);
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            CambiarDisenioBotonActual((Button)sender);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            CambiarDisenioBotonActual((Button)sender);
        }

        private void btnInicio_Leave(object sender, EventArgs e)
        {
            btnInicio.BackColor = ColorFondoBotonesPorDefecto;
        }

        private void btnAnaliticas_Leave(object sender, EventArgs e)
        {
            btnAnaliticas.BackColor = ColorFondoBotonesPorDefecto;
        }

        private void btnVentas_Leave(object sender, EventArgs e)
        {
            btnVentas.BackColor = ColorFondoBotonesPorDefecto;
        }

        private void btnInventario_Leave(object sender, EventArgs e)
        {
            btnInventario.BackColor = ColorFondoBotonesPorDefecto;
        }

        private void btnCompras_Leave(object sender, EventArgs e)
        {
            btnCompras.BackColor = ColorFondoBotonesPorDefecto;
        }

        private void btnGastos_Leave(object sender, EventArgs e)
        {
            btnGastos.BackColor = ColorFondoBotonesPorDefecto;
        }

        private void btnConfiguracion_Leave(object sender, EventArgs e)
        {
            btnConfiguracion.BackColor = ColorFondoBotonesPorDefecto;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
