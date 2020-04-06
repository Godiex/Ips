using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Bll;

namespace Ips
{
    public class MenuLiquidacionCuotaModuladora : AplicacionDeConsola
    {
        private ServicioPaciente servicioPaciente = new ServicioPaciente();
        private ServicioLiquidacionCuotaModeradora servicioLiquidacionCuotaModeradora = new ServicioLiquidacionCuotaModeradora();
        public MenuLiquidacionCuotaModuladora()
        {
            EjecutarMenuLiquidacionCuotaModeradora();
        }
        public override int PedirOpcion()
        {
            CrearTitulo("Menu Gestion De Liquidacion De Cuota Moduladora");
            int opcion;
            Console.WriteLine("1- Para Realizar Registro De Liquidacion De Cuota Moduladora ");
            Console.WriteLine("2- Para Consulta De Liquidacion De Cuotas Moduladora");
            Console.WriteLine("3- Para Eliminar Registro De Liquidacion Cuota Moduladora ");
            Console.WriteLine("4- Para Modificar Liquidacion De Cuota Moduladora");
            Console.WriteLine("0- Para Salir");
            Console.WriteLine("");
            opcion = int.Parse(LeerNumerico("Digite La Opcion Deseada :"));
            return opcion;
        }
        public void EjecutarMenuLiquidacionCuotaModeradora()
        {
            int opcion;
            do
            {
                opcion = PedirOpcion();
                switch (opcion)
                {
                    case 1: RealizarRegistro(); break;
                    case 2: MostrarRegistroLiquidacionesCuotasModerdoras(); break;
                    case 3: Eliminar(); break;
                    case 4: ModificarCuotaDeLiquidacion(); break;
                }

            } while (opcion != 0);
        }
        public void RealizarRegistro()
        {
            string opcion = "s";
            while (opcion.Equals("s"))
            {
                LiquidacionCuotaModeradora liquidacionCuotaModeradora = CrearLiquidacionCuotaModeradora();
                if (liquidacionCuotaModeradora != null)
                {
                    Console.WriteLine(servicioLiquidacionCuotaModeradora.Guardar(liquidacionCuotaModeradora));
                }
                opcion = ValidarRespuesta("Desea seguir guardando ?  digite s/n");
            }
        }
        public LiquidacionCuotaModeradora CrearLiquidacionCuotaModeradora()
        {
            CrearTitulo("Formulario- Registrar Liquidacion Cuota Moderadora");
            string cedula = LeerNumerico("Digite la cedula del paciente a realizar el registro de la liquidacion");
            Paciente paciente = servicioPaciente.Buscar(cedula);
            if (paciente != null)
            {
                Console.WriteLine("Paciente encontrado con exito");
                paciente.MostrarImformacion();
                LiquidacionCuotaModeradora liquidacionCuotaModeradora = LLenarDatosLiquidacionCuotaModeradora(paciente);
                return liquidacionCuotaModeradora;
            }
            Console.WriteLine("El paciente con la cedula indicada, no se encuentra registrado");
            return null;
        }

        public LiquidacionCuotaModeradora LLenarDatosLiquidacionCuotaModeradora(Paciente paciente)
        {
            string numeroDeLiquidacion = LeerNumerico("Numero De Liquidacion : ");
            float valorDelServicio = float.Parse(LeerNumerico("Valor Del Servicio : "));
            LiquidacionCuotaModeradora liquidacionCuotaModeradora;
            if (paciente.TipoDeRegimen.Equals("Contributivo"))
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
        public void MostrarRegistroLiquidacionesCuotasModerdoras()
        {
            CrearTitulo("Formulario- Consulta Liquidaciones Cuotas Moderadoras");
            List<LiquidacionCuotaModeradora> liquidacionesCuotasModeradoras = servicioLiquidacionCuotaModeradora.Consultar();
            foreach (LiquidacionCuotaModeradora item in liquidacionesCuotasModeradoras)
            {
                item.MostrarDatos();
            }
            CrearPausa();
        }
        public void Eliminar()
        {
            string opcion = "s";
            while (opcion.Equals("s"))
            {
                CrearTitulo("Formulario - Eliminar Liquidacion");
                RealizarBorrado();
                opcion = ValidarRespuesta("Desea seguir guardando ?  digite s/n");
            }

        }
        public void RealizarBorrado()
        {
            string numeroDeLiquidacion = LeerNumerico("Digite el numero de Liquidacion a buscar");
            LiquidacionCuotaModeradora liquidacionCuotaModeradora = servicioLiquidacionCuotaModeradora.Buscar(numeroDeLiquidacion);
            if (liquidacionCuotaModeradora != null)
            {
                Console.WriteLine(servicioLiquidacionCuotaModeradora.Eliminar(numeroDeLiquidacion));
            }
            else
            {
                Console.WriteLine("Error, El numero de Liquidacion digitado no se encuentra registrado");
            }
        }
        public void ModificarCuotaDeLiquidacion()
        {
            string numeroDeLiquidacion = LeerNumerico("Digite el numero de Liquidacion a buscar");
            LiquidacionCuotaModeradora liquidacionCuotaModeradoraAuxliar = servicioLiquidacionCuotaModeradora.Buscar(numeroDeLiquidacion);
            if (liquidacionCuotaModeradoraAuxliar != null)
            {
                Console.WriteLine("Datos de la liquidacion encontrado con exito");
                LiquidacionCuotaModeradora liquidacionCuotaModeradora = ObtenerliquidacionCuotaModeradoraModificada(liquidacionCuotaModeradoraAuxliar);
                servicioLiquidacionCuotaModeradora.Modificar(liquidacionCuotaModeradora);
            }
            else
            {
                Console.WriteLine("Error, El numero de Liquidacion digitado no se encuentra registrado");
            }
        }
        public LiquidacionCuotaModeradora ObtenerliquidacionCuotaModeradoraModificada(LiquidacionCuotaModeradora liquidacionCuotaModeradora)
        {
            float valorDelServicio = float.Parse(LeerNumerico("Digite El Nuevo Valor Del Servicio : "));
            liquidacionCuotaModeradora.ValorServicio = valorDelServicio;
            liquidacionCuotaModeradora.AsignarTopeMaximo();
            liquidacionCuotaModeradora.CalcularCuotaModeradora();
            return liquidacionCuotaModeradora;

        }
    }

}
