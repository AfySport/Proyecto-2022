namespace Afy
{
    partial class afyAdminConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(afyAdminConsulta));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chbSuscritos = new System.Windows.Forms.CheckBox();
            this.chbNoSuscritos = new System.Windows.Forms.CheckBox();
            this.chbAdmin = new System.Windows.Forms.CheckBox();
            this.chbUsuarios = new System.Windows.Forms.CheckBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblEmailEliminar = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuarioEliminar = new System.Windows.Forms.Label();
            this.rbSuscrito = new System.Windows.Forms.RadioButton();
            this.rbNoSuscrito = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx1 = new System.Windows.Forms.CheckBox();
            this.cbx2 = new System.Windows.Forms.CheckBox();
            this.lblAdminNuevo = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.lblSacarAdmin = new System.Windows.Forms.Label();
            this.btnSacarAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta de Usuarios, ver...";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(713, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "USUARIOS";
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.Location = new System.Drawing.Point(594, 100);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(117, 13);
            this.lblEliminar.TabIndex = 7;
            this.lblEliminar.Text = "ELIMINAR USUARIOS";
            this.lblEliminar.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(450, 313);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // chbSuscritos
            // 
            this.chbSuscritos.AutoSize = true;
            this.chbSuscritos.Location = new System.Drawing.Point(229, 18);
            this.chbSuscritos.Name = "chbSuscritos";
            this.chbSuscritos.Size = new System.Drawing.Size(113, 17);
            this.chbSuscritos.TabIndex = 9;
            this.chbSuscritos.Text = "Usuarios Suscritos";
            this.chbSuscritos.UseVisualStyleBackColor = true;
            this.chbSuscritos.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chbNoSuscritos
            // 
            this.chbNoSuscritos.AutoSize = true;
            this.chbNoSuscritos.Location = new System.Drawing.Point(229, 34);
            this.chbNoSuscritos.Name = "chbNoSuscritos";
            this.chbNoSuscritos.Size = new System.Drawing.Size(130, 17);
            this.chbNoSuscritos.TabIndex = 10;
            this.chbNoSuscritos.Text = "Usuarios NO suscritos";
            this.chbNoSuscritos.UseVisualStyleBackColor = true;
            this.chbNoSuscritos.CheckedChanged += new System.EventHandler(this.chbNoSuscritos_CheckedChanged);
            // 
            // chbAdmin
            // 
            this.chbAdmin.AutoSize = true;
            this.chbAdmin.Location = new System.Drawing.Point(229, 50);
            this.chbAdmin.Name = "chbAdmin";
            this.chbAdmin.Size = new System.Drawing.Size(100, 17);
            this.chbAdmin.TabIndex = 11;
            this.chbAdmin.Text = "Administradores";
            this.chbAdmin.UseVisualStyleBackColor = true;
            this.chbAdmin.CheckedChanged += new System.EventHandler(this.chbAdmin_CheckedChanged);
            // 
            // chbUsuarios
            // 
            this.chbUsuarios.AutoSize = true;
            this.chbUsuarios.Location = new System.Drawing.Point(229, 66);
            this.chbUsuarios.Name = "chbUsuarios";
            this.chbUsuarios.Size = new System.Drawing.Size(114, 17);
            this.chbUsuarios.TabIndex = 12;
            this.chbUsuarios.Text = "Todos los usuarios";
            this.chbUsuarios.UseVisualStyleBackColor = true;
            this.chbUsuarios.CheckedChanged += new System.EventHandler(this.chbUsuarios_CheckedChanged);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(586, 125);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(160, 20);
            this.txtMail.TabIndex = 13;
            this.txtMail.Visible = false;
            // 
            // lblEmailEliminar
            // 
            this.lblEmailEliminar.AutoSize = true;
            this.lblEmailEliminar.Location = new System.Drawing.Point(509, 128);
            this.lblEmailEliminar.Name = "lblEmailEliminar";
            this.lblEmailEliminar.Size = new System.Drawing.Size(35, 13);
            this.lblEmailEliminar.TabIndex = 14;
            this.lblEmailEliminar.Text = "Email:";
            this.lblEmailEliminar.Visible = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(586, 175);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(160, 20);
            this.txtUsuario.TabIndex = 15;
            this.txtUsuario.Visible = false;
            // 
            // lblUsuarioEliminar
            // 
            this.lblUsuarioEliminar.AutoSize = true;
            this.lblUsuarioEliminar.Location = new System.Drawing.Point(509, 178);
            this.lblUsuarioEliminar.Name = "lblUsuarioEliminar";
            this.lblUsuarioEliminar.Size = new System.Drawing.Size(46, 13);
            this.lblUsuarioEliminar.TabIndex = 16;
            this.lblUsuarioEliminar.Text = "Usuario:";
            this.lblUsuarioEliminar.Visible = false;
            // 
            // rbSuscrito
            // 
            this.rbSuscrito.Location = new System.Drawing.Point(623, 245);
            this.rbSuscrito.Name = "rbSuscrito";
            this.rbSuscrito.Size = new System.Drawing.Size(107, 17);
            this.rbSuscrito.TabIndex = 0;
            this.rbSuscrito.TabStop = true;
            this.rbSuscrito.Text = "U-Suscrito";
            this.rbSuscrito.UseVisualStyleBackColor = true;
            this.rbSuscrito.Visible = false;
            // 
            // rbNoSuscrito
            // 
            this.rbNoSuscrito.AutoSize = true;
            this.rbNoSuscrito.Location = new System.Drawing.Point(623, 265);
            this.rbNoSuscrito.Name = "rbNoSuscrito";
            this.rbNoSuscrito.Size = new System.Drawing.Size(88, 17);
            this.rbNoSuscrito.TabIndex = 18;
            this.rbNoSuscrito.TabStop = true;
            this.rbNoSuscrito.Text = "U-NoSuscrito";
            this.rbNoSuscrito.UseVisualStyleBackColor = true;
            this.rbNoSuscrito.Visible = false;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(623, 285);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(54, 17);
            this.rbAdmin.TabIndex = 19;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            this.rbAdmin.Visible = false;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(509, 269);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(85, 13);
            this.lblTipoUsuario.TabIndex = 21;
            this.lblTipoUsuario.Text = "Tipo de Usuario:";
            this.lblTipoUsuario.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(586, 344);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 23);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar Usuario";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tareas:";
            // 
            // cbx1
            // 
            this.cbx1.AutoSize = true;
            this.cbx1.Location = new System.Drawing.Point(553, 30);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(106, 17);
            this.cbx1.TabIndex = 24;
            this.cbx1.Text = "Eliminar Usuarios";
            this.cbx1.UseVisualStyleBackColor = true;
            this.cbx1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // cbx2
            // 
            this.cbx2.AutoSize = true;
            this.cbx2.Location = new System.Drawing.Point(553, 50);
            this.cbx2.Name = "cbx2";
            this.cbx2.Size = new System.Drawing.Size(83, 17);
            this.cbx2.TabIndex = 25;
            this.cbx2.Text = "Crear Admin";
            this.cbx2.UseVisualStyleBackColor = true;
            this.cbx2.CheckedChanged += new System.EventHandler(this.cbx2_CheckedChanged);
            // 
            // lblAdminNuevo
            // 
            this.lblAdminNuevo.AutoSize = true;
            this.lblAdminNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminNuevo.Location = new System.Drawing.Point(594, 100);
            this.lblAdminNuevo.Name = "lblAdminNuevo";
            this.lblAdminNuevo.Size = new System.Drawing.Size(96, 13);
            this.lblAdminNuevo.TabIndex = 26;
            this.lblAdminNuevo.Text = "Creación de Admin";
            this.lblAdminNuevo.Visible = false;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(586, 216);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(125, 23);
            this.btnCrear.TabIndex = 27;
            this.btnCrear.Text = "Crear nuevo Admin";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Visible = false;
            this.btnCrear.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(553, 70);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(145, 17);
            this.cb3.TabIndex = 28;
            this.cb3.Text = "Sacar privilegio de Admin";
            this.cb3.UseVisualStyleBackColor = true;
            this.cb3.CheckedChanged += new System.EventHandler(this.cb3_CheckedChanged);
            // 
            // lblSacarAdmin
            // 
            this.lblSacarAdmin.AutoSize = true;
            this.lblSacarAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSacarAdmin.Location = new System.Drawing.Point(594, 100);
            this.lblSacarAdmin.Name = "lblSacarAdmin";
            this.lblSacarAdmin.Size = new System.Drawing.Size(107, 13);
            this.lblSacarAdmin.TabIndex = 29;
            this.lblSacarAdmin.Text = "Eliminación de Admin";
            this.lblSacarAdmin.Visible = false;
            // 
            // btnSacarAdmin
            // 
            this.btnSacarAdmin.Location = new System.Drawing.Point(586, 216);
            this.btnSacarAdmin.Name = "btnSacarAdmin";
            this.btnSacarAdmin.Size = new System.Drawing.Size(125, 23);
            this.btnSacarAdmin.TabIndex = 30;
            this.btnSacarAdmin.Text = "Remover administrador";
            this.btnSacarAdmin.UseVisualStyleBackColor = true;
            this.btnSacarAdmin.Visible = false;
            this.btnSacarAdmin.Click += new System.EventHandler(this.btnSacarAdmin_Click);
            // 
            // afyAdminConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSacarAdmin);
            this.Controls.Add(this.lblSacarAdmin);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblAdminNuevo);
            this.Controls.Add(this.cbx2);
            this.Controls.Add(this.cbx1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.rbNoSuscrito);
            this.Controls.Add(this.rbSuscrito);
            this.Controls.Add(this.lblUsuarioEliminar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblEmailEliminar);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.chbUsuarios);
            this.Controls.Add(this.chbAdmin);
            this.Controls.Add(this.chbNoSuscritos);
            this.Controls.Add(this.chbSuscritos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "afyAdminConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "afyAdminConsulta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.afyAdminConsulta_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chbSuscritos;
        private System.Windows.Forms.CheckBox chbNoSuscritos;
        private System.Windows.Forms.CheckBox chbAdmin;
        private System.Windows.Forms.CheckBox chbUsuarios;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblEmailEliminar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuarioEliminar;
        private System.Windows.Forms.RadioButton rbSuscrito;
        private System.Windows.Forms.RadioButton rbNoSuscrito;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbx1;
        private System.Windows.Forms.CheckBox cbx2;
        private System.Windows.Forms.Label lblAdminNuevo;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.Label lblSacarAdmin;
        private System.Windows.Forms.Button btnSacarAdmin;
    }
}