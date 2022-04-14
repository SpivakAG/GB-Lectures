int number = new Random().Next(10, 100);
int first = number / 10;
int second = number % 10;

int max =MaxNumber(first, second);

Console.WriteLine(max);
int MaxNumber (int number1, int number2)
{
    int max = number1;
    if (number2> number1)
    {
        max = number2;
    }
    return max;
}