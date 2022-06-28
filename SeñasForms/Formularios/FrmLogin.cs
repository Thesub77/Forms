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
using System.IO;

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
            bool formato = false;

            if (string.IsNullOrWhiteSpace(login))
            {
                errorCorreo.Visible = true;
            }
            if (string.IsNullOrWhiteSpace(clv))
            {
                errorPass.Visible = true;
            }
            else
            {
                try { 
                    var correo = new System.Net.Mail.MailAddress(login);
                    formato = true;
                }
                catch
                {
                    TxtGmail.Text = ""; //Limpiando el control
                    MessageBox.Show("Correo electronico incorrecto", "Formato de correo electronico no encontrado");
                }
            }
            if (formato == true)
            {
                MessageBox.Show("Ha iniciado sesión correctamente");
            }

            
        }
    }
}
