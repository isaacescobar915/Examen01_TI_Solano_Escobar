using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen01_Ti_Escobar_Solano.Logica_.Salidas
{
    public class ImpresorResultadosESCO
    {
        public void Mostrar(string mensaje)
        {
            MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
