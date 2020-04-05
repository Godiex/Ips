using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Bll;
namespace Ips
{
    public class MenuPaciente : AplicacionDeConsola
    {
        private ServicioPaciente servicioPaciente = new ServicioPaciente();
        public MenuPaciente()
        {
            EjecutarMenuPaciente();
        }
        public override int PedirOpcion()
        {
            CrearTitulo("Menu Gestion De Pacientes");
            int opcion;
            Console.WriteLine("1- Para Registrar Pacientes");
            Console.WriteLine("2- Para Consultar Registros De Pacientes");
            Console.WriteLine("3- Para Para Buscar A un Paciente");
            Console.WriteLine("4- Para Eliminar Un Paciente");
            Console.WriteLine("4- Para Modificar Un Paciente");
            Console.WriteLine("");
            opcion = int.Parse(Leer("Digite La Opcion Deseada :"));
            return opcion;
        }
        public void EjecutarMenuPaciente()
        {
            int opcion;
            do
            {
                opcion = PedirOpcion();
                switch (opcion)
                {
                    case 1:RegistrarPaciente(); break;
                    case 2: MostrarRegistro(); break;
                    case 3:  break;
                }

            } while (opcion != 4);
        }
        public void RegistrarPaciente()
        {
           
            string opcion = "s";
            while (opcion.Equals("s"))
            {
                Paciente paciente = CrearPaciente();
                Console.WriteLine(servicioPaciente.Guardar(paciente));
            }
        }
        public Paciente CrearPaciente()
        {
            CrearTitulo("Formulario - Registrar Paciente");
            string nombre = LeerCadena("Nombre : ");
            string apellido = LeerCadena("Apellido : ");
            string cedula = LeerNumerico("Cedula : ");
            string tipoDeRegimen = AsignarRegimen();
            decimal salario = decimal.Parse(LeerNumerico("Salario Paciente"));
            Paciente paciente = new Paciente(nombre,apellido,cedula,tipoDeRegimen,salario);
            CrearPausa();
            return paciente;
        }
        public void MostrarRegistro()
        {
            CrearTitulo("Consulta Listado De Pacientes");

            servicioPaciente.MostrarRegistro();
            CrearPausa();
        }
        public string AsignarRegimen()
        {
            string mensaje = "Digite -> 's' para regimen sudsidiado o digite 'c' para regimen Contributivo ";
            string letraDeTipoDeRegimen = ValidarTipoDeRegimen(mensaje);
            if (letraDeTipoDeRegimen.Equals("c")) return "Contributivo";
            else return "Sudsidiado";
        }
        public string ValidarTipoDeRegimen(string texto)
        {
            string opcion = LeerCadena(texto).ToLower();
            while ((opcion != "c") && (opcion != "s"))
            {
                opcion = Leer("Error solo puede Digitar -> (c) o Digite ->  (s)");
            }
            return opcion;
        }
    }
}
