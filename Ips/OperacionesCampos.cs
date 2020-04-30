using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ips
{
    public class OperacionesCampos
    {
        public void VaciarCampos(Control control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).Text = "";
                }
            }
        }
        public bool EsCampoVacio(Control control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    if (((TextBox)txt).Text.Length.Equals(0))
                    {
                        return true;
                    }
                }
                else if (txt is ComboBox)
                {
                    if (((ComboBox)txt).Text.Length.Equals(0))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
