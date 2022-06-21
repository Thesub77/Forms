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
            try { 
                if (correoCorrecto == true && passCorrecta == true)
                {
                    TextReader sign_in = new StreamReader (TxtGmail.Text + ".txt");
                    sign_in.Close();

                    if (sign_in.ReadLine() == TxtPass.Text)
                    {
                        MessageBox.Show("Ha iniciado sesión correctamente!");

                        this.Hide();
                        FrmInterfazPrincipal Frm = new FrmInterfazPrincipal();
                        Frm.Show();
                    }
                }

            }
            catch (Exception y)
            {
                MessageBox.Show("Error al iniciar sesión" + "Nombre del error: " + y);
            }
        }
    }
}
