using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeñasForms.Formularios;

namespace SeñasForms.Formularios
{
    public partial class FrmArranque : Form
    {
        public FrmArranque()
        {
            InitializeComponent();
        }

        private void favoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin Frm = new FrmLogin();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cmn_menuPrincipal.Show();
        }

        private void Cmn_menuPrincipal_Opening(object sender, CancelEventArgs e)
        {

        }

        private void FrmArranque_Load(object sender, EventArgs e)
        {
            FrmInterfazPrincipal principal = new FrmInterfazPrincipal();
            principal.MdiParent = this;
            principal.Show();
        }

        
    }
}
