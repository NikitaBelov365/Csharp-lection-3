// методы, которые ничего не принимают и не возвращают

void Method1() // пустой метод который при его вызове выводит надпись
{
    System.Console.WriteLine("Author Nikita");
}
Method1(); // вызов метода

// методы которые принимают, но не возвращают

void Method2(string msg) // пустой метод который принимает какой то мессадж)
{
    System.Console.WriteLine(msg);
}
Method2(msg: "Some text");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Text", count: 4) // сколько раз выведется это сообщение
// тут явно передаём в метод аргументы, в таком формате можно не по порядку

// методы которые не принимают, но возвращают

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
System.Console.WriteLine(year);

// методы которые принимают и возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = ""; // передали пустую строку
    // а ещё можно String.Empty
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "text");
System.Console.WriteLine(res);