using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Contributivo : LiquidacionCuotaModeradora
    {
        public decimal SalarioMinimo = (decimal)980657;

        public Contributivo(string numeroDeLiquidacion, float valorServicio, Paciente paciente) : base(numeroDeLiquidacion, valorServicio, "Contributivo", paciente)
        {
        }

        public override void AsignarTopeMaximo()
        {
            AsignarTarifa();
            switch (Tarifa)
            {
                case (float)0.15: TopeMaximo = 250000; break;
                case (float)0.20: TopeMaximo = 900000; break;
                case (float)0.25: TopeMaximo = 1500000; break;
            }
        }
        public override void AsignarTarifa()
        {
            Tarifa = ObtenerValorDeTarifa();
        }
        public float ObtenerValorDeTarifa()
        {
            if (EsMenorADosSalariosMinimo()) return (float)0.15;
            if (EsMayorADosSalariosMinimoYMenorACincoSalariosMinimo()) return (float)0.20;
            else return (float)0.25;
            
        }
        public bool EsMenorADosSalariosMinimo()
        {
            decimal valorDeDosSalariosMinimo = SalarioMinimo * 2;
            if (Paciente.Salario<valorDeDosSalariosMinimo) return true;
            return false;
        }
        public bool EsMayorADosSalariosMinimoYMenorACincoSalariosMinimo()
        {
            decimal valorDeDosSalariosMinimo = SalarioMinimo * 2;
            decimal valorDeCincoSalariosMinimo = SalarioMinimo * 5;
            if ( (Paciente.Salario >= valorDeDosSalariosMinimo) && (Paciente.Salario <= valorDeCincoSalariosMinimo) )
            {
                return true;
            }
            return false;
        }
       
    }
}

