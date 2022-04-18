//Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Write("Введите номер четверти:");
int quater = Convert.ToInt32(Console.ReadLine());

int x = int.MaxValue;
int y = int.MaxValue;

if (quater == 1) 
{
    Console.WriteLine($"X от 0 до {x}");
    Console.WriteLine($"Y от 0 до {y}");
}
if (quater == 2) 
{
    x = int.MaxValue;
    y = int.MinValue;
    Console.WriteLine($"X от 0 до {x}");
    Console.WriteLine($"Y от {y} до 0");
}
if (quater == 3) 
{
    x = int.MinValue;
    y = int.MinValue;
    Console.WriteLine($"X от {x} до 0");
    Console.WriteLine($"Y от {y} до 0");
}
if (quater == 4) 
{
    x = int.MinValue;
    y = int.MaxValue;
    Console.WriteLine($"X от {x} до 0");
    Console.WriteLine($"Y от 0 до {y}");
}