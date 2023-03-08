/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

bool ArrayIn()
{
    int[] array1 = new int [5];
    Console.WriteLine($"Введите число из 5 цифр по очереди:");
    int count = 1;
    int countForPaly = 0;
    for (int i = 0; i < array1.Length; i++)
        {
            Console.Write($"Введите {count}-ю цифру: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            if (userNum > 0 & userNum < 10) 
            {
                array1[i] = userNum;    
                count++;
            }
            else 
            {
                Console.Write($"Вы ввели неправильное значение!");
                break;
            }
        }
    for (int i = 0; i < array1.Length; i++)
    {
        int fromEnd = (array1.Length - 1) - i;
        Console.Write($"{array1[i]}");
        if (array1[i] == array1[fromEnd]) countForPaly++; 
    }
    return (countForPaly == array1.Length);
}

bool end1 = ArrayIn();
if (end1 == true) Console.WriteLine($" — Число является палиндромом");
else Console.WriteLine($" — Число не палиндромом.");