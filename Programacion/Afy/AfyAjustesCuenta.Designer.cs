namespace Afy
{
    partial class AfyAjustesCuenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNoSuscrito = new System.Windows.Forms.Label();
            this.lblSuscrito = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(336, 75);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(135, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(336, 215);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.ReadOnly = true;
            this.txtContrasenia.Size = new System.Drawing.Size(135, 20);
            this.txtContrasenia.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(336, 142);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(135, 20);
            this.txtUsuario.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Datos de cuenta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Estado:";
            // 
            // lblNoSuscrito
            // 
            this.lblNoSuscrito.AutoSize = true;
            this.lblNoSuscrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSuscrito.ForeColor = System.Drawing.Color.Crimson;
            this.lblNoSuscrito.Location = new System.Drawing.Point(333, 276);
            this.lblNoSuscrito.Name = "lblNoSuscrito";
            this.lblNoSuscrito.Size = new System.Drawing.Size(100, 16);
            this.lblNoSuscrito.TabIndex = 8;
            this.lblNoSuscrito.Text = "NO SUSCRITO";
            this.lblNoSuscrito.Visible = false;
            // 
            // lblSuscrito
            // 
            this.lblSuscrito.AutoSize = true;
            this.lblSuscrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuscrito.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblSuscrito.Location = new System.Drawing.Point(333, 276);
            this.lblSuscrito.Name = "lblSuscrito";
            this.lblSuscrito.Size = new System.Drawing.Size(150, 16);
            this.lblSuscrito.TabIndex = 9;
            this.lblSuscrito.Text = "SUSCRIPCIÓN ACTIVA";
            this.lblSuscrito.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(317, 341);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(83, 25);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.Red;
            this.lblAdmin.Location = new System.Drawing.Point(333, 276);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(104, 16);
            this.lblAdmin.TabIndex = 11;
            this.lblAdmin.Text = "Administrador";
            this.lblAdmin.Visible = false;
            // 
            // AfyAjustesCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 761);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblSuscrito);
            this.Controls.Add(this.lblNoSuscrito);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AfyAjustesCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AfyAjustesCuenta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AfyAjustesCuenta_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNoSuscrito;
        private System.Windows.Forms.Label lblSuscrito;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Timer temporizador;
    }
}