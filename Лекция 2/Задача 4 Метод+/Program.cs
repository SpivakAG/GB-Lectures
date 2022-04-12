//Метод заполнения массива случайными числами от 1 до 10
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index ++;
    }
}

//Метод вывода на печать массива
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

//Определяем массив из 10 элементов
int[] array = new int[10];

FillArray(array);
PrintArray(array);