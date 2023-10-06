using System;

public int SumarEsquinas(int[,] matriz)
{
    int suma = 0;

    if (matriz.Length == 0)
    {
        return suma;
    }

    suma += matriz[0, 0]; // esquina superior izquierda
    suma += matriz[0, matriz.GetLength(1) - 1]; // esquina superior derecha
    suma += matriz[matriz.GetLength(0) - 1, 0]; // esquina inferior izquierda
    suma += matriz[matriz.GetLength(0) - 1, matriz.GetLength(1) - 1]; // esquina inferior derecha

    return suma;
}

// Ejemplo de uso
int[,] matrizEjemplo = new int[,]
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

Console.WriteLine(SumarEsquinas(matrizEjemplo)); // Output: 1 + 3 + 7 + 9 = 20
