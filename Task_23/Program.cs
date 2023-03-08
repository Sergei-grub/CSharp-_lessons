/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 
*/
void FindCube (int userNum)
{
  for (int i = 1; i <= userNum; i++)
  {
    int result = i * i * i;
    string comma = ",";
    if (i == userNum) Console.Write($"{result} ");
    else Console.Write($"{result}{comma} ");
  }
}
Console.Write("Введите число для возведения в 3 степень: ");
int userNum = Convert.ToInt32(Console.ReadLine());
FindCube (userNum);