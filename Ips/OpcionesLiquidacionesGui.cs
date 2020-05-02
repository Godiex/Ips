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
    public partial class OpcionesLiquidacionesGui : Form
    {
        OperacionesCampos campos = new OperacionesCampos();
        VentanaEmergente ventanaEmergente = new VentanaEmergente();
        ServicioLiquidacionCuotaModeradora servicioLiquidacion = new ServicioLiquidacionCuotaModeradora();
        public OpcionesLiquidacionesGui()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (!NumeroLiquidacionEsCampoVacio())
            {
                Buscar();
            }
            else
            {
                ventanaEmergente.MensajeErrorCampoVacio("Error llene el campo numero de liquidacion");
                EscribirRespuesta("Error llene el campo numero de liquidacion");
            }
        }
        public void Buscar()
        {
            string numeroLiquidacion = TbNumeroLiquidacion.Text;
            RespuestaBusquedaLiquidacionCuotaModeradora respuestaBusqueda = servicioLiquidacion.Buscar(numeroLiquidacion);
            LiquidacionCuotaModeradora liquidacion = respuestaBusqueda.LiquidacionCuotaModeradora;
            if (liquidacion != null)
            {
                EscribirRespuesta(liquidacion, respuestaBusqueda.Mensaje);
                MapearLiquidacion(liquidacion);
            }
            else
            {
                EscribirRespuesta(liquidacion, respuestaBusqueda.Mensaje);
            }
        }
        public void MapearLiquidacion(LiquidacionCuotaModeradora liquidacion)
        {
            TbCedulaPaciente.Text = liquidacion.Paciente.Cedula;
            TbRegimenPaciente.Text = liquidacion.Tipo;
            TbValorServicio.Text = liquidacion.ValorServicio.ToString();
            TbTarifa.Text = liquidacion.Tarifa.ToString();
            TbTopeMaximo.Text = liquidacion.TopeMaximo.ToString();
            TbSubTotalCoutaModeradora.Text = liquidacion.SubValorCuotaModeradora.ToString();
            TbCoutaModeradora.Text = liquidacion.ValorCuotaModeradora.ToString();
        }

        public void EscribirRespuesta (LiquidacionCuotaModeradora liquidacion,string mensaje)
        {
            if (liquidacion != null)
            {
                LbRespuesta.ForeColor = System.Drawing.Color.Lime;
                LbRespuesta.Text = mensaje;
            }
            else
            {
                LbRespuesta.ForeColor = System.Drawing.Color.Red;
                LbRespuesta.Text = mensaje;
            }
        }
        public void EscribirRespuesta(string mensaje)
        {
             LbRespuesta.ForeColor = System.Drawing.Color.Red;
             LbRespuesta.Text = mensaje;
        }
        private void BtnVaciarCampos_Click(object sender, EventArgs e)
        {
            VaciarCampos();
        }
        public void VaciarCampos()
        {
            campos.VaciarCampos(this);
            LbRespuesta.Text = "";
        }
        public bool NumeroLiquidacionEsCampoVacio()
        {
            if (TbNumeroLiquidacion.Text.Length.Equals(0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (!NumeroLiquidacionEsCampoVacio())
            {
                string numeroLiquidacion = TbNumeroLiquidacion.Text;
                RespuestaBusquedaLiquidacionCuotaModeradora respuestaBusqueda = servicioLiquidacion.Buscar(numeroLiquidacion);
                LiquidacionCuotaModeradora liquidacion = respuestaBusqueda.LiquidacionCuotaModeradora;
                AbrirFormularioModificar(liquidacion);
            }
            else
            {
                ventanaEmergente.MensajeErrorCampoVacio("Error llene el campo numero de liquidacion");
                EscribirRespuesta("Error llene el campo numero de liquidacion");
            }
            
        }
        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (!NumeroLiquidacionEsCampoVacio())
            {
                EliminarLiquidacion();
            }
            else
            {
                EscribirRespuesta("Error llene el campo numero de liquidacion");
            }
            
        }
        public void EliminarLiquidacion()
        {
            string numeroLiquidacion = TbNumeroLiquidacion.Text;
            RespuestaBusquedaLiquidacionCuotaModeradora respuestaBusqueda = servicioLiquidacion.Buscar(numeroLiquidacion);
            LiquidacionCuotaModeradora liquidacion = respuestaBusqueda.LiquidacionCuotaModeradora;
            if (liquidacion != null)
            {
                var respuesta = ventanaEmergente.ValidarElimiar();
                if (respuesta == DialogResult.Yes)
                {
                   string mensaje = servicioLiquidacion.Eliminar(numeroLiquidacion);
                   EscribirRespuesta(liquidacion,mensaje);
                }
            }
            else
            {
                EscribirRespuesta(respuestaBusqueda.Mensaje);
            }
            
        }
        private void AbrirFormularioModificar(LiquidacionCuotaModeradora liquidacion)
        {
            if (liquidacion != null)
            {
                ModificarGui formulario = new ModificarGui();
                formulario.LbValorNumeroLiquidacion.Text = TbNumeroLiquidacion.Text;
                formulario.Show();
            }
            else
            {
                EscribirRespuesta("error,los datos no se encuentran resgitrados");
            }
        }
    }
}
