int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int Result(int input)
{
    int first = input / 100;
    int third = input % 10;
    int result = first *10 + third;
    return result;
}

int result = Result (number);
Console.WriteLine(result);