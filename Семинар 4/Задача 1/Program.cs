//Напишите программу, которая принимает на вход число и выдает количество цифр в числе

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;

while (number > 0)
{
    number = number / 10;
    sum ++;
}
Console.WriteLine("Количество цифр в числе равно " +sum );