// Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

// a=5; b=7 => max=7, min=5
// a-2; b-10 -> max-10, min-2 
// a--9; b--3 -> max=-3, min=-9

// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите первое число:");
// double num1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите второе число:");
// double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите первое число:");
double num1;
while (!double.TryParse(Console.ReadLine(), out num1))
{
    Console.WriteLine("Неверный формат. Если хотите ввести дробное число, вводите через запятую:");
}

Console.WriteLine("Введите второе число:");
double num2;
while (!double.TryParse(Console.ReadLine(), out num2))
{
    Console.WriteLine("Неверный формат. Если хотите ввести дробное число, вводите через запятую:");
}

if (num1 == num2)
{
    Console.WriteLine("Числа равны");
}
else
{
    if (num1 > num2)
    {
        Console.WriteLine("Первое число больше второго");
    }
    else
    {
        Console.WriteLine("Второе число больше первого");
    }
}
