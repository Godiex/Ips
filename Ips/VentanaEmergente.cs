using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Ips
{
    public class VentanaEmergente
    {
        public void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void MensajeErrorCampoVacio()
        {
            string mensaje = "Error : Llene todos los campos";
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void MensajeErrorCampoVacio(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public DialogResult ValidarRespuesta(string mensaje)
        {
            string titulo = "Avertencia !!!";
            var resultado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return resultado;
        }
        public DialogResult ValidarModificacion()
        {
            string mensaje = "Esta seguro que desea modificar la liquidacion?";
            string titulo = "Avertencia !!!";
            var resultado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return resultado;
        }
        public DialogResult ValidarElimiar()
        {
            string mensaje = "Esta seguro que desea eliminar la liquidacion?";
            string titulo = "Avertencia !!!";
            var resultado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return resultado;
        }
    }
}
