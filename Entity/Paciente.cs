using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Paciente : Persona
    {
        public string TipoDeRegimen { get; set; }
        public decimal Salario { get; set; }
        public Paciente(string nombre, string apellido, string cedula, string tipoDeRegimen, decimal salario) : base(nombre, apellido, cedula)
        {
            TipoDeRegimen = tipoDeRegimen;
            Salario = salario;
        }
        public override string ToString()
        {
            return $"{Cedula};{TipoDeRegimen};{Nombre};{Apellido};{Salario}";
        }
       
    }
}
