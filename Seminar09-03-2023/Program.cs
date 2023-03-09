﻿// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

/* int[] FillArrayWithRandomNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}

Console.Write("Введите длтну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = FillArrayWithRandomNumber(size);

int sumPositive = 0;
int sumNegative = 0;

for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        sumPositive += array[i];
    }
    else
    {
        sumNegative += array[i];
    }
}

Console.Write("Ваш случайный массив: ");
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Сумма положительных элементов равна {sumPositive}, а сумма отрицательных элементов равна {sumNegative}"); */



/* Задача 32:  
Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
(развернуть пол. или отр. значение числа: *(-1)) */
/* 
int[] FillArrayWithRandomNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9, 10);
        Console.Write($"{arr[i]} ");
    }
    return arr;
}

void chenge(int[] arr2)
{
    for(int i = 0; i < arr2.Length; i++)
    {
        arr2[i] = arr2[i] * (-1);
        Console.Write($"{arr2[i]} ");
    }    
}
Console.Write("Введите длтну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(size);
Console.WriteLine();
chenge(array);

 */


/* Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да */

/* int[] arrayNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 345);
        Console.Write($"{arr[i]} ");
    }
    return arr;
}

Console.Write("Введите длтну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = arrayNumber(size);

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

string result = "No";
for(int i=0; i<array.Length; i++){
    if(array[i] == num){
        result = "yes";
        break;
    }
}
Console.WriteLine(result); */


/* Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */

/* int[] arrayNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 123);
        Console.Write($"{arr[i]} ");
    }
    return arr;
}
Console.WriteLine("Массив: ");
int size = 5;
int[] array = arrayNumber(size);

int count = 0;
for(int i=0; i<array.Length; i++){
    if(array[i] >= 10 & array[i] <= 99) count++;
}
Console.WriteLine($"-> {count}"); */


/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

int[] arrayNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 10);
        Console.Write($"{arr[i]} ");
    }
    return arr;
}

Console.Write("Введите длтну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = arrayNumber(size);
int newLenght = array.Length / 2 + array.Length % 2;
int[] arrayEnd = new int[newLenght];

for(int i = 0; i < array.Length / 2; i++)
{
    arrayEnd[i] = array[i] * array[array.Length - 1 - i];
}

if(array.Length % 2 > 0)
{
    arrayEnd[arrayEnd.Length - 1] = array[array.Length / 2];
}

Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"[{string.Join(", ", arrayEnd)}]");