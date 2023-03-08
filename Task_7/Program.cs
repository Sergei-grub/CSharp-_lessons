/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите день недели (от 1 до 7): ");
int numD = Convert.ToInt32(Console.ReadLine());
if (numD < 8 && numD == 6 || numD == 7) Console.WriteLine($"{numD} — это выходной!");
else if (numD < 6 && numD > 0) Console.WriteLine($"{numD} — это рабочий день (");
else Console.WriteLine("Введено не корректное число");