using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Dal
{
    public class RepositorioLiquidacionCoutaModuladora
    {
        private IList<LiquidacionCuotaModeradora> liquidacionesCuotaModeradora = new List<LiquidacionCuotaModeradora>();
        private FileStream flujoDelFichero;
        public string Ruta = @"LiquidacionesCuotaModeradora";
        public void Guardar(LiquidacionCuotaModeradora liquidacionCuotaModeradora)
        {
            flujoDelFichero = new FileStream(Ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(flujoDelFichero);
            escritor.WriteLine(liquidacionCuotaModeradora.ToString());
            escritor.Close();
            flujoDelFichero.Close();
        }
        public IList<LiquidacionCuotaModeradora> Consultar()
        {
            liquidacionesCuotaModeradora.Clear();
            flujoDelFichero = new FileStream(Ruta, FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(flujoDelFichero);
            string linea = string.Empty;
            while ((linea = lector.ReadLine()) != null)
            {
                LiquidacionCuotaModeradora liquidacionCuotaModeradora = MapearLiquidacionCuotaModeradora(linea);
                liquidacionesCuotaModeradora.Add(liquidacionCuotaModeradora);
            }
            lector.Close();
            flujoDelFichero.Close();
            return liquidacionesCuotaModeradora;
        }
        public float TotalizarLiquidacionesPorRegimen(string regimen)
        {
            return liquidacionesCuotaModeradora.Where(l => l.Tipo.Equals(regimen)).Sum(l => l.ValorCuotaModeradora);
        }

        public float TotalizarLiquidaciones()
        {
            return liquidacionesCuotaModeradora.Sum(liquidacion => liquidacion.ValorCuotaModeradora);
        }
        public int ObtenerCantidadLiquidaciones()
        {
            return liquidacionesCuotaModeradora.Count();
        }
        public int ObtenerCantidadLiquidacionesPorRegimen(string regimen)
        {
            IList < LiquidacionCuotaModeradora > liquidacionesFiltrada = ConsultarPorRegimen(regimen);
            return liquidacionesFiltrada.Count();
        }
        public float TotalizarLiquidacionesPorFecha(DateTime fecha)
        {
            IList<LiquidacionCuotaModeradora> liquidacionesFiltrada = ConsultarPorFecha(fecha);
            return liquidacionesFiltrada.Sum(l => l.ValorCuotaModeradora);
        }
        public int ObtenerCantidadLiquidacionesPorFecha(DateTime fecha)
        {
            IList<LiquidacionCuotaModeradora> liquidacionesFiltrada = ConsultarPorFecha(fecha);
            return liquidacionesFiltrada.Count();
        }
        public int ObtenerCantidadLiquidacionesPorRegimenYPorFecha(DateTime fecha, string regimen)
        {
            IList<LiquidacionCuotaModeradora> liquidacionesFiltrada = ConsultarPorFecha(fecha);
            return liquidacionesFiltrada.Where(l => l.Tipo.Equals(regimen)).Count();
        }
        public float TotalizarLiquidacionesPorRegimenYPorFecha(DateTime fecha,string regimen)
        {
            IList<LiquidacionCuotaModeradora> liquidacionesFiltrada = ConsultarPorFecha(fecha);
            return liquidacionesFiltrada.Where(l => l.Tipo.Equals(regimen)).Sum(l => l.ValorCuotaModeradora);
        }
        public IList<LiquidacionCuotaModeradora> ConsultarPorFecha(DateTime fecha)
        {
            return liquidacionesCuotaModeradora.Where(
                l => l.Fecha.Year.Equals(fecha.Year) && l.Fecha.Month.Equals(fecha.Month)).ToList();
        }
        public IList<LiquidacionCuotaModeradora> ConsultarPorApellido(string apellido)
        {
            return liquidacionesCuotaModeradora.Where(l => l.Paciente.Apellido.Equals(apellido)).ToList();
        }
        public IList<LiquidacionCuotaModeradora> ConsultarPorRegimen(string regimen )
        {
           return  liquidacionesCuotaModeradora.Where(l => l.Tipo.Equals(regimen)).ToList();
        }
        public Paciente MapearPaciente(string linea)
        {
            string[] datos = linea.Split(';');
            string nombre = datos[2];
            string apellido = datos[3];
            string tipoDeRegimen = datos[1];
            string cedula = datos[0];
            decimal salario = decimal.Parse(datos[4]);
            Paciente paciente = new Paciente(nombre, apellido, cedula, tipoDeRegimen, salario);
            return paciente;
        }

        public bool EsContributivo(string linea) 
        {
            string[] datos = linea.Split(';');
            if (datos[7].Equals("Contributivo")) return true;
            else return false;
 
        }
        public LiquidacionCuotaModeradora MapearLiquidacionCuotaModeradora(string linea)
        {
            string[] datos = linea.Split(';');
            string numeroDeLiquidacion = datos[5];
            float valorServicio = float.Parse(datos[6]);
            Paciente paciente = MapearPaciente(linea);
            LiquidacionCuotaModeradora liquidacionCuotaModeradora;
            if (EsContributivo(linea))
            {
                liquidacionCuotaModeradora = new Contributivo(numeroDeLiquidacion, valorServicio, paciente);
                
            }
            else
            {
                liquidacionCuotaModeradora = new Sudsidiado(numeroDeLiquidacion, valorServicio, paciente);
            }
            liquidacionCuotaModeradora.Tipo = datos[7];
            liquidacionCuotaModeradora.Tarifa = float.Parse(datos[8]);
            liquidacionCuotaModeradora.SubValorCuotaModeradora = float.Parse(datos[9]);
            liquidacionCuotaModeradora.ValorCuotaModeradora = float.Parse(datos[10]);
            liquidacionCuotaModeradora.TopeMaximo = float.Parse(datos[11]);
            liquidacionCuotaModeradora.Fecha = DateTime.Parse(datos[12]);
            return liquidacionCuotaModeradora;

        }
        public void Eliminar(string numeroDeLiquidacion)
        {
            liquidacionesCuotaModeradora = Consultar();
            flujoDelFichero = new FileStream(Ruta,FileMode.Create);
            flujoDelFichero.Close();

            foreach(LiquidacionCuotaModeradora item in liquidacionesCuotaModeradora)
            {
                if (item.NumeroDeLiquidacion != numeroDeLiquidacion)
                {
                    Guardar(item);
                }
            }
        }
        public void Modificar(LiquidacionCuotaModeradora liquidacionCuotaModeradora)
        {
            liquidacionesCuotaModeradora = Consultar();
            flujoDelFichero = new FileStream(Ruta, FileMode.Create);
            flujoDelFichero.Close();
            foreach (LiquidacionCuotaModeradora item in liquidacionesCuotaModeradora)
            {
                if (!item.NumeroDeLiquidacion.Equals(liquidacionCuotaModeradora.NumeroDeLiquidacion))
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(liquidacionCuotaModeradora);
                }
            }
        }
        public LiquidacionCuotaModeradora Buscar(string numeroDeLiquidacion)
        {
            liquidacionesCuotaModeradora = Consultar();
            return liquidacionesCuotaModeradora.Where(liquidacion => liquidacion.NumeroDeLiquidacion.Equals(numeroDeLiquidacion)).First();
        }
    }
}
