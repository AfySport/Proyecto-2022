namespace Afy
{
    partial class consultarEquipos
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxFiltrar = new System.Windows.Forms.ComboBox();
            this.cbxDeportesCuadros = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxDeportes = new System.Windows.Forms.ComboBox();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.cbxPaises = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cmbLigas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 113);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consultar equipos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(706, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 59);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "---------",
            "Selecciones",
            "Cuadros"});
            this.comboBox1.Location = new System.Drawing.Point(223, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(219, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Consultar por...";
            // 
            // cbxFiltrar
            // 
            this.cbxFiltrar.FormattingEnabled = true;
            this.cbxFiltrar.Items.AddRange(new object[] {
            "Deportes",
            "Paises"});
            this.cbxFiltrar.Location = new System.Drawing.Point(366, 180);
            this.cbxFiltrar.Name = "cbxFiltrar";
            this.cbxFiltrar.Size = new System.Drawing.Size(131, 21);
            this.cbxFiltrar.TabIndex = 7;
            this.cbxFiltrar.Visible = false;
            this.cbxFiltrar.SelectedIndexChanged += new System.EventHandler(this.cbxSelecciones_SelectedIndexChanged);
            this.cbxFiltrar.SelectionChangeCommitted += new System.EventHandler(this.cbxSelecciones_SelectionChangeCommitted);
            // 
            // cbxDeportesCuadros
            // 
            this.cbxDeportesCuadros.FormattingEnabled = true;
            this.cbxDeportesCuadros.Location = new System.Drawing.Point(366, 128);
            this.cbxDeportesCuadros.Name = "cbxDeportesCuadros";
            this.cbxDeportesCuadros.Size = new System.Drawing.Size(131, 21);
            this.cbxDeportesCuadros.TabIndex = 10;
            this.cbxDeportesCuadros.Visible = false;
            this.cbxDeportesCuadros.SelectedIndexChanged += new System.EventHandler(this.cbxCuadros_SelectedIndexChanged);
            this.cbxDeportesCuadros.SelectionChangeCommitted += new System.EventHandler(this.cbxDeportesCuadros_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(518, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "               ";
            this.label3.Visible = false;
            // 
            // cbxDeportes
            // 
            this.cbxDeportes.FormattingEnabled = true;
            this.cbxDeportes.Items.AddRange(new object[] {
            "Futbol",
            "Cricket"});
            this.cbxDeportes.Location = new System.Drawing.Point(522, 148);
            this.cbxDeportes.Name = "cbxDeportes";
            this.cbxDeportes.Size = new System.Drawing.Size(131, 21);
            this.cbxDeportes.TabIndex = 12;
            this.cbxDeportes.Visible = false;
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMostrar.Location = new System.Drawing.Point(362, 102);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(101, 20);
            this.lblMostrar.TabIndex = 13;
            this.lblMostrar.Text = "                       ";
            // 
            // cbxPaises
            // 
            this.cbxPaises.FormattingEnabled = true;
            this.cbxPaises.Location = new System.Drawing.Point(522, 121);
            this.cbxPaises.Name = "cbxPaises";
            this.cbxPaises.Size = new System.Drawing.Size(131, 21);
            this.cbxPaises.TabIndex = 14;
            this.cbxPaises.Visible = false;
            this.cbxPaises.SelectedIndexChanged += new System.EventHandler(this.cbxPaises_SelectedIndexChanged);
            this.cbxPaises.SelectionChangeCommitted += new System.EventHandler(this.cbxPaises_SelectionChangeCommitted);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(199, 265);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(606, 471);
            this.dataGridView2.TabIndex = 15;
            // 
            // cmbLigas
            // 
            this.cmbLigas.FormattingEnabled = true;
            this.cmbLigas.Location = new System.Drawing.Point(523, 175);
            this.cmbLigas.Name = "cmbLigas";
            this.cmbLigas.Size = new System.Drawing.Size(130, 21);
            this.cmbLigas.TabIndex = 16;
            this.cmbLigas.Visible = false;
            // 
            // consultarEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(55)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1079, 761);
            this.Controls.Add(this.cmbLigas);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.cbxPaises);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.cbxDeportes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxDeportesCuadros);
            this.Controls.Add(this.cbxFiltrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "consultarEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consultarEquipos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxFiltrar;
        private System.Windows.Forms.ComboBox cbxDeportesCuadros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxDeportes;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.ComboBox cbxPaises;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cmbLigas;
    }
}