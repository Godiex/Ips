﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Ips
{
    public partial class MenuPrincipalGui : Form
    {
        public MenuPrincipalGui()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void PbSalir_Click(object sender, EventArgs e)
        {
            string mensaje = "Esta seguro que desea salir ?";
            string titulo = "Avertencia !!!";
            var resultado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void PbMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            PbRestaurar.Visible = true;
            PbMaximizar.Visible = false;
        }

        private void PbRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            PbMaximizar.Visible = true;
            PbRestaurar.Visible = false;
        }

        private void PbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            LbHora.Text = DateTime.Now.ToShortTimeString();
            LbFecha.Text = DateTime.Now.ToShortDateString();
        }
        private void AbrirFormHijo(object FormHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }
            Form Fh = FormHijo as Form;
            Fh.TopLevel = false;
            Fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(Fh);
            this.PanelContenedor.Tag = Fh;
            Fh.Show();
        }

        private void BtnRegistrarPaciente_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegistrarLiquidacionCoutaModeradora_Click(object sender, EventArgs e)
        {

        }

        private void BtnOperacionesCuotasModeradoras_Click(object sender, EventArgs e)
        {

        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {

        }
    }
}
