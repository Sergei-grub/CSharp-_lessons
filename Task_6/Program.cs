/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int Num3(int userNum)
{
    while(userNum > 999)
    {
        userNum /= 10;
    }
    return userNum % 10;
}
Console.Write("Введите трехзначное число: ");
int userNum = Convert.ToInt32(Console.ReadLine());

if (userNum > 99) Console.WriteLine(Num3(userNum));
else Console.Write("Число некорректное");