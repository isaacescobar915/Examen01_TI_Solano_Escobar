using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen01_Ti_Escobar_Solano.Logica_.Interfaces;

namespace Examen01_Ti_Escobar_Solano.Logica_.Operaciones
{
    public class SumarESCO : ISumarESCO
    {
        public string Ejecutar(string numA, string numB)
        {
            numA = numA.PadLeft(Math.Max(numA.Length, numB.Length), '0');
            numB = numB.PadLeft(Math.Max(numA.Length, numB.Length), '0');

            int carry = 0;
            string resultado = "";

            for (int i = numA.Length - 1; i >= 0; i--)
            {
                int suma = (numA[i] - '0') + (numB[i] - '0') + carry;
                carry = suma / 10;
                resultado = (suma % 10) + resultado;
            }

            if (carry > 0)
                resultado = carry + resultado;

            return resultado.TrimStart('0');
        }
    }
}
