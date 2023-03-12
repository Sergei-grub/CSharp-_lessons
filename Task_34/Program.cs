/* 
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 
 */

void ArrayThree(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(99,1000);
        Console.Write($"{arr[i]} ");
        if(arr[i] % 2 == 0) count++; 
    }
        Console.Write($"-> {count++}"); 
} 
Console.Write("Укажите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

//Console.WriteLine();
ArrayThree(array);
