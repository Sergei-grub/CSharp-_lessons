/*
Напишите программу, которая выводит
случайное число из отрезка [10, 99]
и показывает наибольшую цифру числа.

int Max(int num)
{
int dec = num / 10;
int ones = num % 10;
if (dec > ones)
    return dec;
else
    return ones;
}
int randNumber = new Random().Next(10, 100);
Console.WriteLine($"В числе {randNumber} самая большая цифра {Max(randNumber)}");
*/

/* 
Напишите программу, которая принимает
на вход два числа и проверяет, является
ли одно число квадратом другого.
*/
bool CheckSquare(int num1, int num2)

{
    return (num1 * num1 == num2 || num2 * num2 == num1);
}
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CheckSquare(num1, num2));
