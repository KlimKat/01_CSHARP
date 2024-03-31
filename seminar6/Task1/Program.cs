//Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.

// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

string CharsArrayToString(char[] chars)
{
    string strResult = string.Empty;

    for (int i = 0; i < chars.Length; i++)
    {
        strResult += chars[i];
    }

    return strResult;
}

char[] chars = { 'a', 'b', 'c', 'd' };

string strResult = CharsArrayToString(chars);

Console.WriteLine(strResult);

