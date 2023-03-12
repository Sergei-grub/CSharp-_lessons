/* 
Задача 38: Задайте массив вещественных чисел(тип double). Найдите разницу между максимальным и минимальным элементов массива.
[3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1
 */

void ArrayThree(double[] arr)
{
    Random rnd = new Random();
    double minNum = 0;
    double maxNum = 0;
    for(int i = 0; i < arr.Length; i++) arr[i] = rnd.NextDouble() * 80;
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i-1] > arr[i]) minNum = arr[i]; 
        if(arr[i-1] < arr[i]) maxNum = arr[i]; 
    }
    Console.Write($"min = {minNum:0.00}, max = {maxNum:0.00}. Разница между максимальным и минимальным элементами массива = {maxNum - minNum:0.00}");
} 

Console.Write("Укажите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];

ArrayThree(array);

/* 
// Решении в соответствии с условиями задачи, т.е. с заданными значениями.

void ArrayThree(double[] arr)
{
    double minNum = 0;
    double maxNum = 0;
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i-1] > arr[i]) minNum = arr[i]; 
        if(arr[i-1] < arr[i]) maxNum = arr[i]; 
    }
    Console.Write($"min = {minNum}, max = {maxNum}. Разница между максимальным и минимальным элементом массива = {maxNum - minNum}");
} 

double[] array = {3.1, 7.2, 22.3, 2.4, 78.5};
ArrayThree(array); */
