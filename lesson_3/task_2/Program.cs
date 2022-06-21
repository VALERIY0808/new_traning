// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координату Х первой точки");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Х второй точки");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки");
double z2 = Convert.ToDouble(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine(result);