/* 
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

void AverageArray(int[,] arr)
{
    double result = 0;
    double[] arrResult = new double[arr.GetLength(1)];
    for (int j = 0; j < arrResult.Length; j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            result += arr[i, j];
        }
        arrResult[j] = result / arr.GetLength(0);
        result = 0;
    }
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < arrResult.Length; i++)
    {
        Console.Write($"{arrResult[i]:0.#}");
        if (i < arrResult.Length - 1) Console.Write($";\t");
        else Console.Write($".");
    }
}

Console.Write("Введите число строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] arr = FindInRndArray(row, column);
AverageArray(arr);