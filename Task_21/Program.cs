/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 
*/
double FindLengh (double x1, double x2, double y1, double y2, double z1, double z2)
{
  double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
  return result; 
}

Console.WriteLine("Данные первой точки:");
Console.Write("введите координату по оси X первой точки: ");
double x1=Convert.ToInt32(Console.ReadLine());

Console.Write("введите координату по оси Y первой точки: ");
double y1=Convert.ToInt32(Console.ReadLine());

Console.Write("введите координату по оси Z первой точки: ");
double z1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Данные второй точки:");
Console.Write("введите координату по оси X второй точки: ");
double x2=Convert.ToInt32(Console.ReadLine());

Console.Write("введите координату по оси Y второй точки: ");
double y2=Convert.ToInt32(Console.ReadLine());

Console.Write("введите координату по оси Z первой точки: ");
double z2=Convert.ToInt32(Console.ReadLine());

double FindLengh2d=FindLengh(x1, x2, y1, y2, z1, z2);
double end = FindLengh2d;
System.Console.Write($"расстояние между точками = ");
System.Console.WriteLine ("{0:0.##}", end);