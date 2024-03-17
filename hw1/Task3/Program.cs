// Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным.

// 4 => да
// -3 => нет
// 7 => нет

Console.WriteLine("Введите число:");
double num;
while (!double.TryParse(Console.ReadLine(), out num))
{
    Console.WriteLine("Неверный формат. Если хотите ввести дробное число, вводите через запятую:");
}
// Тут выделяем целочисленную часть, чтобы по ней определить четность
int integerPart = (int)num;

if (integerPart % 2 == 0)
{
    Console.WriteLine($"Число {num} четное.");
}
else
{
    Console.WriteLine($"Число {num} нечетное.");
}
