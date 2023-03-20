// Семинар 20-03-2023 г.

/* 
Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
 */

/* 
int[,] FillMatrixWithRandom(int row, int col){
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void ReplaceRows(int[,] array){
    int[] first = new int[array.GetLength(1)];
    for(int i=0; i<first.Length; i++){
        first[i] = array[0,i];
    }

    int[] last = new int[array.GetLength(1)];
    for(int i=0; i<last.Length; i++){
        last[i] = array[array.GetLength(0)-1,i];
    }
  
    for(int i=0; i<first.Length; i++){
        array[0,i] = last[i];
        array[array.GetLength(0)-1,i] = first[i];
    }

    PrintMatrix(array);
}



int row = 0 ;
int col = 0;
while(row <= 0)
{
    Console.Write("Введите кол-во строк: ");
    row = Convert.ToInt32(Console.ReadLine());
}
while(col <= 0){
    Console.Write("Введите кол-во столбцов: ");
    col = Convert.ToInt32(Console.ReadLine());
}
int[,] matrix = FillMatrixWithRandom(row, col);
PrintMatrix(matrix);
 */

// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
/* 
int[,] FillMatrixWithRandom(int row, int column)
{
int[,] array = new int[row, column];
Random rnd = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = rnd.Next(0, 10);
}
}
return array;
}

void PrintMatrix(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i, j]} \t");
}
Console.WriteLine();
}
}

int[,] SwitchRows(int [,] matrix)
{
int temp = 0;

for(int i = 0; i < matrix.GetLength(1); i++)
{
    temp = matrix[0, i];
    matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
    matrix[matrix.GetLength(0) - 1, i] = temp;
}
return matrix;
}

Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
System.Console.WriteLine();
SwitchRows(matrix);
PrintMatrix(matrix);
 */


/* 
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
 */

/* 
 int[,] FillMatrixWithRandom(int row, int col){
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    int temp = 0;
    int result =0;
    int[,] arrNew= new int [array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }

}

int[,] SwitchRows(int[,] matrix)
{
    int temp = 0;
    for(int i = 0; i < matrix.GetLength(1); i++);
    {
        temp = matrix[0,i];
        matrix[0,i] = FillMatrixWithRandom[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = temp;
    }
    return matrix;
}

int row = 0 ;
int col = 0;
while(row <= 0){
    Console.Write("Введите кол-во строк: ");
    row = Convert.ToInt32(Console.ReadLine());
}
while(col <= 0){
    Console.Write("Введите кол-во столбцов: ");
    col = Convert.ToInt32(Console.ReadLine());
}
int[,] matrix = FillMatrixWithRandom(row, col);
PrintMatrix(matrix);
Console.WriteLine();
SwitchRows(matrix);
 */



/* 
Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
1, 2, 3 
4, 6, 1 
2, 1, 6
1 встречается 3 раза 
2 встречается 2 раз 
3 встречается 1 раз 
4 встречается 1 раз 
6 встречается 2 раза

*/


int[,] FindInRndArray(int row, int column)
{
    int count = 0;
    int[,] arr = new int[row, column];
    Random rnd = new Random();
    for (int k = 0; k < 10; k++)
    {

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = rnd.Next(1, 9);
                Console.Write($"{arr[i, j]:0.#}\t");
            }
            Console.WriteLine();
        }
    }

    return arr;
}

Console.Write("Введите число строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] arr = FindInRndArray(row, column);



// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

/*
int[,] FillMatrixWithRandom(int row, int col){
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

int[] FindMin(int[,] array){
    int min = array[0,0];
    int[] minPos = new int[2];
    for (int i = 0; i < array.GetLength(0); i++){
        for (

*/
