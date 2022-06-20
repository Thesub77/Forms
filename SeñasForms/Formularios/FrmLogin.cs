using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeñasForms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = TxtGmail.Text;
            string clv = TxtGmail.Text;
            bool ingresar1 = false, ingresar2 = false;

            if (login.Length > 0)
            {
                ingresar1 = true;
            }
            if(!ingresar1)
            {
                label3.Visible = true;
            }
            if (clv.Length > 0)
            {
                ingresar2 = true;
            }
            if(!ingresar2)
            {
                label4.Visible = true;
            }
           
        }
    }
}
