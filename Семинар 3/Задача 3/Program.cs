// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
double ax = Coordinate("x", "A");
double ay = Coordinate("y", "A");
double bx = Coordinate("x", "B");
double by = Coordinate("y", "B");

double pow1 = Math.Pow(bx-ax, 2);
double pow2 = Math.Pow(by-ay, 2);
double sqrt = Math.Sqrt(pow1+pow2);

Console.Write(sqrt);

double Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}:");
    return Convert.ToDouble(Console.ReadLine());
}
