Console.Write("Введите число:");
double number = Convert.ToDouble(Console.ReadLine());
double index = 1;

while (index <= number)
{
    double result = Math.Pow(index, 2);
    index +=1;
    Console.Write($"{result} ");
}