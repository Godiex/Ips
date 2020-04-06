
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Sudsidiado : LiquidacionCuotaModeradora
    {
        public Sudsidiado(string numeroDeLiquidacion, float valorServicio, Paciente paciente) : base(numeroDeLiquidacion, valorServicio,"Sudsidiado", paciente)
        {
        }
        public Sudsidiado()
        {

        }
        public override void AsignarTarifa()
        {
            Tarifa = (float)0.05;
        }
        public override void AsignarTopeMaximo()
        {
            AsignarTarifa();
            TopeMaximo = 200000;
        }
    }
}
