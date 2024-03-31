//Из домашнего задания задача №2
// Задайте строку, содержащую латинские буквы в обоих регистрах.
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.
// Пример:
// “aBcD1ef!-” => “abcd1ef!-”

//нужно доделать (но 2 метода вот эти нужно заюзать)

string str = "aBcD1ef!-";
string result = "";
if(char.IsUpper(str[1]))
{
    result += str[1].ToString().ToLower();
}


string GetLettersFromString(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}