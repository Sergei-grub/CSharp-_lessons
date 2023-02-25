// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Сейчас мы узнаем какое из трех чисел больше.");
Console.Write("Введите первое число: ");
int userNum1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int userNum2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int userNum3 = Convert.ToInt32(Console.ReadLine());
int max = userNum1;

if (userNum2 > max) max = userNum2;
if (userNum3 > max) max = userNum3;

Console.Write("Максимальное из этих чисел " + max);