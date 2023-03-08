/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

void FindRate (int userNum)
{
    userNum = 452;
    for (int i = 10; i < 100; i = i + 10)
    {
        int tempNub2 = userNum / i;
        Console.WriteLine(tempNub2);
    }
    //int tempNub = tempNub1 + tempNub2;
    //Console.WriteLine($"Результат возведения в степень: {tempNub}");
}
Console.Write("Введите число для возведения в степень: ");
int userNum = Convert.ToInt32(Console.ReadLine());

FindRate (userNum);