namespace Afy
{
    partial class AfyPublicidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AfyPublicidad));
            this.btnExaminar = new System.Windows.Forms.Button();
            this.ofdImg = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAgregar = new System.Windows.Forms.CheckBox();
            this.cbEliminar = new System.Windows.Forms.CheckBox();
            this.cbConsultar = new System.Windows.Forms.CheckBox();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.publicidadMostrar = new System.Windows.Forms.ImageList(this.components);
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExaminar
            // 
            this.btnExaminar.FlatAppearance.BorderSize = 0;
            this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExaminar.Location = new System.Drawing.Point(98, 402);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(128, 23);
            this.btnExaminar.TabIndex = 0;
            this.btnExaminar.Text = "Abrir...";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Visible = false;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // ofdImg
            // 
            this.ofdImg.FileName = "ofdImagenes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "¿Qué desea hacer?";
            // 
            // cbAgregar
            // 
            this.cbAgregar.AutoSize = true;
            this.cbAgregar.Location = new System.Drawing.Point(158, 12);
            this.cbAgregar.Name = "cbAgregar";
            this.cbAgregar.Size = new System.Drawing.Size(167, 17);
            this.cbAgregar.TabIndex = 2;
            this.cbAgregar.Text = "Agregar Imagen de publicidad";
            this.cbAgregar.UseVisualStyleBackColor = true;
            this.cbAgregar.CheckedChanged += new System.EventHandler(this.chAgregar_CheckedChanged);
            // 
            // cbEliminar
            // 
            this.cbEliminar.AutoSize = true;
            this.cbEliminar.Location = new System.Drawing.Point(158, 58);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(113, 17);
            this.cbEliminar.TabIndex = 3;
            this.cbEliminar.Text = "Eliminar publicidad";
            this.cbEliminar.UseVisualStyleBackColor = true;
            this.cbEliminar.CheckedChanged += new System.EventHandler(this.cbEliminar_CheckedChanged);
            // 
            // cbConsultar
            // 
            this.cbConsultar.AutoSize = true;
            this.cbConsultar.Location = new System.Drawing.Point(158, 35);
            this.cbConsultar.Name = "cbConsultar";
            this.cbConsultar.Size = new System.Drawing.Size(118, 17);
            this.cbConsultar.TabIndex = 4;
            this.cbConsultar.Text = "Consultar imagenes";
            this.cbConsultar.UseVisualStyleBackColor = true;
            this.cbConsultar.CheckedChanged += new System.EventHandler(this.cbConsultar_CheckedChanged);
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Location = new System.Drawing.Point(48, 101);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(237, 26);
            this.lblMostrar.TabIndex = 6;
            this.lblMostrar.Text = "Suba la imagen (Formatos aceptados .png y .jpg)\r\nDe preferencia 256 x 256\r\n";
            this.lblMostrar.Visible = false;
            // 
            // publicidadMostrar
            // 
            this.publicidadMostrar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("publicidadMostrar.ImageStream")));
            this.publicidadMostrar.TransparentColor = System.Drawing.Color.Transparent;
            this.publicidadMostrar.Images.SetKeyName(0, "logo_empresa.png");
            this.publicidadMostrar.Images.SetKeyName(1, "logo_empresa_corto.png");
            this.publicidadMostrar.Images.SetKeyName(2, "logoApp.png");
            this.publicidadMostrar.Images.SetKeyName(3, "logoappbueno.png");
            this.publicidadMostrar.Images.SetKeyName(4, "logoempresa.png");
            this.publicidadMostrar.Images.SetKeyName(5, "logo-sin-texto.png");
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(40, 140);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(256, 256);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 7;
            this.pb1.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(357, 240);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 48);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Añadir como nueva publicidad";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Visible = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // AfyPublicidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.cbConsultar);
            this.Controls.Add(this.cbEliminar);
            this.Controls.Add(this.cbAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExaminar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AfyPublicidad";
            this.Text = "AfyPublicidad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AfyPublicidad_FormClosed);
            this.Load += new System.EventHandler(this.AfyPublicidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.OpenFileDialog ofdImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbAgregar;
        private System.Windows.Forms.CheckBox cbEliminar;
        private System.Windows.Forms.CheckBox cbConsultar;
        private System.Windows.Forms.Label lblMostrar;
        public System.Windows.Forms.ImageList publicidadMostrar;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Button btnAgregar;
    }
}