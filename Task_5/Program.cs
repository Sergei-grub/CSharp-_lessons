/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трехзначное число: ");
int userNum = Convert.ToInt32(Console.ReadLine());
int num2 = userNum / 10;

if (userNum < 1000 & userNum > 99) 
    {    
       num2 = num2 % 10;
       Console.Write(num2);
    }
else Console.Write("Число не трехзначное!");