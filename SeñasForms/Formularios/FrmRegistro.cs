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

            if (string.IsNullOrWhiteSpace(nombre))//Revisamos si el campo esta vacio
            {
                errorname.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(lastname))// Revisamos si el campo esta vacio
            {
                errorlastname.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(correo))//Revisamos si el campo esta vacio
            {
                errorcorreo.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(pass))//Revisamos si el campo esta vacio
            {
                errorpass.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(pass))//Revisamos si el campo esta vacio
            {
                errorpass.Visible = true;
            }
            else if (rpass != pass)//Revisamos si el campo coincide con el de la contraseña
            {
                errorrpass.Visible = true;
            }
            else
            {
                try
                {
                    FileStream fs; //Creamos un objeto para crear un archivo
                    StreamWriter escribir; //Creamos un objeto para escribir en el archivo
                    string linea; //Esta variable tomara todo lo que se ingrese
                    string rutaBase = Directory.GetCurrentDirectory(); //Obtenemos la ruta actual de la aplicacion por defecto
                    string rutaArch = rutaBase.Replace(@"\bin\Debug", @"\Archivos\Registros.txt"); //Reemplazamos esa ruta y colocamos donde queremos ese archivo
                    fs = new FileStream(rutaArch, FileMode.Append); //Le damos un estado al archivo

                    escribir = new StreamWriter(fs); //Abrimos el archivo para comenzar a escribir
                    linea = Txtname.Text + ";"; //Lo que se escriba en cada campo se escribirá en el archivo separados por ;
                    linea += Txtapellido.Text + ";";
                    linea += Txtgmail.Text + ";";
                    linea += Txtcontraseña.Text + ";";
                    escribir.Write(linea); //Escribimos cada dato
                    escribir.Close(); //Cerramos el onjeto para evitar errores

                    MessageBox.Show("Los datos se han guardado correctamente!");
                }
                catch
                {
                    MessageBox.Show("Se ha presentado un error al registrarse");
                }
            }

        }
    }
}
