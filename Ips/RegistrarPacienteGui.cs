using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll;
using Entity;
namespace Ips
{
    public partial class RegistrarPacienteGui : Form
    {
        ServicioPaciente servicioPaciente = new ServicioPaciente();
        OperacionesCampos campos = new OperacionesCampos();
        VentanaEmergente ventanaEmergente = new VentanaEmergente();
        public RegistrarPacienteGui()
        {
            InitializeComponent();
        }

        private void RegistrarPacienteGui_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            if (!campos.EsCampoVacio(this))
            {
                string mensaje = servicioPaciente.Guardar(CrearPaciente());
                LbRespuesta.Text = mensaje;
            }
            else
            {
                ventanaEmergente.MensajeErrorCampoVacio();
                LbRespuesta.Text = "Error, Llene todos los campos";
            }
        }
        public Paciente CrearPaciente()
        {
            Paciente paciente = new Paciente();
            paciente.Cedula =TbCedula.Text;
            paciente.Nombre = TbNombre.Text;
            paciente.Apellido = TbApellido.Text;
            paciente.TipoDeRegimen = CbRegimen.Text;
            paciente.Salario = Convert.ToDecimal(TbSalario.Text);
            return paciente;
        }
        private void BtnVaciarCampos_Click(object sender, EventArgs e)
        {
            campos.VaciarCampos(this);
            LbRespuesta.Text = "";
        }

    }
}
