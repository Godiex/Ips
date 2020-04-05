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
        public List<LiquidacionCuotaModeradora> liquidacionesCuotaModeradora = new List<LiquidacionCuotaModeradora>();
        private FileStream flujoDelFichero;
        public string Ruta= @"LiquidacionesCuotaModeradora";
        public void Guardar(LiquidacionCuotaModeradora liquidacionCuotaModeradora)
        {
            flujoDelFichero = new FileStream(Ruta,FileMode.Append);
            StreamWriter escritor = new StreamWriter(flujoDelFichero);
            escritor.WriteLine(liquidacionCuotaModeradora.ToString());
            escritor.Close();
            flujoDelFichero.Close();
        }
        public List<LiquidacionCuotaModeradora> Consultar()
        {
            liquidacionesCuotaModeradora.Clear();
            flujoDelFichero = new FileStream(Ruta,FileMode.Open);
            StreamReader lector = new StreamReader(flujoDelFichero);
            string linea = string.Empty;
            while ((linea = lector.ReadLine()) != null)
            {
                if (EsContributivo(linea))
                {
                    LiquidacionCuotaModeradora Contributivo = MapearLiquidacionCuotaModeradoraContributiva(linea);
                    liquidacionesCuotaModeradora.Add(Contributivo);
                }
                LiquidacionCuotaModeradora Sudsidiado = MapearLiquidacionCuotaModeradoraSudsidiada(linea);
                liquidacionesCuotaModeradora.Add(Sudsidiado);
            }
            lector.Close();
            flujoDelFichero.Close();
            return liquidacionesCuotaModeradora;
        }
        public Paciente MapearPaciente(string linea)
        {
            string[] datos = linea.Split(';');
            string nombre = datos[0];
            string apellido = datos[1];
            string tipoDeRegimen = datos[2];
            string cedula = datos[3];
            decimal salario = decimal.Parse(datos[4]);
            Paciente paciente = new Paciente(nombre, apellido, cedula, tipoDeRegimen, salario);
            return paciente;
        }
        public LiquidacionCuotaModeradora MapearLiquidacionCuotaModeradoraContributiva(string linea)
        {
            string[] datos = linea.Split(';');
            string numeroDeLiquidacion = datos[5];
            float valorServicio = float.Parse(datos[6]);
            Paciente paciente = MapearPaciente(linea);
            LiquidacionCuotaModeradora contributivo = new Contributivo(numeroDeLiquidacion,valorServicio,paciente);
            contributivo.Tipo = datos[7];
            contributivo.Tarifa= float.Parse(datos[8]);
            contributivo.SubValorCuotaModeradora = float.Parse(datos[9]);
            contributivo.ValorCuotaModeradora = float.Parse(datos[10]);
            contributivo.TopeMaximo = float.Parse(datos[11]);
            return contributivo;
        }
        public bool EsContributivo(string linea) 
        {
            string[] datos = linea.Split(';');
            if (datos[7].Equals("Contributivo")) return true;
            else return false;
 
        }
        public LiquidacionCuotaModeradora MapearLiquidacionCuotaModeradoraSudsidiada(string linea)
        {
            string[] datos = linea.Split(';');
            string numeroDeLiquidacion = datos[5];
            float valorServicio = float.Parse(datos[6]);
            Paciente paciente = MapearPaciente(linea);
            LiquidacionCuotaModeradora sudsidiado = new Sudsidiado(numeroDeLiquidacion, valorServicio, paciente);
            sudsidiado.Tipo = datos[7];
            sudsidiado.Tarifa = float.Parse(datos[8]);
            sudsidiado.ValorCuotaModeradora = float.Parse(datos[9]);
            sudsidiado.TopeMaximo = float.Parse(datos[10]);
            return sudsidiado;
        }
        public void Eliminar(string numeroDeLiquidacion)
        {
            liquidacionesCuotaModeradora = Consultar();
            flujoDelFichero = new FileStream(Ruta,FileMode.Create);
            flujoDelFichero.Close();
            foreach(LiquidacionCuotaModeradora item in liquidacionesCuotaModeradora)
            {
                if (!item.NumeroDeLiquidacion.Equals(numeroDeLiquidacion))
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
            foreach (LiquidacionCuotaModeradora item in liquidacionesCuotaModeradora)
            {
                if (item.NumeroDeLiquidacion.Equals(numeroDeLiquidacion))
                {
                    return item;
                }
            }
            return null;
        }
    }
}
