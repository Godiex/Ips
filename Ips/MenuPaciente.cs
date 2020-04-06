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
            Console.WriteLine("3- Para Eliminar Un Paciente");
            Console.WriteLine("4- Para Modificar Un Paciente");
            Console.WriteLine("0- Para Salir");
            Console.WriteLine("");
            opcion = int.Parse(LeerNumerico("Digite La Opcion Deseada :"));
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
                    case 2:MostrarRegistro()  ; break;
                    case 3:EliminarPaciente(); break;
                    case 4:ModificarPaciente(); break;

                }

            } while (opcion != 0);
        }
        public void RegistrarPaciente()
        {
           
            string opcion = "s";
            while (opcion.Equals("s"))
            {
                Paciente paciente = CrearPaciente();
                Console.WriteLine(servicioPaciente.Guardar(paciente));
                opcion = ValidarRespuesta("Desea seguir guardando ?  digite s/n");
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
        public void EliminarPaciente()
        {
            string opcion = "s";
            while (opcion.Equals("s"))
            {
                CrearTitulo("Formulario- Eliminar Paciente");
                string cedula = LeerNumerico("Digite La Cedula A Eliminar :");
                Paciente paciente = servicioPaciente.Buscar(cedula);
                if (paciente != null)
                {
                    Console.WriteLine(servicioPaciente.Eliminar(cedula));
                }
                else
                {
                    Console.WriteLine("Error el paciente no se encuentra registrado");
                }
                opcion = ValidarRespuesta("Desea seguir eliminando s/n");
            }

        }
        public void ModificarPaciente()
        {
            string opcion = "s";
            while (opcion.Equals("s"))
            {
                CrearTitulo("Formulario- Modificar Paciente");
                RealizarModificacion();
                opcion = ValidarRespuesta("Desea seguir Modificando s/n");
            }
        }
        public void RealizarModificacion()
        {
            string cedula = LeerNumerico("Digite La Cedula A Del Paciente Modificar :");
            Paciente pacienteAuxliar = servicioPaciente.Buscar(cedula);
            if (pacienteAuxliar != null)
            {
                Paciente paciente = ObtenerPacienteModificado(pacienteAuxliar.Cedula, pacienteAuxliar.TipoDeRegimen);
                servicioPaciente.Modificar(paciente);
            }
            else
            {
                Console.WriteLine("Error el paciente no se encuentra registrado");
            }

        }
        public Paciente ObtenerPacienteModificado(string cedula,string tipoDeRegimen)
        {
            string nombre = LeerCadena("Nombre : ");
            string apellido = LeerCadena("Apellido : ");
            decimal salario = decimal.Parse(LeerNumerico("Salario Paciente"));
            Paciente paciente = new Paciente(nombre, apellido, cedula, tipoDeRegimen, salario);
            CrearPausa();
            return paciente;
        }
    }
}
