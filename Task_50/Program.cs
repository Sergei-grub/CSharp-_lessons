/* 
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
 */

void FindInRndArray(int userNum)
{
    bool result = false;
    int count = 0;
    int[,] arr = new int [3,4];
    Random rnd = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rnd.Next(1, 10);
            if(userNum == arr[i,j]) 
            {
                result = true;
                count++;
            }
            Console.Write($"{arr[i,j]:0.#}\t");            
        }
        Console.WriteLine();           
    }
    if(result == true && count > 1 && count < 5 && count > 1)  //проверка для окончания слова "раз" исходя из количтества повторов
    {
        Console.WriteLine($"В массиве есть заданное значение — {userNum} и оно встречается {count} раза.");
    }
    else if (result == true && count > 4) //проверка для окончания слова "раза" исходя из количтества повторов
    {
        Console.WriteLine($"В массиве есть заданное значение — {userNum} и оно встречается {count} раз.");
    }
    else Console.Write($"{userNum} -> такого числа нет в массиве."); 
}

Console.Write("Введите искомое в массиве число: ");
int userNum = Convert.ToInt32(Console.ReadLine());
FindInRndArray(userNum);
