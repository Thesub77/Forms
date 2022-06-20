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
    public partial class FrmInterfazPrincipal : Form
    {
        public FrmInterfazPrincipal()
        {
            InitializeComponent();
        }

        private void FrmInterfazPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTraducciones Frm = new FrmTraducciones();
            Frm.Show();
        }
    }
}
