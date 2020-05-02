namespace Ips
{
    partial class RegistrarPacienteGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarPacienteGui));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LbTitulo = new System.Windows.Forms.Label();
            this.LbNombre = new System.Windows.Forms.Label();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.LbCedula = new System.Windows.Forms.Label();
            this.TbCedula = new System.Windows.Forms.TextBox();
            this.CbRegimen = new System.Windows.Forms.ComboBox();
            this.LbTipoRegimen = new System.Windows.Forms.Label();
            this.LbApeliido = new System.Windows.Forms.Label();
            this.TbApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbSalario = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnRegistrarPaciente = new System.Windows.Forms.Button();
            this.BtnVaciarCampos = new System.Windows.Forms.Button();
            this.LbRespuesta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(544, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LbTitulo
            // 
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbTitulo.Location = new System.Drawing.Point(316, 55);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(588, 77);
            this.LbTitulo.TabIndex = 1;
            this.LbTitulo.Text = "Registrar Paciente";
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbNombre.Location = new System.Drawing.Point(108, 264);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(145, 36);
            this.LbNombre.TabIndex = 9;
            this.LbNombre.Text = "Nombre :";
            // 
            // TbNombre
            // 
            this.TbNombre.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNombre.Location = new System.Drawing.Point(277, 264);
            this.TbNombre.Multiline = true;
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(177, 36);
            this.TbNombre.TabIndex = 8;
            // 
            // LbCedula
            // 
            this.LbCedula.AutoSize = true;
            this.LbCedula.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCedula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbCedula.Location = new System.Drawing.Point(108, 189);
            this.LbCedula.Name = "LbCedula";
            this.LbCedula.Size = new System.Drawing.Size(135, 36);
            this.LbCedula.TabIndex = 7;
            this.LbCedula.Text = "Cedula :";
            // 
            // TbCedula
            // 
            this.TbCedula.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCedula.Location = new System.Drawing.Point(277, 189);
            this.TbCedula.Multiline = true;
            this.TbCedula.Name = "TbCedula";
            this.TbCedula.Size = new System.Drawing.Size(177, 36);
            this.TbCedula.TabIndex = 6;
            // 
            // CbRegimen
            // 
            this.CbRegimen.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbRegimen.FormattingEnabled = true;
            this.CbRegimen.Items.AddRange(new object[] {
            "Sudsidiado",
            "Contributivo"});
            this.CbRegimen.Location = new System.Drawing.Point(277, 390);
            this.CbRegimen.Name = "CbRegimen";
            this.CbRegimen.Size = new System.Drawing.Size(177, 38);
            this.CbRegimen.TabIndex = 16;
            // 
            // LbTipoRegimen
            // 
            this.LbTipoRegimen.AutoSize = true;
            this.LbTipoRegimen.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTipoRegimen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbTipoRegimen.Location = new System.Drawing.Point(108, 390);
            this.LbTipoRegimen.Name = "LbTipoRegimen";
            this.LbTipoRegimen.Size = new System.Drawing.Size(156, 36);
            this.LbTipoRegimen.TabIndex = 15;
            this.LbTipoRegimen.Text = "Regimen :";
            // 
            // LbApeliido
            // 
            this.LbApeliido.AutoSize = true;
            this.LbApeliido.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbApeliido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbApeliido.Location = new System.Drawing.Point(108, 327);
            this.LbApeliido.Name = "LbApeliido";
            this.LbApeliido.Size = new System.Drawing.Size(149, 36);
            this.LbApeliido.TabIndex = 20;
            this.LbApeliido.Text = "Apellido :";
            // 
            // TbApellido
            // 
            this.TbApellido.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbApellido.Location = new System.Drawing.Point(277, 327);
            this.TbApellido.Multiline = true;
            this.TbApellido.Name = "TbApellido";
            this.TbApellido.Size = new System.Drawing.Size(177, 36);
            this.TbApellido.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(108, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 36);
            this.label1.TabIndex = 22;
            this.label1.Text = "Salario :";
            // 
            // TbSalario
            // 
            this.TbSalario.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSalario.Location = new System.Drawing.Point(277, 461);
            this.TbSalario.Multiline = true;
            this.TbSalario.Name = "TbSalario";
            this.TbSalario.Size = new System.Drawing.Size(177, 36);
            this.TbSalario.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(217, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // BtnRegistrarPaciente
            // 
            this.BtnRegistrarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(68)))), ((int)(((byte)(109)))));
            this.BtnRegistrarPaciente.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarPaciente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarPaciente.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrarPaciente.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistrarPaciente.Image")));
            this.BtnRegistrarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrarPaciente.Location = new System.Drawing.Point(114, 539);
            this.BtnRegistrarPaciente.Name = "BtnRegistrarPaciente";
            this.BtnRegistrarPaciente.Size = new System.Drawing.Size(243, 44);
            this.BtnRegistrarPaciente.TabIndex = 24;
            this.BtnRegistrarPaciente.Text = "Registrar Paciente";
            this.BtnRegistrarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegistrarPaciente.UseVisualStyleBackColor = false;
            this.BtnRegistrarPaciente.Click += new System.EventHandler(this.BtnRegistrarPaciente_Click);
            // 
            // BtnVaciarCampos
            // 
            this.BtnVaciarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(68)))), ((int)(((byte)(109)))));
            this.BtnVaciarCampos.FlatAppearance.BorderSize = 0;
            this.BtnVaciarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVaciarCampos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVaciarCampos.ForeColor = System.Drawing.Color.White;
            this.BtnVaciarCampos.Image = ((System.Drawing.Image)(resources.GetObject("BtnVaciarCampos.Image")));
            this.BtnVaciarCampos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVaciarCampos.Location = new System.Drawing.Point(408, 539);
            this.BtnVaciarCampos.Name = "BtnVaciarCampos";
            this.BtnVaciarCampos.Size = new System.Drawing.Size(218, 44);
            this.BtnVaciarCampos.TabIndex = 25;
            this.BtnVaciarCampos.Text = "Vaciar Campos";
            this.BtnVaciarCampos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVaciarCampos.UseVisualStyleBackColor = false;
            this.BtnVaciarCampos.Click += new System.EventHandler(this.BtnVaciarCampos_Click);
            // 
            // LbRespuesta
            // 
            this.LbRespuesta.AutoSize = true;
            this.LbRespuesta.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRespuesta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LbRespuesta.Location = new System.Drawing.Point(108, 610);
            this.LbRespuesta.Name = "LbRespuesta";
            this.LbRespuesta.Size = new System.Drawing.Size(0, 36);
            this.LbRespuesta.TabIndex = 26;
            // 
            // RegistrarPacienteGui
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(932, 679);
            this.Controls.Add(this.LbRespuesta);
            this.Controls.Add(this.BtnVaciarCampos);
            this.Controls.Add(this.BtnRegistrarPaciente);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbSalario);
            this.Controls.Add(this.LbApeliido);
            this.Controls.Add(this.TbApellido);
            this.Controls.Add(this.CbRegimen);
            this.Controls.Add(this.LbTipoRegimen);
            this.Controls.Add(this.LbNombre);
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.LbCedula);
            this.Controls.Add(this.TbCedula);
            this.Controls.Add(this.LbTitulo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarPacienteGui";
            this.Text = "RegistrarPacienteGui";
            this.Load += new System.EventHandler(this.RegistrarPacienteGui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.Label LbNombre;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.Label LbCedula;
        private System.Windows.Forms.TextBox TbCedula;
        private System.Windows.Forms.ComboBox CbRegimen;
        private System.Windows.Forms.Label LbTipoRegimen;
        private System.Windows.Forms.Label LbApeliido;
        private System.Windows.Forms.TextBox TbApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbSalario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnRegistrarPaciente;
        private System.Windows.Forms.Button BtnVaciarCampos;
        private System.Windows.Forms.Label LbRespuesta;
    }
}