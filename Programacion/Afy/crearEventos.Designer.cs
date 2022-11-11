namespace Afy
{
    partial class crearEventos
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
            this.cbxSelecciones = new System.Windows.Forms.CheckBox();
            this.cbxIndividual = new System.Windows.Forms.CheckBox();
            this.cbxDeporte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxLocal = new System.Windows.Forms.ComboBox();
            this.cbxVisitante = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAlineacionLocal = new System.Windows.Forms.TextBox();
            this.txtAlineacionVisitante = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxDeporteInvidual = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtIdLocal = new System.Windows.Forms.TextBox();
            this.txtNombreLocal = new System.Windows.Forms.TextBox();
            this.txtApellidoLocal = new System.Windows.Forms.TextBox();
            this.txtApellidoVisitante = new System.Windows.Forms.TextBox();
            this.txtNombreVisitante = new System.Windows.Forms.TextBox();
            this.txtIdVisitante = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.lblEv1 = new System.Windows.Forms.Label();
            this.lblEv2 = new System.Windows.Forms.Label();
            this.lblEv3 = new System.Windows.Forms.Label();
            this.lblEv6 = new System.Windows.Forms.Label();
            this.lblEv5 = new System.Windows.Forms.Label();
            this.lblEv4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(323, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 113);
            this.label1.TabIndex = 2;
            this.label1.Text = "Panel Crear Evento";
            // 
            // cbxSelecciones
            // 
            this.cbxSelecciones.AutoSize = true;
            this.cbxSelecciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelecciones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbxSelecciones.Location = new System.Drawing.Point(25, 112);
            this.cbxSelecciones.Name = "cbxSelecciones";
            this.cbxSelecciones.Size = new System.Drawing.Size(261, 24);
            this.cbxSelecciones.TabIndex = 3;
            this.cbxSelecciones.Text = "Crear evento por selecciones";
            this.cbxSelecciones.UseVisualStyleBackColor = true;
            this.cbxSelecciones.CheckedChanged += new System.EventHandler(this.cbxSelecciones_CheckedChanged);
            // 
            // cbxIndividual
            // 
            this.cbxIndividual.AutoSize = true;
            this.cbxIndividual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIndividual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbxIndividual.Location = new System.Drawing.Point(25, 138);
            this.cbxIndividual.Name = "cbxIndividual";
            this.cbxIndividual.Size = new System.Drawing.Size(210, 24);
            this.cbxIndividual.TabIndex = 4;
            this.cbxIndividual.Text = "Crear evento individual";
            this.cbxIndividual.UseVisualStyleBackColor = true;
            this.cbxIndividual.CheckedChanged += new System.EventHandler(this.cbxIndividual_CheckedChanged);
            // 
            // cbxDeporte
            // 
            this.cbxDeporte.FormattingEnabled = true;
            this.cbxDeporte.Items.AddRange(new object[] {
            "Futbol",
            "Cricket",
            "Basket",
            "Hockey",
            "Badminton",
            "Voleibol",
            "Rugby",
            "Handball",
            "Beisball"});
            this.cbxDeporte.Location = new System.Drawing.Point(512, 164);
            this.cbxDeporte.Name = "cbxDeporte";
            this.cbxDeporte.Size = new System.Drawing.Size(129, 21);
            this.cbxDeporte.TabIndex = 9;
            this.cbxDeporte.Visible = false;
            this.cbxDeporte.SelectedIndexChanged += new System.EventHandler(this.cbxDeporte_SelectedIndexChanged);
            this.cbxDeporte.SelectionChangeCommitted += new System.EventHandler(this.cbxDeporte_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(442, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Deporte";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(442, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Seleccione deporte del evento";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(193, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Seleccion local";
            this.label4.Visible = false;
            // 
            // cbxLocal
            // 
            this.cbxLocal.FormattingEnabled = true;
            this.cbxLocal.Location = new System.Drawing.Point(314, 247);
            this.cbxLocal.Name = "cbxLocal";
            this.cbxLocal.Size = new System.Drawing.Size(121, 21);
            this.cbxLocal.TabIndex = 13;
            this.cbxLocal.Visible = false;
            this.cbxLocal.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cbxLocal.SelectionChangeCommitted += new System.EventHandler(this.cbxLocal_SelectionChangeCommitted);
            // 
            // cbxVisitante
            // 
            this.cbxVisitante.FormattingEnabled = true;
            this.cbxVisitante.Location = new System.Drawing.Point(619, 248);
            this.cbxVisitante.Name = "cbxVisitante";
            this.cbxVisitante.Size = new System.Drawing.Size(121, 21);
            this.cbxVisitante.TabIndex = 15;
            this.cbxVisitante.Visible = false;
            this.cbxVisitante.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(746, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Seleccion visitante";
            this.label5.Visible = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(508, 493);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 16;
            this.dtpFecha.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(359, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fecha de evento";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(363, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Alineacion local";
            this.label7.Visible = false;
            // 
            // txtAlineacionLocal
            // 
            this.txtAlineacionLocal.Location = new System.Drawing.Point(512, 301);
            this.txtAlineacionLocal.Name = "txtAlineacionLocal";
            this.txtAlineacionLocal.Size = new System.Drawing.Size(129, 20);
            this.txtAlineacionLocal.TabIndex = 19;
            this.txtAlineacionLocal.Visible = false;
            // 
            // txtAlineacionVisitante
            // 
            this.txtAlineacionVisitante.Location = new System.Drawing.Point(512, 349);
            this.txtAlineacionVisitante.Name = "txtAlineacionVisitante";
            this.txtAlineacionVisitante.Size = new System.Drawing.Size(129, 20);
            this.txtAlineacionVisitante.TabIndex = 21;
            this.txtAlineacionVisitante.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(363, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Alineacion visitante";
            this.label8.Visible = false;
            // 
            // cbxDeporteInvidual
            // 
            this.cbxDeporteInvidual.FormattingEnabled = true;
            this.cbxDeporteInvidual.Items.AddRange(new object[] {
            "Tenis",
            "PingPong",
            "Boxeo"});
            this.cbxDeporteInvidual.Location = new System.Drawing.Point(477, 141);
            this.cbxDeporteInvidual.Name = "cbxDeporteInvidual";
            this.cbxDeporteInvidual.Size = new System.Drawing.Size(139, 21);
            this.cbxDeporteInvidual.TabIndex = 23;
            this.cbxDeporteInvidual.Visible = false;
            this.cbxDeporteInvidual.SelectedIndexChanged += new System.EventHandler(this.cbxDeporteInvidual_SelectedIndexChanged);
            this.cbxDeporteInvidual.SelectionChangeCommitted += new System.EventHandler(this.cbxDeporteInvidual_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(249, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 18);
            this.label9.TabIndex = 24;
            this.label9.Text = "Jugador local";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(474, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "Deporte individual";
            this.label10.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(147, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(379, 165);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.Visible = false;
            // 
            // txtIdLocal
            // 
            this.txtIdLocal.Location = new System.Drawing.Point(151, 410);
            this.txtIdLocal.Name = "txtIdLocal";
            this.txtIdLocal.Size = new System.Drawing.Size(100, 20);
            this.txtIdLocal.TabIndex = 28;
            this.txtIdLocal.Visible = false;
            // 
            // txtNombreLocal
            // 
            this.txtNombreLocal.Location = new System.Drawing.Point(267, 410);
            this.txtNombreLocal.Name = "txtNombreLocal";
            this.txtNombreLocal.Size = new System.Drawing.Size(104, 20);
            this.txtNombreLocal.TabIndex = 29;
            this.txtNombreLocal.Visible = false;
            // 
            // txtApellidoLocal
            // 
            this.txtApellidoLocal.Location = new System.Drawing.Point(390, 410);
            this.txtApellidoLocal.Name = "txtApellidoLocal";
            this.txtApellidoLocal.Size = new System.Drawing.Size(116, 20);
            this.txtApellidoLocal.TabIndex = 30;
            this.txtApellidoLocal.Visible = false;
            // 
            // txtApellidoVisitante
            // 
            this.txtApellidoVisitante.Location = new System.Drawing.Point(850, 410);
            this.txtApellidoVisitante.Name = "txtApellidoVisitante";
            this.txtApellidoVisitante.Size = new System.Drawing.Size(112, 20);
            this.txtApellidoVisitante.TabIndex = 35;
            this.txtApellidoVisitante.Visible = false;
            // 
            // txtNombreVisitante
            // 
            this.txtNombreVisitante.Location = new System.Drawing.Point(719, 410);
            this.txtNombreVisitante.Name = "txtNombreVisitante";
            this.txtNombreVisitante.Size = new System.Drawing.Size(108, 20);
            this.txtNombreVisitante.TabIndex = 34;
            this.txtNombreVisitante.Visible = false;
            // 
            // txtIdVisitante
            // 
            this.txtIdVisitante.Location = new System.Drawing.Point(592, 410);
            this.txtIdVisitante.Name = "txtIdVisitante";
            this.txtIdVisitante.Size = new System.Drawing.Size(103, 20);
            this.txtIdVisitante.TabIndex = 33;
            this.txtIdVisitante.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(584, 214);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(379, 165);
            this.dataGridView2.TabIndex = 32;
            this.dataGridView2.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(707, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 18);
            this.label11.TabIndex = 31;
            this.label11.Text = "Jugador visitante";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(158, 392);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 15);
            this.label12.TabIndex = 36;
            this.label12.Text = "ID Jug local";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(270, 392);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 15);
            this.label13.TabIndex = 37;
            this.label13.Text = "Nombre Local";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(399, 392);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 15);
            this.label14.TabIndex = 38;
            this.label14.Text = "Apellido Local";
            this.label14.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "Siguiente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(589, 392);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 15);
            this.label15.TabIndex = 40;
            this.label15.Text = "ID Jug visitante";
            this.label15.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(720, 392);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 15);
            this.label16.TabIndex = 41;
            this.label16.Text = "Nombre visitante";
            this.label16.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(847, 392);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 15);
            this.label17.TabIndex = 42;
            this.label17.Text = "Apellido visitante";
            this.label17.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(495, 532);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 32);
            this.button3.TabIndex = 43;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 603);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 34);
            this.button1.TabIndex = 44;
            this.button1.Text = "Evento 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(420, 643);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 34);
            this.button4.TabIndex = 45;
            this.button4.Text = "Evento 2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(420, 683);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 34);
            this.button5.TabIndex = 46;
            this.button5.Text = "Evento 3";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(576, 683);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 34);
            this.button6.TabIndex = 49;
            this.button6.Text = "Evento 6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(576, 643);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 34);
            this.button7.TabIndex = 48;
            this.button7.Text = "Evento 5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(576, 603);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(87, 34);
            this.button8.TabIndex = 47;
            this.button8.Text = "Evento 4";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // lblEv1
            // 
            this.lblEv1.AutoSize = true;
            this.lblEv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEv1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEv1.Location = new System.Drawing.Point(328, 612);
            this.lblEv1.Name = "lblEv1";
            this.lblEv1.Size = new System.Drawing.Size(47, 15);
            this.lblEv1.TabIndex = 50;
            this.lblEv1.Text = "          ";
            this.lblEv1.Visible = false;
            // 
            // lblEv2
            // 
            this.lblEv2.AutoSize = true;
            this.lblEv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEv2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEv2.Location = new System.Drawing.Point(328, 652);
            this.lblEv2.Name = "lblEv2";
            this.lblEv2.Size = new System.Drawing.Size(47, 15);
            this.lblEv2.TabIndex = 51;
            this.lblEv2.Text = "          ";
            this.lblEv2.Visible = false;
            // 
            // lblEv3
            // 
            this.lblEv3.AutoSize = true;
            this.lblEv3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEv3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEv3.Location = new System.Drawing.Point(328, 692);
            this.lblEv3.Name = "lblEv3";
            this.lblEv3.Size = new System.Drawing.Size(47, 15);
            this.lblEv3.TabIndex = 52;
            this.lblEv3.Text = "          ";
            this.lblEv3.Visible = false;
            // 
            // lblEv6
            // 
            this.lblEv6.AutoSize = true;
            this.lblEv6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEv6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEv6.Location = new System.Drawing.Point(685, 692);
            this.lblEv6.Name = "lblEv6";
            this.lblEv6.Size = new System.Drawing.Size(47, 15);
            this.lblEv6.TabIndex = 55;
            this.lblEv6.Text = "          ";
            this.lblEv6.Visible = false;
            // 
            // lblEv5
            // 
            this.lblEv5.AutoSize = true;
            this.lblEv5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEv5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEv5.Location = new System.Drawing.Point(685, 652);
            this.lblEv5.Name = "lblEv5";
            this.lblEv5.Size = new System.Drawing.Size(47, 15);
            this.lblEv5.TabIndex = 54;
            this.lblEv5.Text = "          ";
            this.lblEv5.Visible = false;
            // 
            // lblEv4
            // 
            this.lblEv4.AutoSize = true;
            this.lblEv4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEv4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEv4.Location = new System.Drawing.Point(685, 612);
            this.lblEv4.Name = "lblEv4";
            this.lblEv4.Size = new System.Drawing.Size(47, 15);
            this.lblEv4.TabIndex = 53;
            this.lblEv4.Text = "          ";
            this.lblEv4.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(193, 318);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(146, 32);
            this.label18.TabIndex = 56;
            this.label18.Text = "(Si no tienen alineacion\r\nno escribir nada)";
            this.label18.Visible = false;
            // 
            // crearEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(55)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1512, 955);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtApellidoVisitante);
            this.Controls.Add(this.txtNombreVisitante);
            this.Controls.Add(this.txtIdVisitante);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtApellidoLocal);
            this.Controls.Add(this.txtNombreLocal);
            this.Controls.Add(this.txtIdLocal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxDeporteInvidual);
            this.Controls.Add(this.lblEv6);
            this.Controls.Add(this.lblEv5);
            this.Controls.Add(this.lblEv4);
            this.Controls.Add(this.lblEv3);
            this.Controls.Add(this.lblEv2);
            this.Controls.Add(this.lblEv1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtAlineacionVisitante);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAlineacionLocal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cbxVisitante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxLocal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxDeporte);
            this.Controls.Add(this.cbxIndividual);
            this.Controls.Add(this.cbxSelecciones);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "crearEventos";
            this.Text = "crearEventos";
            this.Load += new System.EventHandler(this.crearEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxSelecciones;
        private System.Windows.Forms.CheckBox cbxIndividual;
        private System.Windows.Forms.ComboBox cbxDeporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxLocal;
        private System.Windows.Forms.ComboBox cbxVisitante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAlineacionLocal;
        private System.Windows.Forms.TextBox txtAlineacionVisitante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxDeporteInvidual;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtIdLocal;
        private System.Windows.Forms.TextBox txtNombreLocal;
        private System.Windows.Forms.TextBox txtApellidoLocal;
        private System.Windows.Forms.TextBox txtApellidoVisitante;
        private System.Windows.Forms.TextBox txtNombreVisitante;
        private System.Windows.Forms.TextBox txtIdVisitante;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label lblEv1;
        private System.Windows.Forms.Label lblEv2;
        private System.Windows.Forms.Label lblEv3;
        private System.Windows.Forms.Label lblEv6;
        private System.Windows.Forms.Label lblEv5;
        private System.Windows.Forms.Label lblEv4;
        private System.Windows.Forms.Label label18;
    }
}