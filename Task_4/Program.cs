// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Давайте узнаем все чётные числа до указанного вами");
Console.Write("Введите число: ");
int userNum = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= userNum)
{
    if (count % 2 == 0) 
        Console.WriteLine(count);
    count++;
}
