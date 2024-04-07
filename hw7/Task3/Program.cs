// Задача 3: 
// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
// Пример:
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

int[] matrix = { 1, 2, 5, 0, 10, 34 };
PrintMatrixReversed(matrix, matrix.Length - 1);


void PrintMatrixReversed(int[] matrix, int idx)
{
    if (idx >= 0)
    {
        Console.Write(matrix[idx] + " "); 
        PrintMatrixReversed(matrix, idx - 1); 
    }
}
