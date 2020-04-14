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
        public LiquidacionCuotaModeradora CrearLiquidacionCuotaModeradora(string TipoDeRegimen, string numeroDeLiquidacion, float valorDelServicio, Paciente paciente)
        {
            LiquidacionCuotaModeradora liquidacionCuotaModeradora;
            if (TipoDeRegimen.Equals("Contributivo"))
            {
                liquidacionCuotaModeradora = new Contributivo(numeroDeLiquidacion, valorDelServicio, paciente);
                liquidacionCuotaModeradora.AsignarTopeMaximo();
                liquidacionCuotaModeradora.CalcularCuotaModeradora();
                return liquidacionCuotaModeradora;
            }
            else
            {
                liquidacionCuotaModeradora = new Sudsidiado(numeroDeLiquidacion, valorDelServicio, paciente);
                liquidacionCuotaModeradora.AsignarTopeMaximo();
                liquidacionCuotaModeradora.CalcularCuotaModeradora();
                return liquidacionCuotaModeradora;
            }
        }
    }
}
