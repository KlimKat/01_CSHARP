// Задача 2: 
// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }

        Console.WriteLine();
    }
}
void ReplaceRows(int[,] matrix, int row1, int row2)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int Array = matrix[row1, i];
        matrix[row1, i] = matrix[row2, i];
        matrix[row2, i] = Array;
    }
}





int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);

Console.WriteLine("Исходный массив:");
PrintMatrix(array2d);

Console.WriteLine();

ReplaceRows(array2d, 0, array2d.GetLength(0) - 1);
Console.WriteLine("Массив после замены:");
PrintMatrix(array2d);