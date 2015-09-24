using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaClínicaDelCelular
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            // -------------    TOOLTIPS BOTONES    ------------- //
            ToolTip ttNuevaVenta = new ToolTip();
            ttNuevaVenta.SetToolTip(btnRegistrarVenta, "Realiza una venta.");

            ToolTip ttStock = new ToolTip();
            ttStock.SetToolTip(btnConsultarStock, "Consulta el Stock de cualquier producto.");

            ToolTip ttService = new ToolTip();
            ttService.SetToolTip(btnServicioTecnico, "Gestione o consulte un servicio técnico.");

            ToolTip ttfactura = new ToolTip();
            ttfactura.SetToolTip(btnReimprimirFact, "Reimprime una factura en particular");

            ToolTip ttEstadist = new ToolTip();
            ttEstadist.SetToolTip(btnEstadisticas, "Visualiza las ventas diarias, mensuales y anuales");

            ToolTip ttCerrar = new ToolTip();
            ttCerrar.SetToolTip(btnCerrarSesion, "Cierra la sesión actual");

            ToolTip ttConfigur = new ToolTip();
            ttConfigur.SetToolTip(btnConfiguraciones, "Configura el sistema");

            // ----------------------------------------------------------- //

        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            frmVenta venta = new frmVenta();
            venta.ShowDialog();
        }
    }
}
