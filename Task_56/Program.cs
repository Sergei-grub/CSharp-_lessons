/* 
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 */

int[,] FillArray(int row, int col)
{
    int[,] arr = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 10);
        }
    }
    return arr;
}
void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void FindSum(int[,] arr)
{
    int[] sumRow = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumRow[i] += arr[i, j];
        }
    }
    Console.WriteLine($"Суммы чисел в строках для проверки: {string.Join(", ", sumRow)}");
    int minIdx = 0;
    for (int i = 0; i < sumRow.Length ; i++)
    {
        if (sumRow[minIdx] > sumRow[i])
        {
            minIdx = i + 1;
        }
    }
    Console.WriteLine($"Cтрока с наименьшей суммой элементов: {minIdx}");
}

Console.Write("Введите число строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] arr = FillArray(row, column);
PrintMatrix(arr);
Console.WriteLine();
FindSum(arr);