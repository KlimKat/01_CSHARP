// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное этих чисел.

// 2, 31, 7 => 7
// 44, 5, 78 => 78
// 22, 3, 9 => 22

Console.WriteLine("Введите первое число:");
double num1;
while (!double.TryParse(Console.ReadLine(), out num1))
{
    Console.WriteLine("Неверный формат. Если хотите ввести дробное число, вводите через запятую:");
}

Console.WriteLine("Неверный формат. Если хотите ввести дробное число, вводите через запятую:");
double num2;
while (!double.TryParse(Console.ReadLine(), out num2))
{
    Console.WriteLine("Неверный формат. Если хотите ввести дробное число, вводите через запятую:");
}

Console.WriteLine("Введите третье число:");
double num3;
while (!double.TryParse(Console.ReadLine(), out num3))
{
    Console.WriteLine("Неверный формат. Если хотите ввести дробное число, вводите через запятую:");
}

double max = Math.Max(Math.Max(num1, num2), num3);
Console.WriteLine($"Максимальное число: {max}");
