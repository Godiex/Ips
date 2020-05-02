using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class LiquidacionCuotaModeradora
    {
        public string Tipo { get; set; }
        public string NumeroDeLiquidacion { get; set; }
        public float Tarifa { get; set; }
        public float ValorServicio { get; set; }
        public float ValorCuotaModeradora { get; set; }
        public float SubValorCuotaModeradora { get; set; }
        public Paciente Paciente { get; set; }
        public float TopeMaximo { get; set; }
        public DateTime Fecha { get; set; }
        public LiquidacionCuotaModeradora(string numeroDeLiquidacion, float valorServicio,string tipo, Paciente paciente)
        {
            Tipo = tipo;
            NumeroDeLiquidacion = numeroDeLiquidacion;
            ValorServicio = valorServicio;
            Paciente = paciente;
        }
        public LiquidacionCuotaModeradora()
        {

        }
        public abstract void AsignarTopeMaximo();
        public abstract void AsignarTarifa();
        public void CalcularCuotaModeradora()
        { 
            SubValorCuotaModeradora = ValorServicio * Tarifa;
            if (SubValorCuotaModeradora > TopeMaximo)
            {
                ValorCuotaModeradora = TopeMaximo;
            }
            else
            {
                ValorCuotaModeradora = SubValorCuotaModeradora;
            }
            
        }
        
        public override string ToString()
        {
            return $"{Paciente.ToString()};{NumeroDeLiquidacion};{ValorServicio};{Tipo};{Tarifa};{SubValorCuotaModeradora};{ValorCuotaModeradora};{TopeMaximo};{Fecha}";
        }
    }
}
