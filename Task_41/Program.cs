/* 
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
 */

void Recsive(int userNum) 
{
    int count = 0;
    int[] arr = new int [userNum];
    for(int i = 0; i < userNum; i++)
    {
        Console.Write($"Укажите число {i + 1}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        if(arr[i] > 0) count++; 
    }        
    Console.Write($"{string.Join(", ", arr)} -> {count}");
}

Console.Write("Укажите количество чисел для анализа: ");
int userNum = Convert.ToInt32(Console.ReadLine());
Recsive(userNum);