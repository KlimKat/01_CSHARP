﻿// Задача 2: 
// Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// Пример:
// m = 2, n = 3 -> A(m,n) = 29

// псевдокод перевести в C#
// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))



//Задача 1
// Задайте значения M и N. 
// Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

//Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

//1) обязательно проверить на натуральность числа
//2) сделать, чтобы оба варианта работали - и задом наперед тоже, т.е и при М меньшем N, и N меньшем M



//скидывать ссылку на весь репозиторий, в комментариях прописать, какие папки смотреть
