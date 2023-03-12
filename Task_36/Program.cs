/*  
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
 */

void ArrayThree(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100,100);
        Console.Write($"{arr[i]} ");
        if(arr[i] % 2 != 0) count += arr[i]; 
    }
        Console.Write($"-> {count}"); 
} 
Console.Write("Укажите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

ArrayThree(array);