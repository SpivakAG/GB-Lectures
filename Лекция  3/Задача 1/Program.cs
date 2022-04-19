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
        i ++;
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
int year =  Method3();
Console.WriteLine(year);


//Вид3
string Method4(int count, string text )
{
    int i= 0;
    string result=String.Empty;

    while(i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
//вызов
string res = Method4(10, "asdf");
Console.WriteLine(res);