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
    public partial class RegistrarLiquidacionGui : Form
    {
        ServicioPaciente servicioPaciente = new ServicioPaciente();
        OperacionesCampos campos = new OperacionesCampos();
        VentanaEmergente ventanaEmergente = new VentanaEmergente();
        ServicioLiquidacionCuotaModeradora servicioLiquidacion = new ServicioLiquidacionCuotaModeradora();
        public RegistrarLiquidacionGui()
        {
            InitializeComponent();
        }

        private void BtnCalcularLiquidacionCuotaModeradora_Click(object sender, EventArgs e)
        {
            if (!campos.EsCampoVacio(this))
            {
                LiquidacionCuotaModeradora liquidacion = CrearLiquidacion();
                if (liquidacion != null)
                {
                    LbValorCoutaModeradora.Text= liquidacion.ValorCuotaModeradora.ToString();
                }
            }
            else
            {
                ventanaEmergente.MensajeErrorCampoVacio();
                LbRespuesta.Text = "Error, Llene todos los campos";
            }
        }
        

        private void BtnVaciarCampos_Click(object sender, EventArgs e)
        {
            campos.VaciarCampos(this);
            LbRespuesta.Text = "";
        }

        private void BtnRegistrarLiquidacion_Click(object sender, EventArgs e)
        {
            if (!campos.EsCampoVacio(this))
            {
                LiquidacionCuotaModeradora liquidacion = CrearLiquidacion();
                if (liquidacion != null)
                {
                    string mensaje = servicioLiquidacion.Guardar(liquidacion);
                    LbValorCoutaModeradora.Text = liquidacion.ValorCuotaModeradora.ToString();
                    LbRespuesta.Text = mensaje;
                }
            }
            else
            {
                ventanaEmergente.MensajeErrorCampoVacio();
                LbRespuesta.Text = "Error, Llene todos los campos";
            }
            
        }
        public LiquidacionCuotaModeradora CrearLiquidacion()
        {
            string cedula = TbCedula.Text;
            RespuestaBusquedaPaciente respuestaBusqueda = servicioPaciente.Buscar(cedula);
            if (respuestaBusqueda.Paciente != null)
            {
                DateTime Fecha = DtpMesAño.Value;
                Fecha.ToShortDateString();
                Paciente paciente = respuestaBusqueda.Paciente;
                string numeroDeLiquidacion = TbNumeroLiquidacion.Text;
                float valorServicio = float.Parse(TbValorServicio.Text);
                LiquidacionCuotaModeradoraFactoria liquidacionFactoria = new LiquidacionCuotaModeradoraFactoria();
                LiquidacionCuotaModeradora liquidacion = liquidacionFactoria.CrearLiquidacionCuotaModeradora(numeroDeLiquidacion, valorServicio, paciente,Fecha);
                return liquidacion;
            }
            else
            {
                LbRespuesta.Text = respuestaBusqueda.Mensaje;
                return null;
            }
        }

        private void RegistrarLiquidacionGui_Load(object sender, EventArgs e)
        {

        }
    }

}
