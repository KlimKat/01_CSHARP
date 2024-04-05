// Задача 1: 
// Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента 
// или же указание, что такого элемента нет.



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
void RequestMatrixValue(int[,] matrix, int row, int column)
{
    if (row >= 0 && row < matrix.GetLength(0) && column >= 0 && column < matrix.GetLength(1))
    {
        int value = matrix[row, column];
        Console.WriteLine($"Значение элемента в позиции [{row}, {column}]: {value}");
    }
    else
    {
        Console.WriteLine($"Элемента в позиции [{row}, {column}] не существует");
    }
}




int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);

Console.WriteLine();

// Выберем случайный элемент для запроса
Random rnd = new Random();
int row = rnd.Next(array2d.GetLength(0));
int column = rnd.Next(array2d.GetLength(1));

RequestMatrixValue(array2d, row, column);
