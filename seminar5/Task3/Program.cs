// Задайте двумерный массив из целых чисел. 
// Сформируйте новый одномерный массив, состоящий из средних
// арифметических значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1         => [3 3 5]
// 2 9 5 4

int[,] CreateaMatrixRndInt(int rows, int columns, int min, int max)
{//                          0      1
    int[,] matrix = new int[rows, columns]; // 3 x 4
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) //rows = 3
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //columns = 4
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
        //Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        // Console.WriteLine("   |");
        Console.WriteLine();
    }
}
double[] AverageElementsRows(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(0)]; //куда будем сохранять матрицу, состоящую из элементов sum

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        double average = (double)sum / matrix.GetLength(1); //(double) sum это мы поменяли тип на double (на строчке 41 у нас int sum)
        array[i] = average; //вот сюда положили рез-т
    }
    return array;
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{Math.Round(array[i]),2} ");
        }
        else
        {
            Console.Write($"{Math.Round(array[i]),2}");
        }
    }
    Console.Write("]");
}


int[,] array2d = CreateaMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);

double[] resultArray = AverageElementsRows(array2d);
PrintArray(resultArray);
