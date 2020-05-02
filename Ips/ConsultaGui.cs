using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll;
using Entity;
namespace Ips
{
    public partial class ConsultaGui : Form
    {
        OperacionesCampos campos = new OperacionesCampos();
        VentanaEmergente ventanaEmergente = new VentanaEmergente();
        ServicioLiquidacionCuotaModeradora servicioLiquidacion = new ServicioLiquidacionCuotaModeradora();
        public ConsultaGui()
        {
            InitializeComponent();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            RealizarConsulta();
        }
        public void MostrarConsultaLiquidacionesPorFiltro()
        {
            VaciarLabelsCantidadLiquidaciones();
            campos.VaciarCampos(this);
            DgvLiquidacion.Rows.Clear();
            RespuestaConsultaLiquidacionCuotaModeradora respuestaConsulta = servicioLiquidacion.Consultar();
            IList<LiquidacionCuotaModeradora> liquidaciones;
            if (CbTipoConsulta.Text.Equals("Todos"))
            {
                liquidaciones = respuestaConsulta.liquidacionesCuotasModeradora;
                LlenarDataGridView(liquidaciones);
            }
            else
            {
                if (CbTipoConsulta.Text.Equals("Contributivo"))
                {
                    liquidaciones = servicioLiquidacion.ConsultarPorRegimen("Contributivo");
                    LlenarDataGridView(liquidaciones);
                }
                else
                {
                    liquidaciones = servicioLiquidacion.ConsultarPorRegimen("Sudsidiado");
                    LlenarDataGridView(liquidaciones);
                }
            }
            LlenarLabelsCantidadDeLiquidaciones();
            LlenarTextBoxTotalizaciones();
        }
        
        public void LlenarTextBoxTotalizaciones()
        {
            if (CbTipoConsulta.Text.Equals("Todos"))
            {
                TbTotalLquidaciones.Text = servicioLiquidacion.TotalizarLiquidaciones().ToString();
                TbTotalLiquidacionSubsidiado.Text = servicioLiquidacion.TotalizarLiquidacionesPorRegimen("Contributivo").ToString();
                TbTotalLiquidacionContributivo.Text = servicioLiquidacion.TotalizarLiquidacionesPorRegimen("Sudsidiado").ToString();
                
            }
            else
            {
                if (CbTipoConsulta.Text.Equals("Contributivo"))
                {
                    TbTotalLiquidacionSubsidiado.Text = servicioLiquidacion.TotalizarLiquidacionesPorRegimen("Contributivo").ToString();
                }
                else
                {
                    TbTotalLiquidacionContributivo.Text = servicioLiquidacion.TotalizarLiquidacionesPorRegimen("Sudsidiado").ToString();
                }
            }
        }
        public void VaciarLabelsCantidadLiquidaciones()
        {
            LbValorCantidadTotal.Text = "";
            LbValorCantidadSudsidiado.Text = "";
            LbValorCantidadTotalContributivo.Text = "";

        }
        public void LlenarLabelsCantidadDeLiquidaciones()
        {
            if (CbTipoConsulta.Text.Equals("Todos"))
            {

                LbValorCantidadTotal.Text = servicioLiquidacion.ObtenerCantidadLiquidaciones().ToString();
                LbValorCantidadSudsidiado.Text = servicioLiquidacion.ObtenerCantidadLiquidacionesPorRegimen("Sudsidiado").ToString();
                LbValorCantidadTotalContributivo.Text = servicioLiquidacion.ObtenerCantidadLiquidacionesPorRegimen("Contributivo").ToString();
            }
            else
            {
                if (CbTipoConsulta.Text.Equals("Contributivo"))
                {
                    LbValorCantidadTotalContributivo.Text = servicioLiquidacion.ObtenerCantidadLiquidacionesPorRegimen("Contributivo").ToString();
                }
                else
                {
                    LbValorCantidadSudsidiado.Text = servicioLiquidacion.ObtenerCantidadLiquidacionesPorRegimen("Sudsidiado").ToString();
                }
            }
        }
        public void RealizarConsulta()
        {
            if (CbTipo.Checked == true)
            {
                MostrarConsultaLiquidacionesPorFiltro();
            }
            else
            {
                if (CbFecha.Checked == true)
                {
                    ConsultarPorfecha();
                }
                else
                {
                    ConsultarPorApellido();
                }
            }
        }
        public void ConsultarPorApellido()
        {
            campos.VaciarCampos(this);
            DgvLiquidacion.Rows.Clear();
            servicioLiquidacion.Consultar();
            string apellido = TbApellido.Text;
            IList<LiquidacionCuotaModeradora> liquidaciones = servicioLiquidacion.ConsultarPorApellido(apellido);
            LlenarDataGridView(liquidaciones);
        }
        public void ConsultarPorfecha()
        {
            campos.VaciarCampos(this);
            DgvLiquidacion.Rows.Clear();
            servicioLiquidacion.Consultar();
            IList<LiquidacionCuotaModeradora> liquidaciones = servicioLiquidacion.ConsultarPorFecha(DtpMesAño.Value);
            LlenarTotalesPorRegimenYFecha();
            LlenarDataGridView(liquidaciones);
        }
        public void LlenarTotalesPorFecha()
        {
            
        }
        public void LlenarTotalesPorRegimenYFecha()
        {
            DateTime fecha = DtpMesAño.Value;
            LbValorCantidadTotal.Text = servicioLiquidacion.ObtenerCantidadLiquidacionesPorFecha(fecha).ToString();
            LbValorCantidadSudsidiado.Text = servicioLiquidacion.ObtenerCantidadPorRegimenYPorFecha(fecha, "Sudsidiado").ToString();
            LbValorCantidadTotalContributivo.Text = servicioLiquidacion.ObtenerCantidadPorRegimenYPorFecha(fecha, "Contributivo").ToString();
        }
        public void LlenarDataGridView(IList<LiquidacionCuotaModeradora> liquidaciones)
        {
            string tope;
            foreach (var item in liquidaciones)
            {
                if (item.SubValorCuotaModeradora > item.TopeMaximo) tope = "Si";
                else tope = "No";
                DgvLiquidacion.Rows.Add(item.Paciente.Cedula ,item.Paciente.TipoDeRegimen, item.Paciente.Salario, item.ValorServicio, item.Tarifa, item.SubValorCuotaModeradora, tope, item.ValorCuotaModeradora);
            }
        }

        private void PanelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CbTipo_CheckedChanged(object sender, EventArgs e)
        {
            if (CbTipo.Checked ==true)
            {
                CbApellido.Enabled = false;
                CbFecha.Enabled = false;
            }
            else
            {
                CbApellido.Enabled = true;
                CbFecha.Enabled = true;
            }

        }

        private void CbFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (CbFecha.Checked == true)
            {
                CbApellido.Enabled = false;
                CbTipo.Enabled = false;
            }
            else
            {
                CbApellido.Enabled = true;
                CbTipo.Enabled = true;
            }
            
        }

        private void CbApellido_CheckedChanged(object sender, EventArgs e)
        {
            if (CbApellido.Checked == true)
            {
                CbTipo.Enabled = false;
                CbFecha.Enabled = false;
            }
            else
            {
                CbTipo.Enabled = true;
                CbFecha.Enabled = true;
            }
            
        }

    }
}
