/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int SumAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

Console.Write("Введите число: ");
int userNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма всех цифр в чиселе {userNum} = {SumAllDigit(userNum)}");