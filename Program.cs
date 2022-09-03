// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введи x1");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введи y1");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введи z1");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введи x2");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введи y2");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введи z2");
double z2 = Convert.ToDouble(Console.ReadLine());

double D = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2));

Console.WriteLine(D);
