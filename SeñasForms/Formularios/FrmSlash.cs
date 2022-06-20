﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeñasForms.Formularios
{
    public partial class FrmSlash : Form
    {
        public FrmSlash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin Frm = new FrmLogin();
            Frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistro Frm = new FrmRegistro();
            Frm.Show();
        }
    }
}
