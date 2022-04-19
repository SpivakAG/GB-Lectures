// Вид 1
void Method1()
{
    Console.WriteLine("Автор ...");
}
//Вызов:
Method1();




//Вид2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Вызов
Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Вызов
Method21(msg: "Текст", count: 4); //если аргументы именованые, можно писать не по порядку, например Method21(сount: 4, msg: "Текст");


//Вид3
int Method3()
{
    return DateTime.Now.Year;
}
//вызов
int year = Method3();
Console.WriteLine(year);


//Вид4
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
//вызов
string res = Method4(10, "asdf");
Console.WriteLine(res);



//Цикл for
string Method5(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
//вызов
string resul = Method5(10, "asdf");
Console.WriteLine(resul);

//задача вывода таблицы умножения на экран
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();
}