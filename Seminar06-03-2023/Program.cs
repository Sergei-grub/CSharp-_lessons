// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
/*
int Sum(int A)
{
    int sum = 0;
    for(int i = 1; i <= A; i++)
    {
        sum+=i;// sum = sum + i
    }
    return sum;
}

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = Sum(number);
Console.WriteLine($"Сумма от 1 до {number} = {sum}");
*/

/*
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
/*
int NumDel(int number)
{
    int index = number;
    int count = 0;
    while (index != 0)
    {
        index /= 10; 
        count++;
    }
    return count;
}
System.Console.WriteLine("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество символов = {NumDel(Num)}");
*/

/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/

/*
int Mult(int A)
{
    int mult = 1;
    for(int i = 1; i <= A; i++)
    {
        mult *= i;
    }
    return mult;
}
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Произведение от 1 до {number} = {Mult(number)}");
*/
/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

//int[] arr = {10, 2, 3, 4, 9, 1, 3, 7, 8, 6};

void FillArray(int[] collection)
{
      int length = collection.Length;
      int index = 0;
      while(index < length)
      {
        collection[index] = new Random().Next(0,2);
        index++;
      }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] array = new int[8]; //Создай новый массив из 8 эл-тов

FillArray(array);  
PrintArray(array);

   
