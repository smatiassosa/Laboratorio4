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
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            ToolTip datas = new ToolTip();
            datas.SetToolTip(dgvProductosFiltrados, "Con doble click añades un artículo");

            ToolTip datacar = new ToolTip();
            datacar.SetToolTip(dgvCarrito, "Con doble click quitas un artículo del carrito");
        }

    }
}
