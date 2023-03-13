// Семинар 13-03-2023

// Рекомендуемая литература: «Математические основы машинного обучения и прогнозирования», В. В. Вьюгин



// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
/* 
int[] FillArrayWhithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(-9, 10);
}
return arr;
}

void ReverseArray(int[] arr)
{
int temp = 0;

for(int i = 0; i < arr.Length/2; i++)
{
    temp = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = temp;
}
}

System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
ReverseArray(array);
System.Console.WriteLine($"[{string.Join(", ", array)}]");



Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.



// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

System.Console.Write("Введите первую сторону треугольника: ");
int AB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите вторую сторону треугольника: ");
int BC = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третью сторону треугольника: ");
int AC = Convert.ToInt32(Console.ReadLine());

if(AB + BC > AC && AB + AC > BC && BC + AC > AB)
{
System.Console.Write("Треугольник существует");
}
else
{
System.Console.Write("Треугольник не существует");
}



Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10



// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void PrintBinary(int number)
{
if(number <= 0)
{
return;
}

PrintBinary(number/2);
Console.Write(number%2);
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintBinary(number);



// Второй вариант
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int end = 0;
while (num1 > 0)
{
end = num1 % 2;
num1 /= 2;
Console.Write(end);
}



//Третий вариант
int SizeofDif(int num)
{
int count = 0;

while (num > 0)
{
    num /= 2;
    count++;
}

return count;
}

int[] Dif(int num)
{
int[] arr = new int[SizeofDif(num)];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = num % 2;
    num /= 2;
}

return arr;
}

int[] Reverse(int[] someArr)
{

for (int i = 0; i < someArr.Length/2; i++)
{
    int temp = someArr[i];
    someArr[i] = someArr[someArr.Length - 1 - i];
    someArr[someArr.Length - 1 - i] = temp;
}

return someArr;
}

int[] result = Dif(2);
Console.WriteLine($"Your array: [{string.Join(", ", result)}]");
int[] newArr = Reverse(result);
Console.WriteLine($"Reverse array: [{string.Join(", ", newArr)}]");
 */



/* 
Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
 */

/*  
int[] FillArrayWhithRandomNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}

void ReverseArray(int[] arr)
{
    int temp = 0;

    for(int i = 0; i < arr.Length/2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
ReverseArray(array);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
 */


/* 
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
 */

/* bool Trial(int a, int b, int c)
{
    return a + b > c && b +c > a && a + c > b;
}

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

Trial(num1, num2, num3);

Console.WriteLine($"Результат: {Trial(num1, num2, num3)}"); */


/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10 
*/


/* Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int end = 0;
while (num1 > 0)
{
    end = num1 % 2;
    num1 /= 2;
    Console.Write(end);
} */

/* 
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/
/* 
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int frt = 0, second = 1, third = 2;

Console.Write($"{frt} {second}");
for (int i = 2; i < num1; i++)
    {
            third = frt + second;
            Console.Write($" {third}");
            frt = second;
            second = third;
    } 
*/
/* 
Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
 */

int [] FillArrayWithRandomNumbers(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i=0; i<arr.Length;i++){
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}

int[] CoppyArray(int[] array, int size)
{
    int[] arr2 = new int [size];
    for(int i = 0; i < array.Length; i++)
    {
        arr2[i] = array[i]; 
    }
    return arr2;

}

Console.Write("Input array size "); 
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumbers(size);
Console.Write("Array one:  ");
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine();
Console.Write("Array copy: ");
Console.WriteLine($"[{string.Join(", ", CoppyArray(array, size))}]");


/* 
for(int i = 0; i < array.Length; i++)
{
    array[i] *= 1;
}
Console.Write("New array: ");
Console.WriteLine($"[{string.Join(", ", array)}]");
 */