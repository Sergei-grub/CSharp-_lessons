/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

bool Palindrome(int userNum)
{
    while(userNum > 999)
    {
        userNum /= 10;
    }
    return userNum % 10;
}
Console.Write("Введите пятизначное число: ");
int userNum = Convert.ToInt32(Console.ReadLine());

if (userNum > 99) Console.WriteLine(NumFive(userNum));
else Console.Write("Число некорректное");