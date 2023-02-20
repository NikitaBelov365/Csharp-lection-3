// цикл в цикле

for (int i = 1; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} * {j} = {i*j}");
    }
    System.Console.WriteLine(); //вывод пустой строки
}