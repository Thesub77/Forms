
namespace SeñasForms.Formularios
{
    partial class FrmArranque
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
            this.Cmn_menuPrincipal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.favoritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.politicaDePrivacidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportarProblemaTecnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cmn_menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cmn_menuPrincipal
            // 
            this.Cmn_menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.favoritosToolStripMenuItem,
            this.politicaDePrivacidadToolStripMenuItem,
            this.reportarProblemaTecnicoToolStripMenuItem});
            this.Cmn_menuPrincipal.Name = "Cmn_menuPrincipal";
            this.Cmn_menuPrincipal.Size = new System.Drawing.Size(216, 70);
            this.Cmn_menuPrincipal.Opening += new System.ComponentModel.CancelEventHandler(this.Cmn_menuPrincipal_Opening);
            // 
            // favoritosToolStripMenuItem
            // 
            this.favoritosToolStripMenuItem.Name = "favoritosToolStripMenuItem";
            this.favoritosToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.favoritosToolStripMenuItem.Text = "Favoritos";
            this.favoritosToolStripMenuItem.Click += new System.EventHandler(this.favoritosToolStripMenuItem_Click);
            // 
            // politicaDePrivacidadToolStripMenuItem
            // 
            this.politicaDePrivacidadToolStripMenuItem.Name = "politicaDePrivacidadToolStripMenuItem";
            this.politicaDePrivacidadToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.politicaDePrivacidadToolStripMenuItem.Text = "Politica de privacidad";
            // 
            // reportarProblemaTecnicoToolStripMenuItem
            // 
            this.reportarProblemaTecnicoToolStripMenuItem.Name = "reportarProblemaTecnicoToolStripMenuItem";
            this.reportarProblemaTecnicoToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.reportarProblemaTecnicoToolStripMenuItem.Text = "Reportar problema tecnico";
            // 
            // FrmArranque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 749);
            this.IsMdiContainer = true;
            this.Name = "FrmArranque";
            this.ShowIcon = false;
            this.Text = "FrmArranque";
            this.Load += new System.EventHandler(this.FrmArranque_Load);
            this.Cmn_menuPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip Cmn_menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem favoritosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem politicaDePrivacidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportarProblemaTecnicoToolStripMenuItem;
    }
}