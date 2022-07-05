
namespace SeñasForms.Formularios
{
    partial class FrmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Txtname = new System.Windows.Forms.TextBox();
            this.Txtapellido = new System.Windows.Forms.TextBox();
            this.Txtgmail = new System.Windows.Forms.TextBox();
            this.Txtcontraseña = new System.Windows.Forms.TextBox();
            this.TxtRpass = new System.Windows.Forms.TextBox();
            this.errorname = new System.Windows.Forms.Label();
            this.errorlastname = new System.Windows.Forms.Label();
            this.errorcorreo = new System.Windows.Forms.Label();
            this.errorpass = new System.Windows.Forms.Label();
            this.errorrpass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Confirmar contraseña";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(105, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Registrarse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txtname
            // 
            this.Txtname.BackColor = System.Drawing.Color.White;
            this.Txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtname.ForeColor = System.Drawing.Color.Black;
            this.Txtname.Location = new System.Drawing.Point(48, 170);
            this.Txtname.Name = "Txtname";
            this.Txtname.Size = new System.Drawing.Size(225, 26);
            this.Txtname.TabIndex = 7;
            // 
            // Txtapellido
            // 
            this.Txtapellido.BackColor = System.Drawing.Color.White;
            this.Txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtapellido.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtapellido.ForeColor = System.Drawing.Color.Black;
            this.Txtapellido.Location = new System.Drawing.Point(48, 239);
            this.Txtapellido.Name = "Txtapellido";
            this.Txtapellido.Size = new System.Drawing.Size(225, 26);
            this.Txtapellido.TabIndex = 8;
            // 
            // Txtgmail
            // 
            this.Txtgmail.BackColor = System.Drawing.Color.White;
            this.Txtgmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtgmail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtgmail.ForeColor = System.Drawing.Color.Black;
            this.Txtgmail.Location = new System.Drawing.Point(48, 307);
            this.Txtgmail.Name = "Txtgmail";
            this.Txtgmail.Size = new System.Drawing.Size(225, 26);
            this.Txtgmail.TabIndex = 9;
            // 
            // Txtcontraseña
            // 
            this.Txtcontraseña.BackColor = System.Drawing.Color.White;
            this.Txtcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtcontraseña.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtcontraseña.ForeColor = System.Drawing.Color.Black;
            this.Txtcontraseña.Location = new System.Drawing.Point(48, 377);
            this.Txtcontraseña.Name = "Txtcontraseña";
            this.Txtcontraseña.Size = new System.Drawing.Size(225, 26);
            this.Txtcontraseña.TabIndex = 10;
            // 
            // TxtRpass
            // 
            this.TxtRpass.BackColor = System.Drawing.Color.White;
            this.TxtRpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtRpass.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRpass.ForeColor = System.Drawing.Color.Black;
            this.TxtRpass.Location = new System.Drawing.Point(48, 448);
            this.TxtRpass.Name = "TxtRpass";
            this.TxtRpass.Size = new System.Drawing.Size(225, 26);
            this.TxtRpass.TabIndex = 11;
            // 
            // errorname
            // 
            this.errorname.AutoSize = true;
            this.errorname.BackColor = System.Drawing.Color.Transparent;
            this.errorname.ForeColor = System.Drawing.Color.Red;
            this.errorname.Location = new System.Drawing.Point(45, 197);
            this.errorname.Name = "errorname";
            this.errorname.Size = new System.Drawing.Size(83, 13);
            this.errorname.TabIndex = 13;
            this.errorname.Text = "Nombre inválido";
            this.errorname.Visible = false;
            // 
            // errorlastname
            // 
            this.errorlastname.AutoSize = true;
            this.errorlastname.BackColor = System.Drawing.Color.Transparent;
            this.errorlastname.ForeColor = System.Drawing.Color.Red;
            this.errorlastname.Location = new System.Drawing.Point(45, 266);
            this.errorlastname.Name = "errorlastname";
            this.errorlastname.Size = new System.Drawing.Size(83, 13);
            this.errorlastname.TabIndex = 14;
            this.errorlastname.Text = "Apellido inválido";
            this.errorlastname.Visible = false;
            // 
            // errorcorreo
            // 
            this.errorcorreo.AutoSize = true;
            this.errorcorreo.BackColor = System.Drawing.Color.Transparent;
            this.errorcorreo.ForeColor = System.Drawing.Color.Red;
            this.errorcorreo.Location = new System.Drawing.Point(46, 336);
            this.errorcorreo.Name = "errorcorreo";
            this.errorcorreo.Size = new System.Drawing.Size(88, 13);
            this.errorcorreo.TabIndex = 15;
            this.errorcorreo.Text = "Correo incorrecto";
            this.errorcorreo.Visible = false;
            // 
            // errorpass
            // 
            this.errorpass.AutoSize = true;
            this.errorpass.BackColor = System.Drawing.Color.Transparent;
            this.errorpass.ForeColor = System.Drawing.Color.Red;
            this.errorpass.Location = new System.Drawing.Point(45, 405);
            this.errorpass.Name = "errorpass";
            this.errorpass.Size = new System.Drawing.Size(151, 13);
            this.errorpass.TabIndex = 16;
            this.errorpass.Text = "Por favor cree una contraseña";
            this.errorpass.Visible = false;
            // 
            // errorrpass
            // 
            this.errorrpass.AutoSize = true;
            this.errorrpass.BackColor = System.Drawing.Color.Transparent;
            this.errorrpass.ForeColor = System.Drawing.Color.Red;
            this.errorrpass.Location = new System.Drawing.Point(45, 475);
            this.errorrpass.Name = "errorrpass";
            this.errorrpass.Size = new System.Drawing.Size(134, 13);
            this.errorrpass.TabIndex = 17;
            this.errorrpass.Text = "Su contraseña no coincide";
            this.errorrpass.Visible = false;
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(330, 640);
            this.Controls.Add(this.errorrpass);
            this.Controls.Add(this.errorpass);
            this.Controls.Add(this.errorcorreo);
            this.Controls.Add(this.errorlastname);
            this.Controls.Add(this.errorname);
            this.Controls.Add(this.TxtRpass);
            this.Controls.Add(this.Txtcontraseña);
            this.Controls.Add(this.Txtgmail);
            this.Controls.Add(this.Txtapellido);
            this.Controls.Add(this.Txtname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistro";
            this.Text = "FrmResgistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Txtname;
        private System.Windows.Forms.TextBox Txtapellido;
        private System.Windows.Forms.TextBox Txtgmail;
        private System.Windows.Forms.TextBox Txtcontraseña;
        private System.Windows.Forms.TextBox TxtRpass;
        private System.Windows.Forms.Label errorname;
        private System.Windows.Forms.Label errorlastname;
        private System.Windows.Forms.Label errorcorreo;
        private System.Windows.Forms.Label errorpass;
        private System.Windows.Forms.Label errorrpass;
    }
}