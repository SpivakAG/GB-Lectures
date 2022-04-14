int number = new Random().Next(100, 1000);

Console.WriteLine(number);

int Third (int number1)
{
    int first = number % 10;
    return first;
}

int First (int number1)
{
    int first = number / 100;
    return first;
}

int Sum (int n1, int n2)
{
    int dozens= n1*10;
    int result = dozens + n2;
    return result;
}

int first = First (number);
int third = Third (number);

int result = Sum(first, third);
Console.WriteLine(result);