namespace Afy
{
    partial class crearEquipo
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxLigas = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxDeporte = new System.Windows.Forms.ComboBox();
            this.lblLigas = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(313, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 113);
            this.label1.TabIndex = 1;
            this.label1.Text = "Crear Equipo";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(547, 255);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 28);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Selección";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox2.Location = new System.Drawing.Point(547, 289);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(96, 28);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Equipo";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(313, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "¿Qué desea crear?";
            // 
            // cbxLigas
            // 
            this.cbxLigas.Enabled = false;
            this.cbxLigas.FormattingEnabled = true;
            this.cbxLigas.Location = new System.Drawing.Point(483, 500);
            this.cbxLigas.Name = "cbxLigas";
            this.cbxLigas.Size = new System.Drawing.Size(150, 21);
            this.cbxLigas.TabIndex = 5;
            this.cbxLigas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(483, 387);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(375, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(375, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Disciplina";
            // 
            // cbxDeporte
            // 
            this.cbxDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDeporte.FormattingEnabled = true;
            this.cbxDeporte.Items.AddRange(new object[] {
            "Futbol",
            "Cricket",
            "Basket",
            "Hockey",
            "Tenis",
            "Badminton",
            "Voleibol",
            "PingPong",
            "Rugby",
            "Boxeo",
            "HandBall",
            "Beisball"});
            this.cbxDeporte.Location = new System.Drawing.Point(483, 439);
            this.cbxDeporte.Name = "cbxDeporte";
            this.cbxDeporte.Size = new System.Drawing.Size(150, 23);
            this.cbxDeporte.TabIndex = 10;
            this.cbxDeporte.SelectedIndexChanged += new System.EventHandler(this.cbxDeporte_SelectedIndexChanged);
            this.cbxDeporte.SelectionChangeCommitted += new System.EventHandler(this.cbxDeporte_SelectionChangeCommitted);
            // 
            // lblLigas
            // 
            this.lblLigas.AutoSize = true;
            this.lblLigas.Enabled = false;
            this.lblLigas.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLigas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLigas.Location = new System.Drawing.Point(375, 488);
            this.lblLigas.Name = "lblLigas";
            this.lblLigas.Size = new System.Drawing.Size(51, 30);
            this.lblLigas.TabIndex = 11;
            this.lblLigas.Text = "Liga";
            // 
            // btnCrear
            // 
            this.btnCrear.Enabled = false;
            this.btnCrear.Location = new System.Drawing.Point(428, 602);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(145, 49);
            this.btnCrear.TabIndex = 12;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(375, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Pais";
            // 
            // txtPais
            // 
            this.txtPais.Enabled = false;
            this.txtPais.Location = new System.Drawing.Point(483, 552);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(150, 20);
            this.txtPais.TabIndex = 14;
            // 
            // crearEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(55)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1079, 761);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblLigas);
            this.Controls.Add(this.cbxDeporte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cbxLigas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "crearEquipo";
            this.Text = "crearEquipo";
            this.Load += new System.EventHandler(this.crearEquipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxLigas;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxDeporte;
        private System.Windows.Forms.Label lblLigas;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPais;
    }
}