using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Entity;

namespace Bll
{
    public class ServicioLiquidacionCuotaModeradora
    {
        RepositorioLiquidacionCoutaModuladora repositorioLiquidacionCoutaModuladora = new RepositorioLiquidacionCoutaModuladora();
        public string Guardar(LiquidacionCuotaModeradora liquidacionCuotaModeradora)
        {
            try
            {
                repositorioLiquidacionCoutaModuladora.Guardar( liquidacionCuotaModeradora);
                return $"Datos de la liquidacion de la cuota modoladora Guardados con exito";
            }
            catch (Exception e)
            {
                return $"Error al guardar los datos:  { e.Message }";
            }
        }
        public List<LiquidacionCuotaModeradora> Consultar()
        {
            try
            {
                List<LiquidacionCuotaModeradora> liquidacionCuotaModeradora = repositorioLiquidacionCoutaModuladora.Consultar();
                return liquidacionCuotaModeradora;
            }
            catch (Exception e)
            {
                Console.WriteLine("error al consultar la lista de Liquidaciones " + e.Message);
                return null;
            }
        }
        public string Eliminar(string numeroDeLiquidacion)
        {
            try
            {
                repositorioLiquidacionCoutaModuladora.Eliminar(numeroDeLiquidacion);
                return $"Paciente eliminado con exito";
            }
            catch (Exception e)
            {
                return $"error  {e.Message}";
            }
        }
        public LiquidacionCuotaModeradora Buscar(string numeroDeLiquidacion)
        {
            try
            {
                LiquidacionCuotaModeradora liquidacionCuotaModeradora = repositorioLiquidacionCoutaModuladora.Buscar(numeroDeLiquidacion);
                return liquidacionCuotaModeradora;
            }
            catch (Exception e)
            {
                Console.WriteLine("error en al buscar paciente" + e.Message);
                return null;
            }
        }
        public string Modificar(LiquidacionCuotaModeradora liquidacionCuotaModeradora)
        {
            try
            {
                repositorioLiquidacionCoutaModuladora.Modificar(liquidacionCuotaModeradora);
                return $"LiquidacionCuotaModeradora Modificado con exito";
            }
            catch (Exception e)
            {
                return $"error {e.Message}";
            }
        }
    }
}
