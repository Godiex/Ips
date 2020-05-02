namespace Ips
{
    partial class ConsultaGui
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaGui));
            this.DgvLiquidacion = new System.Windows.Forms.DataGridView();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Afliacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubvalorLiquidacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopeMaximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorLiquidacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.CbTipo = new System.Windows.Forms.CheckBox();
            this.CbApellido = new System.Windows.Forms.CheckBox();
            this.CbFecha = new System.Windows.Forms.CheckBox();
            this.TbApellido = new System.Windows.Forms.TextBox();
            this.DtpMesAño = new System.Windows.Forms.DateTimePicker();
            this.CbTipoConsulta = new System.Windows.Forms.ComboBox();
            this.LbTotaLiquidadaciones = new System.Windows.Forms.Label();
            this.TbTotalLquidaciones = new System.Windows.Forms.TextBox();
            this.TbTotalLiquidacionContributivo = new System.Windows.Forms.TextBox();
            this.LbTotalLiquidacionesContributivo = new System.Windows.Forms.Label();
            this.TbTotalLiquidacionSubsidiado = new System.Windows.Forms.TextBox();
            this.LbLiquidacionesSudsiadiado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelContenedorCantidades = new System.Windows.Forms.Panel();
            this.LbCantidadTotal = new System.Windows.Forms.Label();
            this.LbCantidadTotalContributivo = new System.Windows.Forms.Label();
            this.LbCantidadTotalSubsidiado = new System.Windows.Forms.Label();
            this.LbValorCantidadTotal = new System.Windows.Forms.Label();
            this.LbValorCantidadTotalContributivo = new System.Windows.Forms.Label();
            this.LbValorCantidadSudsidiado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLiquidacion)).BeginInit();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelContenedorCantidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvLiquidacion
            // 
            this.DgvLiquidacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvLiquidacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.DgvLiquidacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvLiquidacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(68)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvLiquidacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvLiquidacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLiquidacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.Afliacion,
            this.Salario,
            this.ValorServicio,
            this.Tarifa,
            this.SubvalorLiquidacion,
            this.TopeMaximo,
            this.ValorLiquidacion});
            this.DgvLiquidacion.EnableHeadersVisualStyles = false;
            this.DgvLiquidacion.Location = new System.Drawing.Point(23, 318);
            this.DgvLiquidacion.Name = "DgvLiquidacion";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvLiquidacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.DgvLiquidacion.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvLiquidacion.Size = new System.Drawing.Size(870, 310);
            this.DgvLiquidacion.TabIndex = 0;
            // 
            // Cedula
            // 
            this.Cedula.Frozen = true;
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cedula.Width = 80;
            // 
            // Afliacion
            // 
            this.Afliacion.HeaderText = "Afliacion";
            this.Afliacion.Name = "Afliacion";
            this.Afliacion.Width = 91;
            // 
            // Salario
            // 
            this.Salario.HeaderText = "Salario";
            this.Salario.Name = "Salario";
            this.Salario.Width = 78;
            // 
            // ValorServicio
            // 
            this.ValorServicio.HeaderText = "Valor Servicio";
            this.ValorServicio.Name = "ValorServicio";
            this.ValorServicio.Width = 112;
            // 
            // Tarifa
            // 
            this.Tarifa.HeaderText = "Tarifa";
            this.Tarifa.Name = "Tarifa";
            this.Tarifa.Width = 69;
            // 
            // SubvalorLiquidacion
            // 
            this.SubvalorLiquidacion.HeaderText = "Subvalor Liquidacion";
            this.SubvalorLiquidacion.Name = "SubvalorLiquidacion";
            this.SubvalorLiquidacion.Width = 155;
            // 
            // TopeMaximo
            // 
            this.TopeMaximo.HeaderText = "Tope Maximo";
            this.TopeMaximo.Name = "TopeMaximo";
            this.TopeMaximo.Width = 109;
            // 
            // ValorLiquidacion
            // 
            this.ValorLiquidacion.HeaderText = "Valor Liquidacion";
            this.ValorLiquidacion.Name = "ValorLiquidacion";
            this.ValorLiquidacion.Width = 135;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(94)))), ((int)(((byte)(142)))));
            this.BtnConsultar.FlatAppearance.BorderSize = 0;
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.ForeColor = System.Drawing.Color.White;
            this.BtnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultar.Image")));
            this.BtnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultar.Location = new System.Drawing.Point(23, 20);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(203, 44);
            this.BtnConsultar.TabIndex = 54;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = false;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(68)))), ((int)(((byte)(109)))));
            this.PanelSuperior.Controls.Add(this.CbTipo);
            this.PanelSuperior.Controls.Add(this.CbApellido);
            this.PanelSuperior.Controls.Add(this.CbFecha);
            this.PanelSuperior.Controls.Add(this.TbApellido);
            this.PanelSuperior.Controls.Add(this.DtpMesAño);
            this.PanelSuperior.Controls.Add(this.CbTipoConsulta);
            this.PanelSuperior.Controls.Add(this.BtnConsultar);
            this.PanelSuperior.Location = new System.Drawing.Point(23, 12);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(247, 286);
            this.PanelSuperior.TabIndex = 55;
            this.PanelSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelSuperior_Paint);
            // 
            // CbTipo
            // 
            this.CbTipo.AutoSize = true;
            this.CbTipo.Location = new System.Drawing.Point(23, 86);
            this.CbTipo.Name = "CbTipo";
            this.CbTipo.Size = new System.Drawing.Size(15, 14);
            this.CbTipo.TabIndex = 62;
            this.CbTipo.UseVisualStyleBackColor = true;
            this.CbTipo.CheckedChanged += new System.EventHandler(this.CbTipo_CheckedChanged);
            // 
            // CbApellido
            // 
            this.CbApellido.AutoSize = true;
            this.CbApellido.Location = new System.Drawing.Point(23, 206);
            this.CbApellido.Name = "CbApellido";
            this.CbApellido.Size = new System.Drawing.Size(15, 14);
            this.CbApellido.TabIndex = 61;
            this.CbApellido.UseVisualStyleBackColor = true;
            this.CbApellido.CheckedChanged += new System.EventHandler(this.CbApellido_CheckedChanged);
            // 
            // CbFecha
            // 
            this.CbFecha.AutoSize = true;
            this.CbFecha.Location = new System.Drawing.Point(23, 146);
            this.CbFecha.Name = "CbFecha";
            this.CbFecha.Size = new System.Drawing.Size(15, 14);
            this.CbFecha.TabIndex = 60;
            this.CbFecha.UseVisualStyleBackColor = true;
            this.CbFecha.CheckedChanged += new System.EventHandler(this.CbFecha_CheckedChanged);
            // 
            // TbApellido
            // 
            this.TbApellido.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbApellido.Location = new System.Drawing.Point(44, 206);
            this.TbApellido.Multiline = true;
            this.TbApellido.Name = "TbApellido";
            this.TbApellido.Size = new System.Drawing.Size(177, 36);
            this.TbApellido.TabIndex = 57;
            // 
            // DtpMesAño
            // 
            this.DtpMesAño.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpMesAño.CustomFormat = "mm/yyyy";
            this.DtpMesAño.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpMesAño.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpMesAño.Location = new System.Drawing.Point(44, 146);
            this.DtpMesAño.Name = "DtpMesAño";
            this.DtpMesAño.Size = new System.Drawing.Size(177, 37);
            this.DtpMesAño.TabIndex = 56;
            this.DtpMesAño.Value = new System.DateTime(2020, 5, 2, 0, 0, 0, 0);
            // 
            // CbTipoConsulta
            // 
            this.CbTipoConsulta.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbTipoConsulta.FormattingEnabled = true;
            this.CbTipoConsulta.Items.AddRange(new object[] {
            "Todos",
            "Sudsidiado",
            "Contributivo"});
            this.CbTipoConsulta.Location = new System.Drawing.Point(44, 86);
            this.CbTipoConsulta.Name = "CbTipoConsulta";
            this.CbTipoConsulta.Size = new System.Drawing.Size(177, 38);
            this.CbTipoConsulta.TabIndex = 56;
            // 
            // LbTotaLiquidadaciones
            // 
            this.LbTotaLiquidadaciones.AutoSize = true;
            this.LbTotaLiquidadaciones.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotaLiquidadaciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbTotaLiquidadaciones.Location = new System.Drawing.Point(276, 107);
            this.LbTotaLiquidadaciones.Name = "LbTotaLiquidadaciones";
            this.LbTotaLiquidadaciones.Size = new System.Drawing.Size(197, 23);
            this.LbTotaLiquidadaciones.TabIndex = 58;
            this.LbTotaLiquidadaciones.Text = "Total Liquidaciones :";
            // 
            // TbTotalLquidaciones
            // 
            this.TbTotalLquidaciones.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTotalLquidaciones.Location = new System.Drawing.Point(598, 105);
            this.TbTotalLquidaciones.Multiline = true;
            this.TbTotalLquidaciones.Name = "TbTotalLquidaciones";
            this.TbTotalLquidaciones.Size = new System.Drawing.Size(127, 27);
            this.TbTotalLquidaciones.TabIndex = 63;
            // 
            // TbTotalLiquidacionContributivo
            // 
            this.TbTotalLiquidacionContributivo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTotalLiquidacionContributivo.Location = new System.Drawing.Point(598, 174);
            this.TbTotalLiquidacionContributivo.Multiline = true;
            this.TbTotalLiquidacionContributivo.Name = "TbTotalLiquidacionContributivo";
            this.TbTotalLiquidacionContributivo.Size = new System.Drawing.Size(127, 27);
            this.TbTotalLiquidacionContributivo.TabIndex = 65;
            // 
            // LbTotalLiquidacionesContributivo
            // 
            this.LbTotalLiquidacionesContributivo.AutoSize = true;
            this.LbTotalLiquidacionesContributivo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotalLiquidacionesContributivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbTotalLiquidacionesContributivo.Location = new System.Drawing.Point(276, 176);
            this.LbTotalLiquidacionesContributivo.Name = "LbTotalLiquidacionesContributivo";
            this.LbTotalLiquidacionesContributivo.Size = new System.Drawing.Size(315, 23);
            this.LbTotalLiquidacionesContributivo.TabIndex = 64;
            this.LbTotalLiquidacionesContributivo.Text = "Total Liquidaciones  Contributivo:";
            // 
            // TbTotalLiquidacionSubsidiado
            // 
            this.TbTotalLiquidacionSubsidiado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTotalLiquidacionSubsidiado.Location = new System.Drawing.Point(598, 240);
            this.TbTotalLiquidacionSubsidiado.Multiline = true;
            this.TbTotalLiquidacionSubsidiado.Name = "TbTotalLiquidacionSubsidiado";
            this.TbTotalLiquidacionSubsidiado.Size = new System.Drawing.Size(127, 27);
            this.TbTotalLiquidacionSubsidiado.TabIndex = 67;
            // 
            // LbLiquidacionesSudsiadiado
            // 
            this.LbLiquidacionesSudsiadiado.AutoSize = true;
            this.LbLiquidacionesSudsiadiado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLiquidacionesSudsiadiado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbLiquidacionesSudsiadiado.Location = new System.Drawing.Point(276, 242);
            this.LbLiquidacionesSudsiadiado.Name = "LbLiquidacionesSudsiadiado";
            this.LbLiquidacionesSudsiadiado.Size = new System.Drawing.Size(305, 23);
            this.LbLiquidacionesSudsiadiado.TabIndex = 66;
            this.LbLiquidacionesSudsiadiado.Text = "Total Liquidaciones Sudsidiado :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(399, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 32);
            this.label3.TabIndex = 68;
            this.label3.Text = "Totalizaciones Liquidacion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(298, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // PanelContenedorCantidades
            // 
            this.PanelContenedorCantidades.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelContenedorCantidades.Controls.Add(this.LbCantidadTotalSubsidiado);
            this.PanelContenedorCantidades.Controls.Add(this.LbValorCantidadSudsidiado);
            this.PanelContenedorCantidades.Controls.Add(this.LbValorCantidadTotalContributivo);
            this.PanelContenedorCantidades.Controls.Add(this.LbValorCantidadTotal);
            this.PanelContenedorCantidades.Controls.Add(this.LbCantidadTotalContributivo);
            this.PanelContenedorCantidades.Controls.Add(this.LbCantidadTotal);
            this.PanelContenedorCantidades.Location = new System.Drawing.Point(726, 105);
            this.PanelContenedorCantidades.Name = "PanelContenedorCantidades";
            this.PanelContenedorCantidades.Size = new System.Drawing.Size(202, 178);
            this.PanelContenedorCantidades.TabIndex = 63;
            // 
            // LbCantidadTotal
            // 
            this.LbCantidadTotal.AutoSize = true;
            this.LbCantidadTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCantidadTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbCantidadTotal.Location = new System.Drawing.Point(18, 4);
            this.LbCantidadTotal.Name = "LbCantidadTotal";
            this.LbCantidadTotal.Size = new System.Drawing.Size(109, 23);
            this.LbCantidadTotal.TabIndex = 70;
            this.LbCantidadTotal.Text = "Cantidad :";
            // 
            // LbCantidadTotalContributivo
            // 
            this.LbCantidadTotalContributivo.AutoSize = true;
            this.LbCantidadTotalContributivo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCantidadTotalContributivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbCantidadTotalContributivo.Location = new System.Drawing.Point(18, 71);
            this.LbCantidadTotalContributivo.Name = "LbCantidadTotalContributivo";
            this.LbCantidadTotalContributivo.Size = new System.Drawing.Size(109, 23);
            this.LbCantidadTotalContributivo.TabIndex = 71;
            this.LbCantidadTotalContributivo.Text = "Cantidad :";
            // 
            // LbCantidadTotalSubsidiado
            // 
            this.LbCantidadTotalSubsidiado.AutoSize = true;
            this.LbCantidadTotalSubsidiado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCantidadTotalSubsidiado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbCantidadTotalSubsidiado.Location = new System.Drawing.Point(18, 139);
            this.LbCantidadTotalSubsidiado.Name = "LbCantidadTotalSubsidiado";
            this.LbCantidadTotalSubsidiado.Size = new System.Drawing.Size(109, 23);
            this.LbCantidadTotalSubsidiado.TabIndex = 72;
            this.LbCantidadTotalSubsidiado.Text = "Cantidad :";
            // 
            // LbValorCantidadTotal
            // 
            this.LbValorCantidadTotal.AutoSize = true;
            this.LbValorCantidadTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbValorCantidadTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbValorCantidadTotal.Location = new System.Drawing.Point(133, 8);
            this.LbValorCantidadTotal.Name = "LbValorCantidadTotal";
            this.LbValorCantidadTotal.Size = new System.Drawing.Size(0, 23);
            this.LbValorCantidadTotal.TabIndex = 72;
            // 
            // LbValorCantidadTotalContributivo
            // 
            this.LbValorCantidadTotalContributivo.AutoSize = true;
            this.LbValorCantidadTotalContributivo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbValorCantidadTotalContributivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbValorCantidadTotalContributivo.Location = new System.Drawing.Point(133, 73);
            this.LbValorCantidadTotalContributivo.Name = "LbValorCantidadTotalContributivo";
            this.LbValorCantidadTotalContributivo.Size = new System.Drawing.Size(0, 23);
            this.LbValorCantidadTotalContributivo.TabIndex = 73;
            // 
            // LbValorCantidadSudsidiado
            // 
            this.LbValorCantidadSudsidiado.AutoSize = true;
            this.LbValorCantidadSudsidiado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbValorCantidadSudsidiado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbValorCantidadSudsidiado.Location = new System.Drawing.Point(127, 139);
            this.LbValorCantidadSudsidiado.Name = "LbValorCantidadSudsidiado";
            this.LbValorCantidadSudsidiado.Size = new System.Drawing.Size(0, 23);
            this.LbValorCantidadSudsidiado.TabIndex = 74;
            // 
            // ConsultaGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(916, 640);
            this.Controls.Add(this.PanelContenedorCantidades);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbTotalLiquidacionSubsidiado);
            this.Controls.Add(this.LbLiquidacionesSudsiadiado);
            this.Controls.Add(this.TbTotalLiquidacionContributivo);
            this.Controls.Add(this.LbTotalLiquidacionesContributivo);
            this.Controls.Add(this.TbTotalLquidaciones);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.DgvLiquidacion);
            this.Controls.Add(this.LbTotaLiquidadaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaGui";
            this.Text = "ConsultaGui";
            ((System.ComponentModel.ISupportInitialize)(this.DgvLiquidacion)).EndInit();
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelContenedorCantidades.ResumeLayout(false);
            this.PanelContenedorCantidades.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvLiquidacion;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.ComboBox CbTipoConsulta;
        private System.Windows.Forms.DateTimePicker DtpMesAño;
        private System.Windows.Forms.CheckBox CbApellido;
        private System.Windows.Forms.CheckBox CbFecha;
        private System.Windows.Forms.TextBox TbApellido;
        private System.Windows.Forms.Label LbTotaLiquidadaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Afliacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubvalorLiquidacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopeMaximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorLiquidacion;
        public System.Windows.Forms.CheckBox CbTipo;
        private System.Windows.Forms.TextBox TbTotalLquidaciones;
        private System.Windows.Forms.TextBox TbTotalLiquidacionContributivo;
        private System.Windows.Forms.Label LbTotalLiquidacionesContributivo;
        private System.Windows.Forms.TextBox TbTotalLiquidacionSubsidiado;
        private System.Windows.Forms.Label LbLiquidacionesSudsiadiado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelContenedorCantidades;
        private System.Windows.Forms.Label LbValorCantidadTotalContributivo;
        private System.Windows.Forms.Label LbValorCantidadTotal;
        private System.Windows.Forms.Label LbCantidadTotalContributivo;
        private System.Windows.Forms.Label LbCantidadTotal;
        private System.Windows.Forms.Label LbCantidadTotalSubsidiado;
        private System.Windows.Forms.Label LbValorCantidadSudsidiado;
    }
}