// Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.
// 5 12 16 q [STOP]
// 3 45 342 15 [STOP]

void EndlessNumberRequest()
{
    while (true)
    {
        Console.WriteLine("Введите целое число(для выхода введите: q)");
        string symbol = Console.ReadLine();
        if (symbol == "q" || SumIsEven(Convert.ToInt32(symbol)))
        {
            return;
        }
    }
}

bool SumIsEven(int num)
{
    bool variable = false;
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    if (sum % 2 == 0)
    {
        variable = true;
    }
    return variable;
}

EndlessNumberRequest();
