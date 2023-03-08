/* Задача 29: 
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] 
*/

void FillArray(int[] collection)
{
      int length = collection.Length;
      int index = 0;
      while(index < length)
      {
        collection[index] = new Random().Next(0,33);
        index++;
      }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        string comma = ",";
        if (i == array.Length - 1) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]}{comma} ");
        
    }
    Console.WriteLine("]");
}

Console.Write("Введите количество элементов массива: ");
int userArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[userArray]; //Создаем новый массив из количества заданных пользователем элементов.

FillArray(array);
PrintArray(array);