Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;

while (number > 1)
{
    number = number / 10;
    sum ++;
}
Console.WriteLine("Количество цифр в числе равно " +sum );