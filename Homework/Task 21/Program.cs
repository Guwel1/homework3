Console.Clear();

Console.WriteLine("Введите координаты точки А в 3D пространстве: ");
double xa = Convert.ToDouble(Console.ReadLine());
double ya = Convert.ToDouble(Console.ReadLine());
double za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B в 3D пространстве: ");
double xb = Convert.ToDouble(Console.ReadLine());
double yb = Convert.ToDouble(Console.ReadLine());
double zb = Convert.ToDouble(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(xa-xb,2)+Math.Pow(ya-yb,2)+Math.Pow(za-zb,2));
Console.WriteLine($"Расстояние между точками: {result}");










// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.