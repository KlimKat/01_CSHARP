// Задача 2: 
// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// Пример:
// “aBcD1ef!-” => “abcd1ef!-”

string ConvertToLowerCase(string str)
{
    string letters = "";
    foreach (char e in str)
    {
        if (char.IsAsciiLetter(e)) // Проверяем, является ли символ буквой
        {
            if (char.IsUpper(e)) // Проверяем, является ли буква заглавной
            {
                letters += char.ToLower(e); // Заменяем заглавную букву на строчную и добавляем к результату
            }
            else
            {
                letters += e; // Если буква уже строчная, добавляем ее без изменений к результату
            }
        }
        else
        {
            letters += e; // Если символ не является буквой, добавляем его без изменений к результату
        }
    }
    return letters;

}

string str = "aBcD1ef!-";
string letters = ConvertToLowerCase(str);
Console.Write(letters); // Выводим результат