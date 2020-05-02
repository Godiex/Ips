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
    public partial class ModificarGui : Form
    {
        OperacionesCampos campos = new OperacionesCampos();
        VentanaEmergente ventanaEmergente = new VentanaEmergente();
        ServicioLiquidacionCuotaModeradora servicioLiquidacion = new ServicioLiquidacionCuotaModeradora();
        public ModificarGui()
        {
            InitializeComponent();
        }

        private void PbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnCalcularLiquidacionCuotaModeradora_Click(object sender, EventArgs e)
        {

            if (!campos.EsCampoVacio(this))
            {
                string numeroLiquidacion = LbValorNumeroLiquidacion.Text;
                RespuestaBusquedaLiquidacionCuotaModeradora respuestaBusqueda = servicioLiquidacion.Buscar(numeroLiquidacion);
                LiquidacionCuotaModeradora liquidacion = respuestaBusqueda.LiquidacionCuotaModeradora;
                LiquidacionCuotaModeradora liquidacionModificada = ObtenerLiquidacionModificada(liquidacion);
                if (liquidacionModificada != null)
                {
                    LbValorCoutaModeradora.Text = liquidacionModificada.ValorCuotaModeradora.ToString();
                }
            }
            else
            {
                ventanaEmergente.MensajeErrorCampoVacio();
                LbRespuesta.Text = "Error, Llene todos los campos";
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            string numeroLiquidacion = LbValorNumeroLiquidacion.Text;
            RespuestaBusquedaLiquidacionCuotaModeradora respuestaBusqueda = servicioLiquidacion.Buscar(numeroLiquidacion);
            LiquidacionCuotaModeradora liquidacion = respuestaBusqueda.LiquidacionCuotaModeradora;
            LiquidacionCuotaModeradora liquidacionModificada = ObtenerLiquidacionModificada(liquidacion);
            string mensaje = servicioLiquidacion.Modificar(liquidacionModificada);
            LbRespuesta.Text = mensaje;
        

    }
        public LiquidacionCuotaModeradora ObtenerLiquidacionModificada(LiquidacionCuotaModeradora liquidacion)
        {
            float valorServicio = float.Parse(TbValorServicio.Text);
            LiquidacionCuotaModeradoraFactoria liquidacionFactoria = new LiquidacionCuotaModeradoraFactoria();
            LiquidacionCuotaModeradora liquidacionModificada = liquidacionFactoria.CrearLiquidacionCuotaModeradora(liquidacion.NumeroDeLiquidacion, valorServicio, liquidacion.Paciente,liquidacion.Fecha);
            return liquidacionModificada;
        }
            
    }
}
