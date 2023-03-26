/* 
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
 */


int[,] FindInRndArray(int row, int column)
{
    int[,] arr = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(1, 10);
            Console.Write($"{arr[i, j]:0.#}\t");
        }
        Console.WriteLine();
    }
    return arr;
}

void ArraySort(int[,] arr)
{
    int temp = 0;
    int count = 1;
    //int[] arrResult = new int[arr.GetLength(1)];
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            if (arr[i, j] > arr[i, count])
            {
                temp = arr[i, count];
                arr[i, count] = arr[i, j];
                arr[i, j] = temp;
                if (count < 4) count++;
            }
            else 
            {
                temp = arr[i, j];
                arr[i, j] = arr[i, count];
                arr[i, j] = temp;
                if (count < 4) count++;
            }
            Console.Write($"{arr[i, j]}\t");
        }

        Console.WriteLine();
    } 

}

Console.Write("Введите число строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] arr = FindInRndArray(row, column);
Console.WriteLine();
ArraySort(arr);