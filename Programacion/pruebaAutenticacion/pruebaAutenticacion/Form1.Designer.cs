namespace pruebaAutenticacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtRegistrarUsuario = new System.Windows.Forms.TextBox();
            this.txtRegistrarConstrasenia = new System.Windows.Forms.TextBox();
            this.txtLoginContrasenia = new System.Windows.Forms.TextBox();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.txtRegistrarNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRespuestaRegistro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(162, 256);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(476, 256);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtRegistrarUsuario
            // 
            this.txtRegistrarUsuario.Location = new System.Drawing.Point(151, 141);
            this.txtRegistrarUsuario.Name = "txtRegistrarUsuario";
            this.txtRegistrarUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtRegistrarUsuario.TabIndex = 2;
            // 
            // txtRegistrarConstrasenia
            // 
            this.txtRegistrarConstrasenia.Location = new System.Drawing.Point(151, 184);
            this.txtRegistrarConstrasenia.Name = "txtRegistrarConstrasenia";
            this.txtRegistrarConstrasenia.Size = new System.Drawing.Size(100, 20);
            this.txtRegistrarConstrasenia.TabIndex = 3;
            // 
            // txtLoginContrasenia
            // 
            this.txtLoginContrasenia.Location = new System.Drawing.Point(466, 184);
            this.txtLoginContrasenia.Name = "txtLoginContrasenia";
            this.txtLoginContrasenia.Size = new System.Drawing.Size(100, 20);
            this.txtLoginContrasenia.TabIndex = 4;
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.Location = new System.Drawing.Point(466, 141);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtLoginUsuario.TabIndex = 5;
            // 
            // txtRegistrarNombre
            // 
            this.txtRegistrarNombre.AutoSize = true;
            this.txtRegistrarNombre.Location = new System.Drawing.Point(84, 141);
            this.txtRegistrarNombre.Name = "txtRegistrarNombre";
            this.txtRegistrarNombre.Size = new System.Drawing.Size(43, 13);
            this.txtRegistrarNombre.TabIndex = 6;
            this.txtRegistrarNombre.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Usuario";
            // 
            // txtRespuestaRegistro
            // 
            this.txtRespuestaRegistro.AutoSize = true;
            this.txtRespuestaRegistro.Location = new System.Drawing.Point(128, 227);
            this.txtRespuestaRegistro.Name = "txtRespuestaRegistro";
            this.txtRespuestaRegistro.Size = new System.Drawing.Size(153, 13);
            this.txtRespuestaRegistro.TabIndex = 10;
            this.txtRespuestaRegistro.Text = "Usuario creado correctamente!";
            this.txtRespuestaRegistro.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRespuestaRegistro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegistrarNombre);
            this.Controls.Add(this.txtLoginUsuario);
            this.Controls.Add(this.txtLoginContrasenia);
            this.Controls.Add(this.txtRegistrarConstrasenia);
            this.Controls.Add(this.txtRegistrarUsuario);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtRegistrarUsuario;
        private System.Windows.Forms.TextBox txtRegistrarConstrasenia;
        private System.Windows.Forms.TextBox txtLoginContrasenia;
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.Label txtRegistrarNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtRespuestaRegistro;
    }
}

