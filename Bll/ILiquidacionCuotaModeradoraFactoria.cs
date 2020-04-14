using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace Bll
{
    public interface ILiquidacionCuotaModeradoraFactoria
    {
        LiquidacionCuotaModeradora CrearLiquidacionCuotaModeradora(string TipoDeRegimen,string numeroDeLiquidacion, float valorDelServicio, Paciente paciente);
    }

}
