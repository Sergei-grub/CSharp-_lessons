// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Сейчас мы узнаем какое число больше. Введите первое число: ");
int userNum1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int userNum2 = Convert.ToInt32(Console.ReadLine());

if (userNum1 > userNum2) Console.Write("Число " + userNum1 + " больше чем " + userNum2);
else Console.Write("Число " + userNum2 + " больше чем " + userNum1);