/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).*/
Console.WriteLine("Давайте узнаем, является ли число чётным?");
Console.Write("Введите первое число: ");
int userNum = Convert.ToInt32(Console.ReadLine());

if (userNum % 2 == 0) Console.Write("Число " + userNum + " чётное");
else Console.Write("Число " + userNum + " нечётное");