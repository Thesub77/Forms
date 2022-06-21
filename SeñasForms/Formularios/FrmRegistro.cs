using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SeñasForms.Formularios
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = Txtname.Text;
            string lastname = Txtapellido.Text;
            string correo = Txtgmail.Text;
            string pass = Txtcontraseña.Text;
            string rpass = TxtRpass.Text;
            bool okname = false, oklastname = false, okcorreo = false, okpass = false, okrpass = false;

            if (nombre.Length < 3)
            {
                errorname.Visible = true;
            } 
            else
            {
                okname = true;
            }
            if (lastname.Length < 3)
            {
                errorlastname.Visible = true;
            }
            else
            {
                oklastname = true;
            }
            if (correo.Length < 5)
            {
                errorcorreo.Visible = true;
            }
            else
            {
                okcorreo = true;
            }
            if (pass.Length < 8)
            {
                errorpass.Visible = true;
            }
            else
            {
                okpass = true;
            }
            if (rpass != pass)
            {
                errorrpass.Visible = true;
            }
            else
            {
                okrpass = true;
            }

            try { 

                if (okname == true && oklastname == true && okcorreo == true && okpass == true && okrpass == true)
                {
                    TextWriter registro = new StreamWriter(@"C:\Users\erling\Forms\SeñasForms\Archivos\" + correo + ".txt");
                    registro.WriteLine(pass);
                    registro.Close();

                    MessageBox.Show("Se ha registrado correctamente!");
                }

                    this.Hide();
                    FrmVerificacion Frm = new FrmVerificacion();
                    Frm.Show();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error al registrar" + x);
            }
        }
    }
}
