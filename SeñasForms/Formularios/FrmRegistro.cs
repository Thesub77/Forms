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

            if (string.IsNullOrWhiteSpace(nombre))
            {
                errorname.Visible = true;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(lastname))
                {
                    errorlastname.Visible = true;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(correo))
                    {
                        errorcorreo.Visible = true;
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(pass))
                        {
                            errorpass.Visible = true;
                        }
                        else
                        {
                            if (rpass != pass)
                            {
                                errorrpass.Visible = true;
                            }
                            else
                            {
                                try
                                {
                                    TextWriter registro = new StreamWriter(@"C:\Users\MLC03\Desktop\Forms\SeñasForms\Archivos\" + correo + ".txt");
                                    registro.WriteLine(pass);
                                    registro.Close();

                                    MessageBox.Show("Se ha registrado correctamente!");
                                }
                                catch
                                {
                                    MessageBox.Show("Se ha presentado un error al registrarse");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
