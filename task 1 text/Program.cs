string text = "Кракозябры стояли стоя стремглав кустами"
            + "Совсем крабы кость стукнули куском"; 
// многострочный ввод

// string s = "qwerty"
//             0123456
// чтобы получить конкретный символ надо
// s[3] - выведет e

string Replace (string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length; // вывод длины текста
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}"; //новый вывод if
        else result = result + $"{text[i]}"; // и else
    }
    return result;
}

string newText = Replace(text, ' ', '-');
System.Console.WriteLine(newText);
newText = Replace(newText, 'с', 'С');
System.Console.WriteLine(newText);
newText = Replace(newText, 'к', 'К');
System.Console.WriteLine(newText);