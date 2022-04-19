﻿//Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы “к” заменить большими “К”, а большие “С” заменить маленькими “с”.

string text = "- Я думаю, - сказал князь, улыбаясь, -что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwerty"
//            012345
//s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty; //инициализация пустой строки

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}"; 
    }

    return result;
}
string newText = Replace(text, ' ', '-'); //при работе с char используются ' ' 
newText = Replace(newText, 'к', 'К');
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
