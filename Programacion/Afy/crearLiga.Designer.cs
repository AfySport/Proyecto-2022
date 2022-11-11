namespace Afy
{
    partial class crearLiga
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.cbxDeporte = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(350, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 113);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Liga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(381, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(381, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Deporte:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(381, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "País:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(490, 283);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(157, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(490, 370);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(157, 20);
            this.txtPais.TabIndex = 7;
            // 
            // cbxDeporte
            // 
            this.cbxDeporte.FormattingEnabled = true;
            this.cbxDeporte.Items.AddRange(new object[] {
            "Fútbol",
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
            this.cbxDeporte.Location = new System.Drawing.Point(490, 327);
            this.cbxDeporte.Name = "cbxDeporte";
            this.cbxDeporte.Size = new System.Drawing.Size(157, 21);
            this.cbxDeporte.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // crearLiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(55)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1079, 761);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxDeporte);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "crearLiga";
            this.Text = "crearLiga";
            this.Load += new System.EventHandler(this.crearLiga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.ComboBox cbxDeporte;
        private System.Windows.Forms.Button button1;
    }
}