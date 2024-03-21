// Задача 4: 
// Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.
// Пример
// 568  => 5,6,8
// 8    => 8
// 9542 => 9,5,4,2

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int memory_number = number;
int k = 1;
int division = 1;
int result = 0;

while (memory_number > 9) // Находим кол-во символов в числе
{
    memory_number /= 10;
    k++;
    division *= 10;
}
int k1 = k;

while (k > 0) // Переворачиваем число
{
    result += (number % 10) * division;
    number /= 10;
    division /= 10;
    k--;
}

while (k1 > 0) // Находим цифры
{
    Console.Write(result % 10 + ", ");
    result /= 10;
    k1--;
}