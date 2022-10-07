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
            this.lblMostrar = new System.Windows.Forms.Label();
            this.publicidadMostrar = new System.Windows.Forms.ImageList(this.components);
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNombrePublicidad = new System.Windows.Forms.Label();
            this.txtNombrePublicidad = new System.Windows.Forms.TextBox();
            this.lblCantidadImagenes = new System.Windows.Forms.Label();
            this.txtCantImagenes = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdImagen = new System.Windows.Forms.TextBox();
            this.txtNombrePubli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEliminarPublicidad = new System.Windows.Forms.Label();
            this.txtEliminarPublicidad = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.lblIdImagenEliminar = new System.Windows.Forms.Label();
            this.btnEliminarPublicidad = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
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
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Location = new System.Drawing.Point(48, 101);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(199, 26);
            this.lblMostrar.TabIndex = 6;
            this.lblMostrar.Text = "Suba la imagen (Formato aceptado .png)\r\nDe preferencia 256 x 256\r\n";
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
            this.publicidadMostrar.Images.SetKeyName(4, "logo-sin-texto.png");
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
            this.btnAgregar.Location = new System.Drawing.Point(383, 189);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 48);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Añadir como nueva publicidad";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Visible = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblNombrePublicidad
            // 
            this.lblNombrePublicidad.AutoSize = true;
            this.lblNombrePublicidad.Location = new System.Drawing.Point(330, 150);
            this.lblNombrePublicidad.Name = "lblNombrePublicidad";
            this.lblNombrePublicidad.Size = new System.Drawing.Size(99, 13);
            this.lblNombrePublicidad.TabIndex = 9;
            this.lblNombrePublicidad.Text = "Nombre Publicidad:";
            this.lblNombrePublicidad.Visible = false;
            // 
            // txtNombrePublicidad
            // 
            this.txtNombrePublicidad.Location = new System.Drawing.Point(445, 147);
            this.txtNombrePublicidad.Name = "txtNombrePublicidad";
            this.txtNombrePublicidad.Size = new System.Drawing.Size(124, 20);
            this.txtNombrePublicidad.TabIndex = 10;
            this.txtNombrePublicidad.Visible = false;
            // 
            // lblCantidadImagenes
            // 
            this.lblCantidadImagenes.AutoSize = true;
            this.lblCantidadImagenes.Location = new System.Drawing.Point(323, 145);
            this.lblCantidadImagenes.Name = "lblCantidadImagenes";
            this.lblCantidadImagenes.Size = new System.Drawing.Size(166, 13);
            this.lblCantidadImagenes.TabIndex = 11;
            this.lblCantidadImagenes.Text = "Cantidad de imagenes publicidad:\r\n";
            this.lblCantidadImagenes.Visible = false;
            // 
            // txtCantImagenes
            // 
            this.txtCantImagenes.Location = new System.Drawing.Point(507, 142);
            this.txtCantImagenes.Name = "txtCantImagenes";
            this.txtCantImagenes.ReadOnly = true;
            this.txtCantImagenes.Size = new System.Drawing.Size(100, 20);
            this.txtCantImagenes.TabIndex = 12;
            this.txtCantImagenes.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(410, 173);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(105, 23);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(40, 402);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(105, 23);
            this.btnAnterior.TabIndex = 14;
            this.btnAnterior.Text = "Anterior publicidad";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Visible = false;
            this.btnAnterior.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(184, 402);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(112, 23);
            this.btnSiguiente.TabIndex = 15;
            this.btnSiguiente.Text = "Siguiente publicidad";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Visible = false;
            this.btnSiguiente.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(380, 275);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(22, 13);
            this.lblContador.TabIndex = 16;
            this.lblContador.Text = "     ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "idImagen:";
            this.label2.Visible = false;
            // 
            // txtIdImagen
            // 
            this.txtIdImagen.Location = new System.Drawing.Point(446, 224);
            this.txtIdImagen.Name = "txtIdImagen";
            this.txtIdImagen.ReadOnly = true;
            this.txtIdImagen.Size = new System.Drawing.Size(123, 20);
            this.txtIdImagen.TabIndex = 18;
            this.txtIdImagen.Visible = false;
            // 
            // txtNombrePubli
            // 
            this.txtNombrePubli.Location = new System.Drawing.Point(446, 268);
            this.txtNombrePubli.Name = "txtNombrePubli";
            this.txtNombrePubli.ReadOnly = true;
            this.txtNombrePubli.Size = new System.Drawing.Size(123, 20);
            this.txtNombrePubli.TabIndex = 19;
            this.txtNombrePubli.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nombre:";
            this.label3.Visible = false;
            // 
            // lblEliminarPublicidad
            // 
            this.lblEliminarPublicidad.AutoSize = true;
            this.lblEliminarPublicidad.Location = new System.Drawing.Point(332, 336);
            this.lblEliminarPublicidad.Name = "lblEliminarPublicidad";
            this.lblEliminarPublicidad.Size = new System.Drawing.Size(97, 13);
            this.lblEliminarPublicidad.TabIndex = 21;
            this.lblEliminarPublicidad.Text = "Eliminar publicidad:";
            this.lblEliminarPublicidad.Visible = false;
            // 
            // txtEliminarPublicidad
            // 
            this.txtEliminarPublicidad.Location = new System.Drawing.Point(445, 333);
            this.txtEliminarPublicidad.Name = "txtEliminarPublicidad";
            this.txtEliminarPublicidad.Size = new System.Drawing.Size(124, 20);
            this.txtEliminarPublicidad.TabIndex = 22;
            this.txtEliminarPublicidad.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(167, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 17);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Agregar Imagen";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(167, 53);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(108, 17);
            this.checkBox2.TabIndex = 26;
            this.checkBox2.Text = "Consultar Imagen";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // lblIdImagenEliminar
            // 
            this.lblIdImagenEliminar.AutoSize = true;
            this.lblIdImagenEliminar.Location = new System.Drawing.Point(575, 336);
            this.lblIdImagenEliminar.Name = "lblIdImagenEliminar";
            this.lblIdImagenEliminar.Size = new System.Drawing.Size(59, 13);
            this.lblIdImagenEliminar.TabIndex = 27;
            this.lblIdImagenEliminar.Text = "(id Imagen)";
            this.lblIdImagenEliminar.Visible = false;
            // 
            // btnEliminarPublicidad
            // 
            this.btnEliminarPublicidad.Location = new System.Drawing.Point(414, 373);
            this.btnEliminarPublicidad.Name = "btnEliminarPublicidad";
            this.btnEliminarPublicidad.Size = new System.Drawing.Size(105, 23);
            this.btnEliminarPublicidad.TabIndex = 28;
            this.btnEliminarPublicidad.Text = "Eliminar";
            this.btnEliminarPublicidad.UseVisualStyleBackColor = true;
            this.btnEliminarPublicidad.Visible = false;
            this.btnEliminarPublicidad.Click += new System.EventHandler(this.btnEliminarPublicidad_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(686, 402);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(102, 35);
            this.btnVolver.TabIndex = 29;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Visible = false;
            // 
            // AfyPublicidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminarPublicidad);
            this.Controls.Add(this.lblIdImagenEliminar);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtEliminarPublicidad);
            this.Controls.Add(this.lblEliminarPublicidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombrePubli);
            this.Controls.Add(this.txtIdImagen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtCantImagenes);
            this.Controls.Add(this.lblCantidadImagenes);
            this.Controls.Add(this.txtNombrePublicidad);
            this.Controls.Add(this.lblNombrePublicidad);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lblMostrar);
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
        private System.Windows.Forms.Label lblMostrar;
        public System.Windows.Forms.ImageList publicidadMostrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNombrePublicidad;
        private System.Windows.Forms.TextBox txtNombrePublicidad;
        private System.Windows.Forms.Label lblCantidadImagenes;
        private System.Windows.Forms.TextBox txtCantImagenes;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblContador;
        public System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdImagen;
        private System.Windows.Forms.TextBox txtNombrePubli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEliminarPublicidad;
        private System.Windows.Forms.TextBox txtEliminarPublicidad;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label lblIdImagenEliminar;
        private System.Windows.Forms.Button btnEliminarPublicidad;
        private System.Windows.Forms.Button btnVolver;
    }
}