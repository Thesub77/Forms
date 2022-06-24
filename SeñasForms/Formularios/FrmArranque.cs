using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
