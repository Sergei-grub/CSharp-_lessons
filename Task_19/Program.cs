/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

/* int Palindrome(int userNum)
{
    int num = 0;
    
    while(userNum > 999)
    {
        num = userNum %= 100;
        
    }
    return num;    
}
Console.Write("Введите пятизначное число: ");
int userNum = Convert.ToInt32(Console.ReadLine()); */


/* if (userNum > 9999) 
{
    int numMod = Palindrome(userNum);
    Console.Write(numMod);
}
else Console.Write("Число некорректное."); */

bool Palindrome()
{
    int[] array = {1, 2, 18, 18, 2, 1};
    int count = 0; 
    for (int i = 0; i < array.Length; i++)
    {
        int fromEnd = (array.Length - 1) - i;
        if (array[i] == array[fromEnd]) count++; 
    }
    /* if (count == array.Length) Console.WriteLine($"Число является палиндромом");
    else Console.WriteLine($"Число не палиндромом. Совпало: {count} цифры из {array.Length}"); */
    return (count == array.Length);
}


//int[] array = {1, 2, 18, 18, 2, 7};

Console.WriteLine($"Число является палиндромом?");
bool Anwer = Palindrome();
Console.WriteLine(Anwer);