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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            
        }

        private void Timer_inicio(object sender, EventArgs e)
        {
            FrmSlash slash = new FrmSlash();
            slash.MdiParent = this.MdiParent;
            slash.Show();
            this.Close();
            TmrTranscision.Enabled = false;

        }
    }
}
