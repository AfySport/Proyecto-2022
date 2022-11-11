namespace Afy
{
    partial class inicioPanel
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
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Nirmala UI", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(147, 423);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(679, 128);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "                        ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFecha.Location = new System.Drawing.Point(25, 534);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(302, 73);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "               ";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(302, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 86);
            this.label1.TabIndex = 3;
            this.label1.Text = "Panel de eventos ";
            // 
            // inicioPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(55)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1079, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inicioPanel";
            this.Text = "inicioPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label1;
    }
}