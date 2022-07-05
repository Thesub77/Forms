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
    public partial class FrmSlash : Form
    {
        public FrmSlash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.MdiParent = this.MdiParent;
            login.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmRegistro registro = new FrmRegistro();
            registro.MdiParent = this.MdiParent;
            registro.Show();
            this.Close();
        }

        private void FrmSlash_Load(object sender, EventArgs e)
        {

        }

      
    }
}
