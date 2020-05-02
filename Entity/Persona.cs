using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public Persona()
        {
            
        }
        public Persona(string nombre, string apellido, string cedula)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
        }
    }
}
