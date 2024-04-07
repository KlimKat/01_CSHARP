// Задача 1: 
// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

// Пример
// a b c => “abcdef” d e f


string CharsArrayToString(char[] chars)
{
    string strResult = string.Empty;

    for (int i = 0; i < chars.Length; i++)
    {
        strResult += chars[i];
    }

    return strResult;
}

char[] chars = { 'a', 'b', 'c', 'd', 'e', 'f' };

string strResult = CharsArrayToString(chars);

Console.WriteLine(strResult);


