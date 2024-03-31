// Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, 
// и замените эти элементы
// на их квадраты.
// Пример

// индексы столбцов      0   1   2   3 
// слева индексы строк
// 0                     2   3   4   3
// 1                     4   3   4   1
// 2                     2   9   5   4


// 4   3   16  3
// 4   3   4   1
// 4   9   25  4

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
            Console.Write($"{matrix[i, j], 5}"); //5 в конце для красивого разделения по кол-ву элементов
        }
       // Console.WriteLine("   |");
       Console.WriteLine();
    }
}
void ReplaceElemEvenIdxToSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2) //i+=2 это чтобы не каждый элемент перебирать, а только четные
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)//j+=2 это чтобы не каждый элемент перебирать, а только четные
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}
int[,] array2d = CreateaMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);

Console.WriteLine();

ReplaceElemEvenIdxToSquare(array2d);
PrintMatrix(array2d);

