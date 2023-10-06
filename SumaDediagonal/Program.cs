using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaDediagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            public int SumarDiagonales(int[,] matriz)
            {
                int suma = 0;

                if (matriz.Length == 0 || matriz.GetLength(0) != matriz.GetLength(1))
                {
                    return suma;
                }

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    suma += matriz[i, i]; ¿
                    suma += matriz[i, matriz.GetLength(0) - 1 - i]; ¿
                }

                return suma;
            }

            
            int[,] matrizEjemplo = new int[,]
            {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
            };

            Console.WriteLine(SumarDiagonales(matrizEjemplo));
        }
    }
}
