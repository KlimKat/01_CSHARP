// Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.)
// Пример

// 2 3 4 3
// 4 3 4 1         => 2 + 3 + 5 = 10
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
int SumElemMainDiagonal(int[,] matrix)
{
    // int sum = matrix[0, 0]; //будет работать только если матрица не пустая - по хорошему нужно проверку делать

    // for (int i = 1; i < matrix.GetLength(0); i++)
    // {
    //     for (int j = 1; j < matrix.GetLength(1); j++)
    //     {
    //         if (i == j)
    //         {
    //             sum += matrix[i, j];
    //         }
    //     }
    //    Console.WriteLine();
    // }
    // return sum;
    //ниже оптимальный вариант (вариант выше рабочий тоже)
    int sum = 0;
    int size = matrix.GetLength(0);
    if (matrix.GetLength(0) > matrix.GetLength(1))
    {
        size = matrix.GetLength(1);
    }
    for (int i = 0; i < size; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}



int[,] array2d = CreateaMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);

int result = SumElemMainDiagonal(array2d);
Console.WriteLine($"Cумма элементов на главной диагонали = {result}");

