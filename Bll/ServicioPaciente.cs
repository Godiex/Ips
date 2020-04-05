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
                Paciente pacienteAuxiliar = Buscar(paciente.Cedula);
                if (pacienteAuxiliar == null)
                {
                    pacienteRepositorio.Guardar(paciente);
                    return $"Datos del pacientes Guardados con exito";
                }
                return $"El paciente con cedula :{pacienteAuxiliar.Cedula }, ya se encuentra registrado";
            }
            catch (Exception e)
            {
                return $"Error al guardar los datos:  { e.Message }";
            }
        }
        public List<Paciente> Consultar()
        {
            try
            {
                List<Paciente> pacientes = pacienteRepositorio.Consultar();
                return pacientes;
            }
            catch (Exception e)
            {
                Console.WriteLine("error al consultar la lista de pacientes "+ e.Message);
                return null;
            }
        }
        public string Eliminar(string cedula)
        {
            try
            {
                 pacienteRepositorio.Eliminar(cedula);
                 return $"Paciente eliminado con exito";
            }
            catch (Exception e)
            {

                return $"error {e.Message}";
            }
        }
        public string Modificar( Paciente paciente)
        {
            try
            {
                pacienteRepositorio.Modificar(paciente);
                return $"Paciente Modificado con exito";
            }
            catch (Exception e)
            {
                return $"error {e.Message}";
            }
        }
        public Paciente Buscar(string cedula)
        {
            try
            {
                Paciente paciente = pacienteRepositorio.Buscar(cedula);
                return paciente;
            }
            catch (Exception e)
            {
                Console.WriteLine("error en al buscar paciente"+ e.Message);
                return null;
            }
        }
        public void MostrarImformacionDelPaciente (Paciente paciente)
        {
            Console.WriteLine("Nombre : " + paciente.Nombre);
            Console.WriteLine("Apellido : " + paciente.Apellido);
            Console.WriteLine("Tipo De Regimen : " + paciente.TipoDeRegimen);
        }
        public void MostrarRegistro()
        {
            Console.WriteLine("{0,10}{1,17}{2,15}{3,15}{4,10}","Cedula","Tipo De Regimen","Nombre","Apellido","Salario");
            Console.WriteLine();
            List<Paciente> pacientes = Consultar();
            foreach (Paciente paciente in pacientes)
            {
                ImprimirDatos(paciente);
            }
        }
        public void ImprimirDatos(Paciente paciente)
        {
            Console.WriteLine("{0,10}{1,17}{2,15}{3,15}{4,10}", paciente.Cedula, paciente.TipoDeRegimen, paciente.Nombre, paciente.Apellido, paciente.Salario);
        }
    }
}
