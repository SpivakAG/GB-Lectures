Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = 1;

// Вариант решения через while

/*int index = 1;
while (index <= number)
{
    factorial = factorial*index;
    index ++;
} */

// Вариант решения через for

for (int i = 1; i <= number; i++)
{
    factorial = factorial*i;
}


Console.WriteLine("Факториал числа " +number +" равен " +factorial);