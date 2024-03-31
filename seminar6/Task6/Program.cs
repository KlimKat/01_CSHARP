//Из домашнего задания задача №4 (необязательная)
// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.
// Пример:
// “Hello my world” => “world my Hello”

string hello = "Hello my world";
string res = string.Empty;
string[] helloSplit = hello.Split();//["Hello", "my", "world"]

//нужно в функцию обернуть это решение
for (int i = helloSplit.Length - 1; i >= 0; i--)
{
    res += helloSplit[i] + " ";
}

Console.WriteLine(res.TrimEnd()); //TrimeEnd убирает пробел в конце строки