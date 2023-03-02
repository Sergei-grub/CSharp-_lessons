/*
Задача 17: Четверти координат по x y (справа на лево, сверху вниз 1, 2, 3, 4).
6 -> да
7 -> да
1 -> нет

Console.Write("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0) Console.WriteLine("Точка в 1 четверти");
else if (x < 0 && y > 0) Console.WriteLine("Точка в 2 четверти");
else if (x < 0 && y < 0) Console.WriteLine("Точка в 3 четверти");
else if (x > 0 && y < 0) Console.WriteLine("Точка в 4 четверти");
else Console.WriteLine("Точка на плоскости");
*/


/*
Задача №18 Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).



Console.Write("Введите четверть (от  1-4): ");
int chet = Convert.ToInt32(Console.ReadLine());

if (chet < 0 && chet > 4) Console.WriteLine("Значение не корректно"); 
else if (chet == 1) Console.WriteLine("x > 0 && y > 0");
else if (chet == 2) Console.WriteLine("x < 0 && y > 0");
else if (chet == 3) Console.WriteLine("x < 0 && y < 0");
else if (chet == 4) Console.WriteLine("x > 0 && y < 0");
else Console.WriteLine("Значение не корректно");

*/


/*
 22 Напишите программу, которая принимает на вход число (N) и 
 выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
 */


/*

Console.Write("Введи  целое  число N: ");
int nN = Convert.ToInt32(Console.ReadLine());
int doub = 0;

Console.Write($" {nN} (квадраты) ->  ");
for (int i = 1; i <= nN; i++)
{
    doub = i * i;
    Console.Write($" {doub}, ");
}


*/
int count = 0;
Console.Write("Введи  целое  число N: ");
double nN = Convert.ToDouble(Console.ReadLine());
if (nN < 0) Console.WriteLine("Значение не корректно"); 
while (count <= nN)
{
    double N = Math.Pow(count, 2); // возведение в степень
    System.Console.WriteLine(N);
    count++;
}

/*
int nN = Math.Sqrt(number); // извлечение квадратного корня
nN = Math.Round(res, 3); // округление
System.Console.WriteLine(res);
*/