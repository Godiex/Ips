namespace Ips
{
    partial class OpcionesLiquidacionesGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpcionesLiquidacionesGui));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LbTitulo = new System.Windows.Forms.Label();
            this.LbCoutaModeradora = new System.Windows.Forms.Label();
            this.LbValorServicio = new System.Windows.Forms.Label();
            this.TbCedulaPaciente = new System.Windows.Forms.TextBox();
            this.LbNumeroDeLiquidacion = new System.Windows.Forms.Label();
            this.TbNumeroLiquidacion = new System.Windows.Forms.TextBox();
            this.TbRegimenPaciente = new System.Windows.Forms.TextBox();
            this.LbCedula = new System.Windows.Forms.Label();
            this.TbValorServicio = new System.Windows.Forms.TextBox();
            this.LbRegimenPaciente = new System.Windows.Forms.Label();
            this.TbTarifa = new System.Windows.Forms.TextBox();
            this.LbTarifa = new System.Windows.Forms.Label();
            this.TbTopeMaximo = new System.Windows.Forms.TextBox();
            this.LbTopeMaximo = new System.Windows.Forms.Label();
            this.TbSubTotalCoutaModeradora = new System.Windows.Forms.TextBox();
            this.LbSubtotalCoutaModeradora = new System.Windows.Forms.Label();
            this.TbCoutaModeradora = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnVaciarCampos = new System.Windows.Forms.Button();
            this.LbRespuesta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(89, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // LbTitulo
            // 
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbTitulo.Location = new System.Drawing.Point(191, 32);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(708, 77);
            this.LbTitulo.TabIndex = 30;
            this.LbTitulo.Text = "Opciones Liquidacion";
            // 
            // LbCoutaModeradora
            // 
            this.LbCoutaModeradora.AutoSize = true;
            this.LbCoutaModeradora.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCoutaModeradora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbCoutaModeradora.Location = new System.Drawing.Point(20, 582);
            this.LbCoutaModeradora.Name = "LbCoutaModeradora";
            this.LbCoutaModeradora.Size = new System.Drawing.Size(303, 36);
            this.LbCoutaModeradora.TabIndex = 45;
            this.LbCoutaModeradora.Text = "Couta Moderadora :";
            // 
            // LbValorServicio
            // 
            this.LbValorServicio.AutoSize = true;
            this.LbValorServicio.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbValorServicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbValorServicio.Location = new System.Drawing.Point(20, 337);
            this.LbValorServicio.Name = "LbValorServicio";
            this.LbValorServicio.Size = new System.Drawing.Size(224, 36);
            this.LbValorServicio.TabIndex = 44;
            this.LbValorServicio.Text = "Valor Servicio :";
            // 
            // TbCedulaPaciente
            // 
            this.TbCedulaPaciente.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCedulaPaciente.Location = new System.Drawing.Point(457, 215);
            this.TbCedulaPaciente.Multiline = true;
            this.TbCedulaPaciente.Name = "TbCedulaPaciente";
            this.TbCedulaPaciente.Size = new System.Drawing.Size(177, 36);
            this.TbCedulaPaciente.TabIndex = 43;
            // 
            // LbNumeroDeLiquidacion
            // 
            this.LbNumeroDeLiquidacion.AutoSize = true;
            this.LbNumeroDeLiquidacion.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNumeroDeLiquidacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbNumeroDeLiquidacion.Location = new System.Drawing.Point(20, 157);
            this.LbNumeroDeLiquidacion.Name = "LbNumeroDeLiquidacion";
            this.LbNumeroDeLiquidacion.Size = new System.Drawing.Size(360, 36);
            this.LbNumeroDeLiquidacion.TabIndex = 42;
            this.LbNumeroDeLiquidacion.Text = "Numero de Liquidacion :";
            // 
            // TbNumeroLiquidacion
            // 
            this.TbNumeroLiquidacion.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNumeroLiquidacion.Location = new System.Drawing.Point(457, 157);
            this.TbNumeroLiquidacion.Multiline = true;
            this.TbNumeroLiquidacion.Name = "TbNumeroLiquidacion";
            this.TbNumeroLiquidacion.Size = new System.Drawing.Size(177, 36);
            this.TbNumeroLiquidacion.TabIndex = 41;
            // 
            // TbRegimenPaciente
            // 
            this.TbRegimenPaciente.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbRegimenPaciente.Location = new System.Drawing.Point(457, 275);
            this.TbRegimenPaciente.Multiline = true;
            this.TbRegimenPaciente.Name = "TbRegimenPaciente";
            this.TbRegimenPaciente.Size = new System.Drawing.Size(177, 36);
            this.TbRegimenPaciente.TabIndex = 46;
            // 
            // LbCedula
            // 
            this.LbCedula.AutoSize = true;
            this.LbCedula.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCedula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbCedula.Location = new System.Drawing.Point(20, 215);
            this.LbCedula.Name = "LbCedula";
            this.LbCedula.Size = new System.Drawing.Size(268, 36);
            this.LbCedula.TabIndex = 48;
            this.LbCedula.Text = "Cedula Paciente :";
            // 
            // TbValorServicio
            // 
            this.TbValorServicio.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbValorServicio.Location = new System.Drawing.Point(457, 337);
            this.TbValorServicio.Multiline = true;
            this.TbValorServicio.Name = "TbValorServicio";
            this.TbValorServicio.Size = new System.Drawing.Size(177, 36);
            this.TbValorServicio.TabIndex = 47;
            // 
            // LbRegimenPaciente
            // 
            this.LbRegimenPaciente.AutoSize = true;
            this.LbRegimenPaciente.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRegimenPaciente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbRegimenPaciente.Location = new System.Drawing.Point(20, 275);
            this.LbRegimenPaciente.Name = "LbRegimenPaciente";
            this.LbRegimenPaciente.Size = new System.Drawing.Size(156, 36);
            this.LbRegimenPaciente.TabIndex = 49;
            this.LbRegimenPaciente.Text = "Regimen :";
            // 
            // TbTarifa
            // 
            this.TbTarifa.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTarifa.Location = new System.Drawing.Point(457, 396);
            this.TbTarifa.Multiline = true;
            this.TbTarifa.Name = "TbTarifa";
            this.TbTarifa.Size = new System.Drawing.Size(177, 36);
            this.TbTarifa.TabIndex = 51;
            // 
            // LbTarifa
            // 
            this.LbTarifa.AutoSize = true;
            this.LbTarifa.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTarifa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbTarifa.Location = new System.Drawing.Point(20, 401);
            this.LbTarifa.Name = "LbTarifa";
            this.LbTarifa.Size = new System.Drawing.Size(105, 36);
            this.LbTarifa.TabIndex = 50;
            this.LbTarifa.Text = "Tarifa :";
            // 
            // TbTopeMaximo
            // 
            this.TbTopeMaximo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTopeMaximo.Location = new System.Drawing.Point(457, 460);
            this.TbTopeMaximo.Multiline = true;
            this.TbTopeMaximo.Name = "TbTopeMaximo";
            this.TbTopeMaximo.Size = new System.Drawing.Size(177, 36);
            this.TbTopeMaximo.TabIndex = 53;
            // 
            // LbTopeMaximo
            // 
            this.LbTopeMaximo.AutoSize = true;
            this.LbTopeMaximo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTopeMaximo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbTopeMaximo.Location = new System.Drawing.Point(20, 460);
            this.LbTopeMaximo.Name = "LbTopeMaximo";
            this.LbTopeMaximo.Size = new System.Drawing.Size(222, 36);
            this.LbTopeMaximo.TabIndex = 52;
            this.LbTopeMaximo.Text = "Tope Maximo :";
            // 
            // TbSubTotalCoutaModeradora
            // 
            this.TbSubTotalCoutaModeradora.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSubTotalCoutaModeradora.Location = new System.Drawing.Point(457, 520);
            this.TbSubTotalCoutaModeradora.Multiline = true;
            this.TbSubTotalCoutaModeradora.Name = "TbSubTotalCoutaModeradora";
            this.TbSubTotalCoutaModeradora.Size = new System.Drawing.Size(177, 36);
            this.TbSubTotalCoutaModeradora.TabIndex = 55;
            // 
            // LbSubtotalCoutaModeradora
            // 
            this.LbSubtotalCoutaModeradora.AutoSize = true;
            this.LbSubtotalCoutaModeradora.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSubtotalCoutaModeradora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbSubtotalCoutaModeradora.Location = new System.Drawing.Point(20, 520);
            this.LbSubtotalCoutaModeradora.Name = "LbSubtotalCoutaModeradora";
            this.LbSubtotalCoutaModeradora.Size = new System.Drawing.Size(428, 36);
            this.LbSubtotalCoutaModeradora.TabIndex = 54;
            this.LbSubtotalCoutaModeradora.Text = "SubTotal Couta Moderadora :";
            // 
            // TbCoutaModeradora
            // 
            this.TbCoutaModeradora.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCoutaModeradora.Location = new System.Drawing.Point(457, 582);
            this.TbCoutaModeradora.Multiline = true;
            this.TbCoutaModeradora.Name = "TbCoutaModeradora";
            this.TbCoutaModeradora.Size = new System.Drawing.Size(177, 36);
            this.TbCoutaModeradora.TabIndex = 56;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(68)))), ((int)(((byte)(109)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(675, 158);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(224, 44);
            this.BtnBuscar.TabIndex = 57;
            this.BtnBuscar.Text = "Buscar ";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(68)))), ((int)(((byte)(109)))));
            this.BtnBorrar.FlatAppearance.BorderSize = 0;
            this.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.ForeColor = System.Drawing.Color.White;
            this.BtnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBorrar.Image")));
            this.BtnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBorrar.Location = new System.Drawing.Point(675, 285);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(224, 44);
            this.BtnBorrar.TabIndex = 58;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(68)))), ((int)(((byte)(109)))));
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.Location = new System.Drawing.Point(675, 225);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(224, 44);
            this.BtnModificar.TabIndex = 59;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
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
            this.BtnVaciarCampos.Location = new System.Drawing.Point(675, 347);
            this.BtnVaciarCampos.Name = "BtnVaciarCampos";
            this.BtnVaciarCampos.Size = new System.Drawing.Size(224, 44);
            this.BtnVaciarCampos.TabIndex = 60;
            this.BtnVaciarCampos.Text = "Vaciar Campos";
            this.BtnVaciarCampos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVaciarCampos.UseVisualStyleBackColor = false;
            this.BtnVaciarCampos.Click += new System.EventHandler(this.BtnVaciarCampos_Click);
            // 
            // LbRespuesta
            // 
            this.LbRespuesta.AutoSize = true;
            this.LbRespuesta.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRespuesta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LbRespuesta.Location = new System.Drawing.Point(21, 629);
            this.LbRespuesta.Name = "LbRespuesta";
            this.LbRespuesta.Size = new System.Drawing.Size(0, 28);
            this.LbRespuesta.TabIndex = 61;
            // 
            // OpcionesLiquidacionesGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 679);
            this.Controls.Add(this.LbRespuesta);
            this.Controls.Add(this.BtnVaciarCampos);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TbCoutaModeradora);
            this.Controls.Add(this.TbSubTotalCoutaModeradora);
            this.Controls.Add(this.LbSubtotalCoutaModeradora);
            this.Controls.Add(this.TbTopeMaximo);
            this.Controls.Add(this.LbTopeMaximo);
            this.Controls.Add(this.TbTarifa);
            this.Controls.Add(this.LbTarifa);
            this.Controls.Add(this.LbRegimenPaciente);
            this.Controls.Add(this.LbCedula);
            this.Controls.Add(this.TbValorServicio);
            this.Controls.Add(this.TbRegimenPaciente);
            this.Controls.Add(this.LbCoutaModeradora);
            this.Controls.Add(this.LbValorServicio);
            this.Controls.Add(this.TbCedulaPaciente);
            this.Controls.Add(this.LbNumeroDeLiquidacion);
            this.Controls.Add(this.TbNumeroLiquidacion);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpcionesLiquidacionesGui";
            this.Text = "OpcionesLiquidacionesGui";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.Label LbCoutaModeradora;
        private System.Windows.Forms.Label LbValorServicio;
        private System.Windows.Forms.TextBox TbCedulaPaciente;
        private System.Windows.Forms.Label LbNumeroDeLiquidacion;
        private System.Windows.Forms.TextBox TbNumeroLiquidacion;
        private System.Windows.Forms.TextBox TbRegimenPaciente;
        private System.Windows.Forms.Label LbCedula;
        private System.Windows.Forms.TextBox TbValorServicio;
        private System.Windows.Forms.Label LbRegimenPaciente;
        private System.Windows.Forms.TextBox TbTarifa;
        private System.Windows.Forms.Label LbTarifa;
        private System.Windows.Forms.TextBox TbTopeMaximo;
        private System.Windows.Forms.Label LbTopeMaximo;
        private System.Windows.Forms.TextBox TbSubTotalCoutaModeradora;
        private System.Windows.Forms.Label LbSubtotalCoutaModeradora;
        private System.Windows.Forms.TextBox TbCoutaModeradora;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnVaciarCampos;
        private System.Windows.Forms.Label LbRespuesta;
    }
}