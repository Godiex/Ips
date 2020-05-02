using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace Bll
{
    public class LiquidacionCuotaModeradoraFactoria: ILiquidacionCuotaModeradoraFactoria
    {
        public LiquidacionCuotaModeradora CrearLiquidacionCuotaModeradora( string numeroDeLiquidacion, float valorDelServicio, Paciente paciente,DateTime fecha)
        {
            LiquidacionCuotaModeradora liquidacionCuotaModeradora;
            if (paciente.TipoDeRegimen.Equals("Contributivo"))
            {
                liquidacionCuotaModeradora = new Contributivo(numeroDeLiquidacion, valorDelServicio, paciente);
                liquidacionCuotaModeradora.AsignarTopeMaximo();
                liquidacionCuotaModeradora.CalcularCuotaModeradora();
                liquidacionCuotaModeradora.Fecha = fecha;
                return liquidacionCuotaModeradora;
            }
            else
            {
                liquidacionCuotaModeradora = new Sudsidiado(numeroDeLiquidacion, valorDelServicio, paciente);
                liquidacionCuotaModeradora.AsignarTopeMaximo();
                liquidacionCuotaModeradora.CalcularCuotaModeradora();
                liquidacionCuotaModeradora.Fecha = fecha;
                return liquidacionCuotaModeradora;
            }
        }
    }
}
