using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Entity;
namespace Bll
{
    public class ServicioPaciente
    {
        PacienteRepositorio pacienteRepositorio = new PacienteRepositorio();
        public string Guardar(Paciente paciente)
        {
            try
            {
                RespuestaBusquedaPaciente respuestaBusqueda = Buscar(paciente.Cedula);
                if (respuestaBusqueda.Paciente == null)
                {
                    pacienteRepositorio.Guardar(paciente);
                    return $"Datos del pacientes Guardados con exito";
                }
                return $"El paciente con cedula :{paciente.Cedula }, ya se encuentra registrado";
            }
            catch (Exception e)
            {
                return $"Error al guardar los datos:  { e.Message }";
            }
        }
        public RespuestaConsultaPaciente Consultar()
        {
            RespuestaConsultaPaciente respuestaConsulta = new RespuestaConsultaPaciente();
            respuestaConsulta.Error = false;
            try
            {
                respuestaConsulta = ObtenerRespuetaConsulta(respuestaConsulta);
                return respuestaConsulta;
            }
            catch (Exception e)
            {
                respuestaConsulta.Error = true;
                respuestaConsulta.Mensaje = $"Error : {e.Message}";
                return respuestaConsulta;
            }
        }
        public RespuestaConsultaPaciente ObtenerRespuetaConsulta(RespuestaConsultaPaciente respuetaConsulta)
        {
            respuetaConsulta.pacientes = pacienteRepositorio.Consultar();
            if (respuetaConsulta.pacientes.Count >0)
            {
                respuetaConsulta.Mensaje = $"Registro de pacientes";
                return respuetaConsulta;
            }
            else
            {
                respuetaConsulta.Mensaje = $"No se encuentran pacientes resgistrados";
                return respuetaConsulta;
            }
        }
        public string Eliminar(string cedula)
        {
            try
            {
                RespuestaBusquedaPaciente respuetaBusqueda = Buscar(cedula);
                if (respuetaBusqueda.Paciente != null)
                {
                    pacienteRepositorio.Eliminar(cedula);
                    return $"Paciente eliminado con exito";
                }
                return respuetaBusqueda.Mensaje;
            }
            catch (Exception e)
            {
                return $"error {e.Message}";
            }
        }
        public string Modificar(Paciente paciente)
        {
            try
            {
                RespuestaBusquedaPaciente respuetaBusqueda = Buscar(paciente.Cedula);
                if (respuetaBusqueda.Paciente != null)
                {
                    pacienteRepositorio.Modificar(paciente);
                    return $"Paciente Modificado con exito";
                }
                return respuetaBusqueda.Mensaje;
            }
            catch (Exception e)
            {
                return $"error {e.Message}";
            }
        }
        public RespuestaBusquedaPaciente Buscar(string cedula)
        {
            RespuestaBusquedaPaciente respuestaBusqueda = new RespuestaBusquedaPaciente();
            respuestaBusqueda.Error = false;
            try
            {
                respuestaBusqueda = ObtenerRespuestaBusqueda(respuestaBusqueda,cedula);
                return respuestaBusqueda;
            }
            catch (Exception e)
            {
                respuestaBusqueda = ObtenerRespuestaBusqueda(respuestaBusqueda, e);
                return respuestaBusqueda;
            }
        }
        public RespuestaBusquedaPaciente ObtenerRespuestaBusqueda(RespuestaBusquedaPaciente respuetaBusqueda , string cedula)
        {
            respuetaBusqueda.Paciente = pacienteRepositorio.Buscar(cedula);
            if (respuetaBusqueda.Paciente != null)
            {
                respuetaBusqueda.Mensaje = "Paciente encontrado con exito";
            }
            else
            {
                respuetaBusqueda.Mensaje = "Error, el paciente no se encuentra registrado";
            }
            return respuetaBusqueda;
        }
        public RespuestaBusquedaPaciente ObtenerRespuestaBusqueda(RespuestaBusquedaPaciente respuestaBusqueda, Exception e)
        {
            respuestaBusqueda.Error = true;
            respuestaBusqueda.Mensaje = $"error :  {e.Message}";
            return respuestaBusqueda;
        }
    }
}
