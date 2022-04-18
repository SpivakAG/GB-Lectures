// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
Console.Write("Введите координату X точки A:");
double ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки A:");
double ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X точки B:");
double bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки B:");
double by = Convert.ToDouble(Console.ReadLine());

double pow = Math.Pow(bx-ax, 2)+Math.Pow(by-ay, 2);
double sqrt = Math.Sqrt(pow);

Console.Write(sqrt);