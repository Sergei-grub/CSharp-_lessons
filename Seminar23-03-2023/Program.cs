/* 
Знакомство с языками программирования (семинары)
Урок 9. Рекурсия
 */

// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


/* 
void PrintNumberToN(int N)
{
    if(N == 0)
    {
        return;
    }
    PrintNumberToN(N - 1);
    Console.Write($"{N} ");
}

Console.Write("Введите число: ");
int userNum = Convert.ToInt32(Console.ReadLine());
PrintNumberToN(userNum); 
*/


/* 
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
 */

/* void Numbers(int M, int N)
{
    if(N == M - 1)
    {
        return;
    }
    Numbers(M, N - 1);
    Console.Write($"{N} ");
}

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Numbers(M, N); */

/* 
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
 */

/* int SumRec(int number)
{
    if(number == 0)
    {
        return 0;
    }
    return number % 10 + SumRec(number / 10);
    
}

Console.Write("Введите число N: ");
int userNum = Convert.ToInt32(Console.ReadLine());
Console.Write(SumRec(userNum));
 */

/* 
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
 */

/* 
int NumRate(int userN, int userRate)
{
    if(userRate == 0)
    {
        return 1;
    }
    return userN * NumRate(userN, userRate - 1);
}

Console.Write("Введите число: ");
int userN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int userRate = Convert.ToInt32(Console.ReadLine());
Console.Write(NumRate(userN, userRate)); */



int NumRate(int userN, int userRate)
{
    if(userRate == 0)
    {        
        return 0;
    }
    return userN - NumRate(userN, userRate - 1);
    
}

Console.Write("Введите число: ");
int userN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int userRate = Convert.ToInt32(Console.ReadLine());
Console.Write(NumRate(userN, userRate));