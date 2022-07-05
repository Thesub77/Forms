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

namespace SeñasForms.Formularios
{
    public partial class FrmInterfazPrincipal : Form
    {
        bool expandir = false;
        public FrmInterfazPrincipal()
        {
            InitializeComponent();
        }

        private void FrmInterfazPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TmrCierre_1.Start();

        }

        private void TmrTemporizador_Tick(object sender, EventArgs e)
        {
            if (expandir == true)
            {
                FlpDeslizable.Width -= 10;
                if (FlpDeslizable.Width == FlpDeslizable.MinimumSize.Width)
                {
                    expandir = false;
                    TmrTemporizador.Stop();
                }
            }
            if (expandir == false)
            {
                FlpDeslizable.Width += 10;
                if (FlpDeslizable.Width == FlpDeslizable.MaximumSize.Width)
                {
                    expandir = true;
                    TmrTemporizador.Stop();
                }
            }
            
        }

        private void Btn_menu_Click(object sender, EventArgs e)
        {
            TmrTemporizador.Start();
        }

        private void FlpDeslizable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TmrCierre(object sender, EventArgs e)
        {

            if (FlpDeslizable.Width == FlpDeslizable.MaximumSize.Width)
            {
                expandir = true;
            }
            if (expandir == true)
            {
                FlpDeslizable.Width -= 30;
                if (FlpDeslizable.Width == FlpDeslizable.MinimumSize.Width)
                {
                    expandir = false;
                    TmrTemporizador.Stop();

                    FrmTraducciones traducciones = new FrmTraducciones();
                    traducciones.MdiParent = this.MdiParent;
                    traducciones.Show();
                    this.Close();
                    
                }
            }
        }
    }
}
