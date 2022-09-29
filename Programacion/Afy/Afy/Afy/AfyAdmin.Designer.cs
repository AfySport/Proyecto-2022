namespace Afy
{
    partial class AfyAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AfyAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestorDePublicidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "admin";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.publicidadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.usuariosToolStripMenuItem.Text = "Administración de usuarios";
            // 
            // eliminarUsuariosToolStripMenuItem
            // 
            this.eliminarUsuariosToolStripMenuItem.Name = "eliminarUsuariosToolStripMenuItem";
            this.eliminarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.eliminarUsuariosToolStripMenuItem.Text = "Consultar Usuarios";
            this.eliminarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuariosToolStripMenuItem_Click);
            // 
            // publicidadToolStripMenuItem
            // 
            this.publicidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestorDePublicidadToolStripMenuItem});
            this.publicidadToolStripMenuItem.Name = "publicidadToolStripMenuItem";
            this.publicidadToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.publicidadToolStripMenuItem.Text = "Publicidad";
            // 
            // gestorDePublicidadToolStripMenuItem
            // 
            this.gestorDePublicidadToolStripMenuItem.Name = "gestorDePublicidadToolStripMenuItem";
            this.gestorDePublicidadToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.gestorDePublicidadToolStripMenuItem.Text = "Gestor de publicidad";
            this.gestorDePublicidadToolStripMenuItem.Click += new System.EventHandler(this.gestorDePublicidadToolStripMenuItem_Click);
            // 
            // AfyAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AfyAdmin";
            this.Text = "AfyAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AfyAdmin_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestorDePublicidadToolStripMenuItem;
    }
}