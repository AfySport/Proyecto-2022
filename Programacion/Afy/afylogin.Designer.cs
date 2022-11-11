namespace Afy
{
    partial class afylogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(afylogin));
            this.txtUserOrMail = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.idiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.españolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inglésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserOrMail
            // 
            this.txtUserOrMail.ForeColor = System.Drawing.Color.Black;
            this.txtUserOrMail.Location = new System.Drawing.Point(1035, 274);
            this.txtUserOrMail.Name = "txtUserOrMail";
            this.txtUserOrMail.Size = new System.Drawing.Size(151, 20);
            this.txtUserOrMail.TabIndex = 0;
            this.txtUserOrMail.Click += new System.EventHandler(this.txtUserOrMail_Click);
            this.txtUserOrMail.Leave += new System.EventHandler(this.txtUserOrMail_Leave);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.ForeColor = System.Drawing.Color.Black;
            this.txtContrasenia.Location = new System.Drawing.Point(1035, 324);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.Size = new System.Drawing.Size(151, 20);
            this.txtContrasenia.TabIndex = 1;
            this.txtContrasenia.Click += new System.EventHandler(this.txtContrasenia_Click);
            this.txtContrasenia.Leave += new System.EventHandler(this.txtContrasenia_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(1052, 364);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(102, 27);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(1017, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "¿No tienes una cuenta?";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Blue;
            this.btnRegistrar.Location = new System.Drawing.Point(1027, 429);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(148, 33);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrarme";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1052, 572);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(102, 32);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Indigo;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idiomaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1309, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // idiomaToolStripMenuItem
            // 
            this.idiomaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.españolToolStripMenuItem,
            this.inglésToolStripMenuItem});
            this.idiomaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idiomaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            this.idiomaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.idiomaToolStripMenuItem.Text = "Idioma";
            // 
            // españolToolStripMenuItem
            // 
            this.españolToolStripMenuItem.Name = "españolToolStripMenuItem";
            this.españolToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.españolToolStripMenuItem.Text = "Español";
            this.españolToolStripMenuItem.Click += new System.EventHandler(this.españolToolStripMenuItem_Click);
            // 
            // inglésToolStripMenuItem
            // 
            this.inglésToolStripMenuItem.Name = "inglésToolStripMenuItem";
            this.inglésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inglésToolStripMenuItem.Text = "Inglés";
            this.inglésToolStripMenuItem.Click += new System.EventHandler(this.inglésToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(918, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(918, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contraseña:";
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.FlatAppearance.BorderSize = 0;
            this.btnRecuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperar.ForeColor = System.Drawing.Color.Blue;
            this.btnRecuperar.Location = new System.Drawing.Point(1020, 510);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(166, 27);
            this.btnRecuperar.TabIndex = 11;
            this.btnRecuperar.Text = "Recuperar...";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(965, 488);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "¿Te olvidaste de tu usuario o contraseña?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Afy.Properties.Resources.fondo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(854, 766);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(987, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 75);
            this.label5.TabIndex = 15;
            this.label5.Text = "Login";
            // 
            // afylogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(55)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1309, 761);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtUserOrMail);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1325, 800);
            this.MinimumSize = new System.Drawing.Size(1325, 800);
            this.Name = "afylogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AfySport Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.afylogin_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserOrMail;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem idiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem españolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inglésToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
    }
}