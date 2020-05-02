using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entity;

namespace Dal
{
    public class PacienteRepositorio
    {
        private IList<Paciente> pacientes;
        private FileStream flujoDelFichero;
        public string Ruta = @"Pacientes.txt";
        public PacienteRepositorio()
        {
            pacientes = new List<Paciente>();
        }
        public void Guardar(Paciente paciente)
        {
            flujoDelFichero = new FileStream(Ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(flujoDelFichero);
            escritor.WriteLine(paciente.ToString());
            escritor.Close();
            flujoDelFichero.Close();
        }
        public IList<Paciente> Consultar()
        {
            pacientes.Clear();
            flujoDelFichero = new FileStream(Ruta,FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(flujoDelFichero);
            string linea = string.Empty;
            while ((linea = lector.ReadLine()) != null)
            {
                Paciente paciente= MapearPaciente(linea);
                pacientes.Add(paciente);
            }
            lector.Close();
            flujoDelFichero.Close();
            return pacientes;
        }
        public Paciente MapearPaciente(string linea)
        {
            string[] datos = linea.Split(';');
            string nombre = datos[2];
            string apellido = datos[3];
            string tipoDeRegimen = datos[1];
            string cedula = datos[0];
            decimal salario =decimal.Parse(datos[4]);
            Paciente paciente = new Paciente(nombre,apellido,cedula,tipoDeRegimen,salario);
            return paciente;
        }
        public void Eliminar(string cedula)
        {
            pacientes = Consultar();
            flujoDelFichero = new FileStream(Ruta, FileMode.Create);
            flujoDelFichero.Close();
            foreach (Paciente paciente in pacientes)
            {
                if (!paciente.Cedula.Equals(cedula))
                {
                    Guardar(paciente);
                }
            }
        }
        public void Modificar(Paciente paciente)
        {
            pacientes = Consultar();
            flujoDelFichero = new FileStream(Ruta, FileMode.Create);
            flujoDelFichero.Close();
            foreach (Paciente item in pacientes)
            {
                if (paciente.Cedula !=  item.Cedula)
                {
                    Guardar(item);
                }
                else 
                {
                    Guardar(paciente);
                }
            }
        }
        public Paciente Buscar(string cedula)
        {
            pacientes = Consultar();
            return pacientes.Where(paciente => paciente.Cedula.Equals(cedula)).First();
        }
    }
}
