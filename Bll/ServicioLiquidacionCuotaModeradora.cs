using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Entity;

namespace Bll
{
    public class ServicioLiquidacionCuotaModeradora
    {
        private RepositorioLiquidacionCoutaModuladora repositorioLiquidacionCoutaModuladora = new RepositorioLiquidacionCoutaModuladora();
        public string Guardar(LiquidacionCuotaModeradora liquidacionCuotaModeradora)
        {
            try
            {
                RespuestaBusquedaLiquidacionCuotaModeradora respuestaBusqueda = Buscar(liquidacionCuotaModeradora.NumeroDeLiquidacion);
                string respuesta = IntentarGuardar(respuestaBusqueda, liquidacionCuotaModeradora);
                return respuesta;
            }
            catch (Exception e)
            {
                return $"Error al guardar los datos:  { e.Message }";
            }
        }
        public string IntentarGuardar(RespuestaBusquedaLiquidacionCuotaModeradora respuesta, LiquidacionCuotaModeradora liquidacionCuotaModeradora)
        {
            if (respuesta.LiquidacionCuotaModeradora == null)
            {
                repositorioLiquidacionCoutaModuladora.Guardar(liquidacionCuotaModeradora);
                return $"Datos de la liquidacion de la cuota modoladora Guardados con exito";
            }
            return " error el numero de liquidacion ya se encuentra registrado";
        }
        public RespuestaConsultaLiquidacionCuotaModeradora Consultar()
        {
            RespuestaConsultaLiquidacionCuotaModeradora respuestaConsulta = new RespuestaConsultaLiquidacionCuotaModeradora();
            respuestaConsulta.Error = false;
            try
            {
                respuestaConsulta = ObtenerRespuestaConsulta(respuestaConsulta);
                return respuestaConsulta;
            }
            catch (Exception e)
            {
                respuestaConsulta = ObtenerRespuestaConsulta(respuestaConsulta,e);
                return respuestaConsulta;
            }
        }
        public RespuestaConsultaLiquidacionCuotaModeradora ObtenerRespuestaConsulta(RespuestaConsultaLiquidacionCuotaModeradora respuestaConsulta)
        {
            respuestaConsulta.liquidacionesCuotasModeradora = repositorioLiquidacionCoutaModuladora.Consultar();
            if (respuestaConsulta.liquidacionesCuotasModeradora.Count > 0)
            {
                respuestaConsulta.Mensaje = "registro encontrado con exito";
            }
            else
            {
                respuestaConsulta.Mensaje = "no hay liquidaciones registradas";
            }
            return respuestaConsulta;
        }
        public RespuestaConsultaLiquidacionCuotaModeradora ObtenerRespuestaConsulta(RespuestaConsultaLiquidacionCuotaModeradora respuestaConsulta, Exception e)
        {

            respuestaConsulta.Error = true;
            respuestaConsulta.Mensaje = $"error al consultar la lista de Liquidaciones {e.Message} ";
            respuestaConsulta.liquidacionesCuotasModeradora = null;
            return respuestaConsulta;
        }
        public string Eliminar(string numeroDeLiquidacion)
        {
            try
            {
                RespuestaBusquedaLiquidacionCuotaModeradora respuestaBusqueda = Buscar(numeroDeLiquidacion);
                string respuesta = IntentarEliminar(respuestaBusqueda, numeroDeLiquidacion);
                return respuesta;
            }
            catch (Exception e)
            {
                return $"error  {e.Message}";
            }
        }
        public string IntentarEliminar(RespuestaBusquedaLiquidacionCuotaModeradora respuestaBusqueda , string numeroDeLiquidacion)
        {
            if (respuestaBusqueda.LiquidacionCuotaModeradora != null)
            {
                repositorioLiquidacionCoutaModuladora.Eliminar(numeroDeLiquidacion);
                return $"Paciente eliminado con exito";
            }
            return respuestaBusqueda.Mensaje;
        }
        public string Modificar(LiquidacionCuotaModeradora liquidacionCuotaModeradora)
        {
            try
            {
                RespuestaBusquedaLiquidacionCuotaModeradora respuestaBusqueda = Buscar(liquidacionCuotaModeradora.NumeroDeLiquidacion);
                string respuesta = IntentarModificar(respuestaBusqueda,liquidacionCuotaModeradora);
                return respuesta;
            }
            catch (Exception e)
            {
                return $"error {e.Message}";
            }
        }
        public string IntentarModificar(RespuestaBusquedaLiquidacionCuotaModeradora respuestaBusqueda, LiquidacionCuotaModeradora liquidacionCuotaModeradora)
        {
            if (respuestaBusqueda.LiquidacionCuotaModeradora != null)
            {
                repositorioLiquidacionCoutaModuladora.Modificar(liquidacionCuotaModeradora);
                return $"LiquidacionCuotaModeradora Modificado con exito";
            }
            return respuestaBusqueda.Mensaje;
        }
        public RespuestaBusquedaLiquidacionCuotaModeradora Buscar(string numeroDeLiquidacion)
        {
            RespuestaBusquedaLiquidacionCuotaModeradora respuesta = new RespuestaBusquedaLiquidacionCuotaModeradora();
            respuesta.Error = false;
            try
            {
                respuesta = ObtenerRespuestaBusqueda(respuesta, numeroDeLiquidacion);
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta = ObtenerRespuestaBusqueda(respuesta, e);
                return respuesta;
            }
        }
        public RespuestaBusquedaLiquidacionCuotaModeradora ObtenerRespuestaBusqueda(RespuestaBusquedaLiquidacionCuotaModeradora respuesta, string numeroDeLiquidacion)
        {
            respuesta.LiquidacionCuotaModeradora = repositorioLiquidacionCoutaModuladora.Buscar(numeroDeLiquidacion);
            if (respuesta.LiquidacionCuotaModeradora != null)
            {
                respuesta.Mensaje = "Datos de la liquidacion encontrados con exito";
            }
            else
            {
                respuesta.Mensaje = "Los datos del numero de liquidacion no se encuentra registrado";
            }
            return respuesta;
        }
        public RespuestaBusquedaLiquidacionCuotaModeradora ObtenerRespuestaBusqueda(RespuestaBusquedaLiquidacionCuotaModeradora respuesta, Exception e)
        {
            respuesta.Error = true;
            respuesta.Mensaje = $"error : {e.Message}";
            respuesta.LiquidacionCuotaModeradora = null;
            return respuesta;
        }
    }
}
