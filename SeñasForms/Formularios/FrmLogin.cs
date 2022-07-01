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

            if (string.IsNullOrWhiteSpace(login)) //Revisamos si el campo está vacío
            {
                errorCorreo.Visible = true;
            }
            if (string.IsNullOrWhiteSpace(clv)) //Revisamos si el campo está vacío
            {
                errorPass.Visible = true;
            }
            else
            {
                try { 
                    var correo = new System.Net.Mail.MailAddress(login); //Comprobando el formato de orreo
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
                string rutaBase = Directory.GetCurrentDirectory();
                string rutaArch = rutaBase.Replace(@"\bin\Debug", @"\Archivos\Registros.txt");
                string correo;
                bool busqueda = false;
                bool busqueda2 = false;
                StreamReader leer = new StreamReader(rutaArch);
                correo = leer.ReadLine();

                while (!busqueda && correo != null)
                {
                    string[] valor = correo.Split(';');

                    if (valor[2].Equals(TxtGmail.Text))
                    {
                        busqueda = true;
                    }
                    else
                    {
                        correo = leer.ReadLine();
                    }
                }//Fin del while
                leer.Close();

                if (busqueda == true)
                {
                    StreamReader leer1 = new StreamReader(rutaArch);
                    clv = leer1.ReadLine();

                    while (!busqueda2 && clv != null)
                    {
                        string[] valor = clv.Split(';');

                        if (valor[3].Equals(TxtPass.Text))
                        {
                            busqueda2 = true;
                        }
                        else
                        {
                            clv = leer.ReadLine();
                        }
                    }//Fin del while
                    leer1.Close();
                }
                if (busqueda == true && busqueda2 == true)
                {
                    FrmInterfazPrincipal principal = new FrmInterfazPrincipal();
                    principal.MdiParent = this.MdiParent;
                    principal.Show();
                    this.Close();
                }
                if (!busqueda || !busqueda2)
                {
                    MessageBox.Show("Revise sus datos e intentelo nuevamente");
                }
                
            } //Fin del if
        }
    }
}
