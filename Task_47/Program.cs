/* 
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
 */

double[,] PrArray(int row, int column)
{
    double min = -10;
    double max = 10;
    double[,] arr = new double [row, column];
    Random rnd = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rnd.NextDouble() * (max - min) + min;
            Console.Write($"{arr[i,j]:0.#}\t");
        }
        Console.WriteLine();    
    }
    return arr;
}

Console.Write("Введите количество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());
double[,] array = PrArray(row, column);