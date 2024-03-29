// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)
// [1 3 5 6 7 8] => [8 7 6 5 3 1]

int[] CreateArrayRndInt(int size, int min, int max)
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

int[] ArrayFlip(int[] array)
{
    int c;
    for (int i = 0; i < (array.Length)/2; i++)
    {
        c = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = c;
    }
    return array;
}

int[] arr = CreateArrayRndInt(10, 1, 100);
PrintArray(arr);

Console.Write(" => ");
PrintArray(ArrayFlip(arr));
