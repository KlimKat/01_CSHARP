// Задача 3: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.


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
int FindRowWithMinSum(int[,] matrix)
{
    int minRow = 0;
    int minSum = 0;

    // Получаем сумму элементов первой строки
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        minSum += matrix[0, j];
    }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minRow = i;
        }
    }
    return minRow;
}



int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);

Console.WriteLine();


int MinRow = FindRowWithMinSum(array2d); // Сохраняем результат в переменную MinRow
Console.WriteLine($"Строка с наименьшей суммой элементов:{MinRow}");