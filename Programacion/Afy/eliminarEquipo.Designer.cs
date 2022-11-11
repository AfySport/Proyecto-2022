namespace Afy
{
    partial class eliminarEquipo
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
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbxEquipos = new System.Windows.Forms.ComboBox();
            this.cbxLigas = new System.Windows.Forms.ComboBox();
            this.cbxSeleccion = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtIdEliminar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 108);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(241, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 113);
            this.label2.TabIndex = 2;
            this.label2.Text = "Eliminar equipos";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox2.Location = new System.Drawing.Point(208, 264);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(96, 20);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Seleccion";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(208, 238);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 20);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Cuadro";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbxEquipos
            // 
            this.cbxEquipos.FormattingEnabled = true;
            this.cbxEquipos.Location = new System.Drawing.Point(660, 253);
            this.cbxEquipos.Name = "cbxEquipos";
            this.cbxEquipos.Size = new System.Drawing.Size(133, 21);
            this.cbxEquipos.TabIndex = 21;
            this.cbxEquipos.Visible = false;
            // 
            // cbxLigas
            // 
            this.cbxLigas.FormattingEnabled = true;
            this.cbxLigas.Location = new System.Drawing.Point(493, 253);
            this.cbxLigas.Name = "cbxLigas";
            this.cbxLigas.Size = new System.Drawing.Size(133, 21);
            this.cbxLigas.TabIndex = 20;
            this.cbxLigas.Visible = false;
            this.cbxLigas.SelectionChangeCommitted += new System.EventHandler(this.cbxLigas_SelectionChangeCommitted_1);
            // 
            // cbxSeleccion
            // 
            this.cbxSeleccion.FormattingEnabled = true;
            this.cbxSeleccion.Location = new System.Drawing.Point(493, 253);
            this.cbxSeleccion.Name = "cbxSeleccion";
            this.cbxSeleccion.Size = new System.Drawing.Size(133, 21);
            this.cbxSeleccion.TabIndex = 19;
            this.cbxSeleccion.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fútbol",
            "Cricket",
            "Basket",
            "Hockey",
            "Tenis",
            "Badminton",
            "VoleiBol",
            "PingPong",
            "Rugby",
            "Boxeo",
            "HandBall",
            "Beisball"});
            this.comboBox1.Location = new System.Drawing.Point(343, 253);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(96, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Eliminar un...";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(77, 346);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(884, 323);
            this.dataGridView1.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 34);
            this.button1.TabIndex = 24;
            this.button1.Text = "Comprobar jugadores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(634, 692);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 30);
            this.button2.TabIndex = 25;
            this.button2.Text = "Eliminar equipo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtIdEliminar
            // 
            this.txtIdEliminar.Location = new System.Drawing.Point(464, 698);
            this.txtIdEliminar.Name = "txtIdEliminar";
            this.txtIdEliminar.Size = new System.Drawing.Size(139, 20);
            this.txtIdEliminar.TabIndex = 26;
            this.txtIdEliminar.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(298, 699);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "                   ";
            // 
            // eliminarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(55)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1079, 761);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdEliminar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxEquipos);
            this.Controls.Add(this.cbxLigas);
            this.Controls.Add(this.cbxSeleccion);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "eliminarEquipo";
            this.Text = "eliminarEquipo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cbxEquipos;
        private System.Windows.Forms.ComboBox cbxLigas;
        private System.Windows.Forms.ComboBox cbxSeleccion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtIdEliminar;
        private System.Windows.Forms.Label label4;
    }
}