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
    public partial class frmLogginpass : Form
    {
        String nombreUser;
        public frmLogginpass(String usuario)
        {
            nombreUser = usuario;
            InitializeComponent();
        }

        private void frmLogginpass_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = nombreUser;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pbImgPerfil.Width - 3, pbImgPerfil.Height - 3);
            Region rg = new Region(gp);
            pbImgPerfil.Region = rg;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            
            frmLoggin log = new frmLoggin();
            log.ShowDialog();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
        }
    }
}
