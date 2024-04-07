//Задача 1
// Задайте значения M и N. 
// Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

//Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

//1) обязательно проверить на натуральность числа
//2) сделать, чтобы оба варианта работали - и задом наперед тоже, т.е и при М меньшем N, и N меньшем M

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());


if (m <= 0 || n <= 0)
{
    Console.WriteLine("Ошибка ввода: введено минимум одно ненатуральное число");
}
else
{
    Console.Write($"Натуральные числа от {m} до {n}: ");
    PrintNaturalNumbersBtwMN(m, n);
}


void PrintNaturalNumbersBtwMN(int m, int n)
{
    if (m == n)
    {
        Console.Write($"{m} ");
    }
    else if (m < n)
    {
        Console.Write($"{m} ");
        PrintNaturalNumbersBtwMN(m + 1, n);
    }
    else
    {
        Console.Write($"{m} ");
        PrintNaturalNumbersBtwMN(m - 1, n);
    }
}