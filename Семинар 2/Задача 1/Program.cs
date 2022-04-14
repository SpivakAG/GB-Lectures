int number = new Random().Next(10, 100);
int first = number / 10;
int second = number % 10;

if (first>second)
{
    Console.WriteLine(first);
}
else
{
    Console.Writeline(second);
}