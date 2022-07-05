namespace SeñasForms.Formularios
{
    partial class FrmInterfazPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInterfazPrincipal));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FlpDeslizable = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_menu = new System.Windows.Forms.PictureBox();
            this.TmrTemporizador = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnFavoritos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.TmrCierre_1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.FlpDeslizable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_menu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(141, 523);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(161, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Registro de traducciones";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FlpDeslizable
            // 
            this.FlpDeslizable.BackColor = System.Drawing.Color.DodgerBlue;
            this.FlpDeslizable.Controls.Add(this.panel1);
            this.FlpDeslizable.Controls.Add(this.panel2);
            this.FlpDeslizable.Controls.Add(this.panel3);
            this.FlpDeslizable.Controls.Add(this.panel4);
            this.FlpDeslizable.Controls.Add(this.panel5);
            this.FlpDeslizable.Controls.Add(this.panel6);
            this.FlpDeslizable.Controls.Add(this.panel7);
            this.FlpDeslizable.Controls.Add(this.panel8);
            this.FlpDeslizable.Location = new System.Drawing.Point(1, 1);
            this.FlpDeslizable.MaximumSize = new System.Drawing.Size(190, 599);
            this.FlpDeslizable.Name = "FlpDeslizable";
            this.FlpDeslizable.Size = new System.Drawing.Size(190, 599);
            this.FlpDeslizable.TabIndex = 4;
            this.FlpDeslizable.Paint += new System.Windows.Forms.PaintEventHandler(this.FlpDeslizable_Paint);
            // 
            // Btn_menu
            // 
            this.Btn_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("Btn_menu.Image")));
            this.Btn_menu.Location = new System.Drawing.Point(22, 41);
            this.Btn_menu.Name = "Btn_menu";
            this.Btn_menu.Size = new System.Drawing.Size(28, 20);
            this.Btn_menu.TabIndex = 6;
            this.Btn_menu.TabStop = false;
            this.Btn_menu.Click += new System.EventHandler(this.Btn_menu_Click);
            // 
            // TmrTemporizador
            // 
            this.TmrTemporizador.Interval = 10;
            this.TmrTemporizador.Tick += new System.EventHandler(this.TmrTemporizador_Tick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 104);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnFavoritos);
            this.panel2.Location = new System.Drawing.Point(3, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 53);
            this.panel2.TabIndex = 1;
            // 
            // BtnFavoritos
            // 
            this.BtnFavoritos.Location = new System.Drawing.Point(33, 3);
            this.BtnFavoritos.Name = "BtnFavoritos";
            this.BtnFavoritos.Size = new System.Drawing.Size(110, 46);
            this.BtnFavoritos.TabIndex = 0;
            this.BtnFavoritos.Text = "Favoritos";
            this.BtnFavoritos.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(33, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 46);
            this.button3.TabIndex = 0;
            this.button3.Text = "Configuración de la cuenta";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(3, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(187, 53);
            this.panel3.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(33, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 46);
            this.button4.TabIndex = 0;
            this.button4.Text = "Política y privacidad";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button4);
            this.panel4.Location = new System.Drawing.Point(3, 231);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(187, 53);
            this.panel4.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(33, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 46);
            this.button5.TabIndex = 0;
            this.button5.Text = "Ayuda";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button5);
            this.panel5.Location = new System.Drawing.Point(3, 290);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(187, 53);
            this.panel5.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(33, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 46);
            this.button6.TabIndex = 0;
            this.button6.Text = "Reportar problema técnico";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button6);
            this.panel6.Location = new System.Drawing.Point(3, 349);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(187, 53);
            this.panel6.TabIndex = 5;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(33, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 46);
            this.button7.TabIndex = 0;
            this.button7.Text = "Acerca de la App";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button7);
            this.panel7.Location = new System.Drawing.Point(3, 408);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(187, 53);
            this.panel7.TabIndex = 6;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(33, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 46);
            this.button8.TabIndex = 0;
            this.button8.Text = "Cerrar sesión";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button8);
            this.panel8.Location = new System.Drawing.Point(3, 467);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(187, 53);
            this.panel8.TabIndex = 7;
            // 
            // TmrCierre_1
            // 
            this.TmrCierre_1.Interval = 10;
            this.TmrCierre_1.Tick += new System.EventHandler(this.TmrCierre);
            // 
            // FrmInterfazPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(314, 601);
            this.Controls.Add(this.Btn_menu);
            this.Controls.Add(this.FlpDeslizable);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInterfazPrincipal";
            this.Text = "FrmInterfazPrincipal";
            this.Load += new System.EventHandler(this.FrmInterfazPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.FlpDeslizable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_menu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel FlpDeslizable;
        private System.Windows.Forms.PictureBox Btn_menu;
        private System.Windows.Forms.Timer TmrTemporizador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnFavoritos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Timer TmrCierre_1;
    }
}