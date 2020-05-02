using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Bll
{
    public class Respuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
    }
    public class RespuestaBusquedaPaciente : Respuesta
    {
        public Paciente Paciente;
    }
    public class RespuestaConsultaPaciente : Respuesta
    {
        public IList<Paciente> pacientes;
    }
    public class RespuestaBusquedaLiquidacionCuotaModeradora : Respuesta
    {
        public LiquidacionCuotaModeradora LiquidacionCuotaModeradora;
    }
    public class RespuestaConsultaLiquidacionCuotaModeradora : Respuesta
    {
        public IList<LiquidacionCuotaModeradora> liquidacionesCuotasModeradora;
    }
}
