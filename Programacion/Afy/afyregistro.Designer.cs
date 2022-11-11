namespace Afy
{
    partial class afyregistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(afyregistro));
            this.btnRegistro = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chbOcultar = new System.Windows.Forms.CheckBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.idiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.españolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inglésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbOcultar = new System.Windows.Forms.PictureBox();
            this.pbMostrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(546, 449);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(137, 46);
            this.btnRegistro.TabIndex = 0;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(606, 293);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(606, 351);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.Size = new System.Drawing.Size(181, 20);
            this.txtContrasenia.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(606, 321);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(181, 20);
            this.txtUser.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(446, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(446, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(446, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña";
            // 
            // chbOcultar
            // 
            this.chbOcultar.AutoSize = true;
            this.chbOcultar.Location = new System.Drawing.Point(793, 357);
            this.chbOcultar.Name = "chbOcultar";
            this.chbOcultar.Size = new System.Drawing.Size(15, 14);
            this.chbOcultar.TabIndex = 8;
            this.chbOcultar.UseVisualStyleBackColor = true;
            this.chbOcultar.CheckedChanged += new System.EventHandler(this.chbOcultar_CheckedChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1165, 715);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(132, 34);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.Location = new System.Drawing.Point(546, 599);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(116, 30);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(525, 563);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "¿Tienes una cuenta?";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(606, 384);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.PasswordChar = '*';
            this.txtConfirmar.Size = new System.Drawing.Size(181, 20);
            this.txtConfirmar.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(446, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Confirmar contraseña";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idiomaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1309, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // idiomaToolStripMenuItem
            // 
            this.idiomaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.españolToolStripMenuItem,
            this.inglésToolStripMenuItem});
            this.idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            this.idiomaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.idiomaToolStripMenuItem.Text = "Idioma";
            // 
            // españolToolStripMenuItem
            // 
            this.españolToolStripMenuItem.Name = "españolToolStripMenuItem";
            this.españolToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.españolToolStripMenuItem.Text = "Español";
            this.españolToolStripMenuItem.Click += new System.EventHandler(this.españolToolStripMenuItem_Click);
            // 
            // inglésToolStripMenuItem
            // 
            this.inglésToolStripMenuItem.Name = "inglésToolStripMenuItem";
            this.inglésToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.inglésToolStripMenuItem.Text = "Inglés";
            this.inglésToolStripMenuItem.Click += new System.EventHandler(this.inglésToolStripMenuItem_Click);
            // 
            // pbOcultar
            // 
            this.pbOcultar.Image = global::Afy.Properties.Resources.cerrado;
            this.pbOcultar.Location = new System.Drawing.Point(814, 351);
            this.pbOcultar.Name = "pbOcultar";
            this.pbOcultar.Size = new System.Drawing.Size(63, 27);
            this.pbOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOcultar.TabIndex = 7;
            this.pbOcultar.TabStop = false;
            this.pbOcultar.Click += new System.EventHandler(this.pbOcultar_Click);
            // 
            // pbMostrar
            // 
            this.pbMostrar.Image = global::Afy.Properties.Resources.abierto;
            this.pbMostrar.Location = new System.Drawing.Point(814, 351);
            this.pbMostrar.Name = "pbMostrar";
            this.pbMostrar.Size = new System.Drawing.Size(60, 25);
            this.pbMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMostrar.TabIndex = 9;
            this.pbMostrar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Afy.Properties.Resources.logo_sin_texto;
            this.pictureBox1.Location = new System.Drawing.Point(0, 699);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(280, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(660, 83);
            this.label6.TabIndex = 17;
            this.label6.Text = "Registro de usuarios";
            // 
            // afyregistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(55)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1309, 761);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pbOcultar);
            this.Controls.Add(this.pbMostrar);
            this.Controls.Add(this.chbOcultar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "afyregistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AfySport Registros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.afyregistro_FormClosed);
            this.Load += new System.EventHandler(this.afyregistro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbOcultar;
        private System.Windows.Forms.CheckBox chbOcultar;
        private System.Windows.Forms.PictureBox pbMostrar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem idiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem españolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inglésToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}