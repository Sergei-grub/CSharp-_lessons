/* 
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
 */

/* 
string NumRecurse(int userNum)
{
    if (userNum > 1) return $"{userNum}, " + NumRecurse(userNum - 1);
    else return "1";
}

Console.Write("Введите число: ");
int userNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumRecurse(userNum)); 
 */

/* 
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
 */
/* 
int SumRecurse(int userNumM, int userNumN)
{
    if (userNumM == userNumN) return userNumN;
    else return userNumM + SumRecurse(userNumM + 1, userNumN);
}

Console.Write("Введите начальное число: ");
int userNumM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число: ");
int userNumN = Convert.ToInt32(Console.ReadLine());
SumRecurse(userNumM, userNumN);
Console.Write($"Сумма натуральных элементов в промежутке от {userNumM} до {userNumN} -> {SumRecurse(userNumM, userNumN)}");;
 */


/* 
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
 */