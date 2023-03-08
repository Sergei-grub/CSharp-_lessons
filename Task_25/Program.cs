/* 
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 
*/
void FindRate (int userNum, int userRate)
{
    int rate = 1;
    for (int i = 0; i < userRate; i++)
    {
        rate = rate * userNum;    
    }
  Console.WriteLine($"Результат возведения в степень: {rate}");
}
Console.Write("Введите число для возведения в степень: ");
int userNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень для заданного числа: ");
int userRate = Convert.ToInt32(Console.ReadLine());

FindRate (userNum, userRate);

