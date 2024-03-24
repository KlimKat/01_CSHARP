// Задайте массив из N случайных целых чисел 
// (N вводится с клавиатуры).
// Найдите количество чисел, 
// которые оканчиваются на 1 и делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3] => 2

int[] CreateArrayRndInt(int size, int  min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

int CountResultEndNumdivisorNum(int[] array, int LastNum, int Mult)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 10 == LastNum && array[i] % Mult == 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Задайте размер массива");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(n, 1, 100); 
PrintArray(arr);

int result = CountResultEndNumdivisorNum(arr, 1, 7);
Console.WriteLine();
Console.WriteLine(result);

//тут просто экспромт 
int resuLt = CountResultEndNumdivisorNum(arr, 7, 9);
Console.WriteLine();
Console.WriteLine(resuLt);