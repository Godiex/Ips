using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ips
{
    class MenuIpsMasSaludYVida : AplicacionDeConsola
    {
        public MenuIpsMasSaludYVida()
        {
            EjecutarMenuIpsMasSaludYVida();
        }
        public override int PedirOpcion()
        {
            CrearTitulo("Menu Principal - Clinica Ips Mas Salud Y Vida");
            int opcion;
            Console.WriteLine("1- Para Gestion De Pacientes Clicica Mas Salud Y Vida ");
            Console.WriteLine("2- Para Gestion De Liquidaciones De Cuotas Moduladoras");
            Console.WriteLine("0- Para Salir");
            Console.WriteLine("");
            opcion = int.Parse(LeerNumerico("Digite La Opcion Deseada :"));
            return opcion;
        }
        public void EjecutarMenuIpsMasSaludYVida()
        {
            int opcion;
            do
            {
                opcion = PedirOpcion();
                switch (opcion)
                {
                    case 1:new MenuPaciente(); break;
                    case 2:new MenuLiquidacionCuotaModuladora(); break;
                }

            } while (opcion != 0);
        }
    }
}
