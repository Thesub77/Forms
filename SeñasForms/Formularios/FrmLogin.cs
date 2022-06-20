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
            string clv = TxtPass.Text;
            bool correoCorrecto = false, passCorrecta = false;

            if (login.Length > 0)
            {
                correoCorrecto = true;
            }
            if (correoCorrecto == false)
            {
                errorCorreo.Visible = true;
            }
            if (clv.Length > 0)
            {
                passCorrecta = true;
            }
            if (passCorrecta == false)
            {
                errorPass.Visible = true;
            }
            if (login.Length > 0 && clv.Length > 0)
            {
                errorCorreo.Visible = false;
                errorPass.Visible = false;

                this.Hide();

                FrmInterfazPrincipal Frm = new FrmInterfazPrincipal();
                Frm.Show();
            }
           
        }
    }
}
