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
            string login = TxtGmail.Text, clv = TxtPass.Text; 
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
<<<<<<< HEAD
                    var correo = new System.Net.Mail.MailAddress(login); //Verificando el formato de correo electronico
=======
                    var correo = new System.Net.Mail.MailAddress(login); //Comprobando el formato de orreo
>>>>>>> 32cb9f9574e5a03d78885aafa1c1955f834de41e
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
                string rutaBase = Directory.GetCurrentDirectory(); //obtenemos la direccion original de nuestra aplicacion
                string rutaArch = rutaBase.Replace(@"\bin\Debug", @"\Archivos\Registros.txt"); //Reemplazamos la dirección con la que queremos
                string correo;
<<<<<<< HEAD
                bool busqueda = false; //Booleano para validar el correo
                bool busqueda2 = false; //Booleano para validar la contraseña
                StreamReader leer = new StreamReader(rutaArch); //Objeto para abrir el archivo
=======
                bool busqueda = false;
                bool busqueda2 = false;
                StreamReader leer = new StreamReader(rutaArch);
>>>>>>> 32cb9f9574e5a03d78885aafa1c1955f834de41e
                correo = leer.ReadLine();

                while (!busqueda && correo != null)
                {
                    string[] valor = correo.Split(';');

                    if (valor[2].Equals(TxtGmail.Text)) //Comparamos los datos separados con ; con el correo ingresado
                    {
                        busqueda = true;
                    }
                    else
                    {
                        correo = leer.ReadLine();
                    }
                }//Fin del while
<<<<<<< HEAD
                leer.Close(); //Cerramos el objeto

                if (busqueda == true)
                {
                    StreamReader leer1 = new StreamReader(rutaArch); //Creamos un nuevo objeto para buscar la clave
                    clv = leer1.ReadLine();
                    
                    while(!busqueda2 && clv != null)
                    {
                        string[] valor = clv.Split(';');

                        if(valor[3].Equals(TxtPass.Text)) //Comparamos los datos para encontrar la clave
=======
                leer.Close();

                if (busqueda == true)
                {
                    StreamReader leer1 = new StreamReader(rutaArch);
                    clv = leer1.ReadLine();

                    while (!busqueda2 && clv != null)
                    {
                        string[] valor = clv.Split(';');

                        if (valor[3].Equals(TxtPass.Text))
>>>>>>> 32cb9f9574e5a03d78885aafa1c1955f834de41e
                        {
                            busqueda2 = true;
                        }
                        else
                        {
<<<<<<< HEAD
                            clv = leer1.ReadLine();
                        }

                    } //Fin del while
                    leer1.Close();// Cerramos el objeto
                }
                if(busqueda == true && busqueda2 == true)
                {
                    FrmInterfazPrincipal principal = new FrmInterfazPrincipal(); //Abrimos un nuevo form
=======
                            clv = leer.ReadLine();
                        }
                    }//Fin del while
                    leer1.Close();
                }
                if (busqueda == true && busqueda2 == true)
                {
                    FrmInterfazPrincipal principal = new FrmInterfazPrincipal();
>>>>>>> 32cb9f9574e5a03d78885aafa1c1955f834de41e
                    principal.MdiParent = this.MdiParent;
                    principal.Show();
                    this.Close();
                }
                if (!busqueda || !busqueda2)
                {
                    MessageBox.Show("Revise sus datos e intentelo nuevamente");

                }
<<<<<<< HEAD
            }//Fin del if
=======
                
            } //Fin del if
>>>>>>> 32cb9f9574e5a03d78885aafa1c1955f834de41e
        }
    }
}
