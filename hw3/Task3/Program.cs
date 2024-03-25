// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементом массива.
// Пример
// [2.2 0.4 9.11 7.2 78.98] => 78.58
// [1.22 4.5 3.33] => 3.28

//Считвет, но даже если вводишь число с нулевой дробной частью, а хочется, чтобы просто выдавал ошибку и не считал, и не выдавал значение
double[] arr = new double[10] { 50.8, 30.9, 80.3, 4.9, 54.5, 2.6, 7.4, 8.2, 10.6, 2.1 };
double max = arr[0];
double min = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] != (int)arr[i])
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    else
    {
        Console.WriteLine($"Массив имеет вещественное число с нулевой дробной частью");
    }
}
double diff = max - min;
Console.WriteLine($"{diff}");


//не считает разницу между минимальным и максимальным значением, если среди чисел массива 
//нет чисел с нулевой дробной частью, но выдает сообщение, 
//если в массив попадает число с нулевой дробной частью - не хочу исправлять не знаю уже как
// double[] arr = new double[10] { 50.8, 30.9, 80.3, 4.9, 54.5, 2.6, 7.4, 8.2, 10.6, 2.1 };
// double max = arr[0];
// double min = arr[0];

// bool HasNoZeroFractionalPart = false;
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] != (int)arr[i])
//     {
//         HasNoZeroFractionalPart = true;
//         if (arr[i] > max)
//         {
//             max = arr[i];
//         }
//         if (arr[i] < min)
//         {
//             min = arr[i];
//         }
//     }
// }

// if (HasNoZeroFractionalPart)
// {
//     Console.WriteLine($"Массив имеет вещественное число с нулевой дробной частью");
// }
// else
// {
//     double diff = max - min;
//     Console.WriteLine($"{diff}");
// }