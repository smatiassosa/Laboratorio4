using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
 using System.Drawing.Text;



namespace LaClínicaDelCelular
{
    public partial class frmLoggin : Form
    {

        

        



        public frmLoggin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            String usuario= tbNombreUser.Text;
            frmLogginpass log = new frmLogginpass(usuario);
            log.ShowDialog();
        }
    }
}
