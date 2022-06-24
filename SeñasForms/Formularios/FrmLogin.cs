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

            if (string.IsNullOrWhiteSpace(login))
            {
                errorCorreo.Visible = true;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(clv))
                {
                    errorPass.Visible = true;
                }
                    try
                    {
                        TextReader sign_in = new StreamReader(login + ".txt");
                        if (sign_in.ReadLine() == clv)
                        {
                            MessageBox.Show("Ha iniciado sesión correctamente!");

                            this.Hide();
                            FrmInterfazPrincipal Frm = new FrmInterfazPrincipal();
                            Frm.Show();
                        }
                        

                    }
                    catch
                    {
                        TxtGmail.Text = "";
                        TxtPass.Text = "";
                        errorCorreo.Visible = false;
                        errorPass.Visible = false;
                        MessageBox.Show("Error al iniciar sesión, ingrese sus datos nuevamente.");
                    }
                
            }
            
        }
    }
}
