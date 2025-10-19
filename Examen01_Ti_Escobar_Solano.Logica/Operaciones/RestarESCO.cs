using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen01_Ti_Escobar_Solano.Logica_.Interfaces;


namespace Examen01_Ti_Escobar_Solano.Logica_.Operaciones
{
    public class RestarESCO : IRestarESCO
    {
        public string Ejecutar(string numA, string numB)
        {
            numA = numA.PadLeft(Math.Max(numA.Length, numB.Length), '0');
            numB = numB.PadLeft(Math.Max(numA.Length, numB.Length), '0');

            int prestamo = 0;
            string resultado = "";

            for (int i = numA.Length - 1; i >= 0; i--)
            {
                int a = (numA[i] - '0') - prestamo;
                int b = (numB[i] - '0');

                if (a < b)
                {
                    a += 10;
                    prestamo = 1;
                }
                else
                {
                    prestamo = 0;
                }

                resultado = (a - b) + resultado;
            }

            return resultado.TrimStart('0');
        }
    }
}
