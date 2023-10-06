using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_de_matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int SumarEsquinas(int[,] matriz)
            {
                int suma = 0;

                if (matriz.Length == 0)
                {
                    return suma;
                }

                suma += matriz[0, 0];
                suma += matriz[0, matriz.GetLength(1) - 1]; 
                suma += matriz[matriz.GetLength(0) - 1, 0]; 
                suma += matriz[matriz.GetLength(0) - 1, matriz.GetLength(1) - 1]; 

                return suma;
            }

           
            int[,] matrizEjemplo = new int[,]
            {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
            };

            Console.WriteLine(SumarEsquinas(matrizEjemplo)); 

        }
    }
}
