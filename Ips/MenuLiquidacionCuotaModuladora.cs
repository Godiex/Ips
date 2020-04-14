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
            RespuestaBusquedaPaciente respueta = servicioPaciente.Buscar(cedula);
            if (respueta.Paciente != null)
            {
                Console.WriteLine(respueta.Mensaje);
                MostrarImformacion(respueta.Paciente);
                LiquidacionCuotaModeradora liquidacionCuotaModeradora = LLenarDatosLiquidacionCuotaModeradora(respueta.Paciente);
                return liquidacionCuotaModeradora;
            }
            Console.WriteLine(respueta.Mensaje);
            return null;
        }

        public LiquidacionCuotaModeradora LLenarDatosLiquidacionCuotaModeradora(Paciente paciente)
        {
            string numeroDeLiquidacion = LeerNumerico("Numero De Liquidacion : ");
            float valorDelServicio = float.Parse(LeerNumerico("Valor Del Servicio : "));
            LiquidacionCuotaModeradoraFactoria liquidacionFactoria = new LiquidacionCuotaModeradoraFactoria();
            LiquidacionCuotaModeradora liquidacionCuotaModeradora= liquidacionFactoria.CrearLiquidacionCuotaModeradora(paciente.TipoDeRegimen,numeroDeLiquidacion,valorDelServicio,paciente);
            return liquidacionCuotaModeradora;
        }
        public void MostrarRegistroLiquidacionesCuotasModerdoras()
        {
            CrearTitulo("Formulario- Consulta Liquidaciones Cuotas Moderadoras");
            RespuestaConsultaLiquidacionCuotaModeradora respuestaConsulta = servicioLiquidacionCuotaModeradora.Consultar();
            Console.WriteLine(respuestaConsulta.Mensaje);
            if (respuestaConsulta.liquidacionesCuotasModeradora != null)
            {
                foreach (LiquidacionCuotaModeradora item in respuestaConsulta.liquidacionesCuotasModeradora)
                {
                    MostrarDatos(item);
                }    
            }
            CrearPausa();
        }
        public void MostrarDatos(LiquidacionCuotaModeradora liquidacionCuotaModeradora)
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Imformacion Del Paciente");
            MostrarImformacion(liquidacionCuotaModeradora.Paciente);
            Console.WriteLine("");
            Console.WriteLine("Imformacion De La Liquidacion");
            Console.WriteLine("");
            Console.WriteLine("NumeroDeLiquidacion : " + liquidacionCuotaModeradora.NumeroDeLiquidacion + "      Tipo : " + liquidacionCuotaModeradora.Tipo + "     Tarifa: " + liquidacionCuotaModeradora.Tarifa);
            Console.WriteLine("");
            Console.WriteLine("Tope Maximo : " + liquidacionCuotaModeradora.TopeMaximo + "      Valor Del Servicio : " + liquidacionCuotaModeradora.ValorServicio + "      Sudvalor Cuota Moderadora : " + liquidacionCuotaModeradora.SubValorCuotaModeradora + "     ValorCuotaModeradora: " + liquidacionCuotaModeradora.ValorCuotaModeradora);
        }
        public void MostrarImformacion(Paciente paciente)
        {
            Console.WriteLine("Nombre : " + paciente.Nombre);
            Console.WriteLine("Apellido : " + paciente.Apellido);
            Console.WriteLine("Salario :" + paciente.Salario);
            Console.WriteLine("Tipo De Regimen : " + paciente.TipoDeRegimen);
        }
        public void Eliminar()
        {
            string opcion = "s";
            while (opcion.Equals("s"))
            {
                CrearTitulo("Formulario - Eliminar Liquidacion");
                RealizarEliminacion();
                opcion = ValidarRespuesta("Desea seguir eliminado ?  digite s/n");
            }
        }
        public void RealizarEliminacion()
        {
            string numeroDeLiquidacion = LeerNumerico("Digite el numero de Liquidacion a buscar");
            RespuestaBusquedaLiquidacionCuotaModeradora respuestaBusqueda = servicioLiquidacionCuotaModeradora.Buscar(numeroDeLiquidacion);
            MostrarDatos(respuestaBusqueda.LiquidacionCuotaModeradora);
            Console.WriteLine(servicioLiquidacionCuotaModeradora.Eliminar(numeroDeLiquidacion));
        }
        public void ModificarCuotaDeLiquidacion()
        {
            string numeroDeLiquidacion = LeerNumerico("Digite el numero de Liquidacion a buscar");
            RespuestaBusquedaLiquidacionCuotaModeradora respuestaBusqueda = servicioLiquidacionCuotaModeradora.Buscar(numeroDeLiquidacion);
            if (respuestaBusqueda.LiquidacionCuotaModeradora != null)
            {
                MostrarDatos(respuestaBusqueda.LiquidacionCuotaModeradora);
                LiquidacionCuotaModeradora liquidacionCuotaModeradora = ObtenerliquidacionCuotaModeradoraModificada(respuestaBusqueda.LiquidacionCuotaModeradora);
                Console.WriteLine(servicioLiquidacionCuotaModeradora.Modificar(liquidacionCuotaModeradora));
                CrearPausa();
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
