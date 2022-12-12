// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длинна которых меньше либо равна 3 символа.Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При ришении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.Clear();

int Prompt(string msg)
{
    System.Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PrintArrey(string[] arrey)
{
    for (int i = 0; i < arrey.Length; i++)
    {
        Console.Write($"{arrey[i]} ");
    }
    Console.WriteLine();
}

string[] CrieteArrey(string[] arrey, double number)
{
    if (number == 1)
    {
        Console.WriteLine("Введите текст через Enter:");
        for (int i = 0; i < arrey.Length; i++)
        {
            arrey[i] = Console.ReadLine();
        }
    }
    if (number == 2)
    {
        string[] arreyNew = new string[5] { "bit", "byte", "int", "unit", "string" };
        for (int i = 0; i < arrey.Length; i++)
        {
            arrey[i] = arreyNew[i];
        }
    }
    if (number != 1)
    {
        if (number != 2)
        {
            Console.WriteLine("Введённое значение не соответсвует ни одному из режимов");
            Environment.Exit(0);
        }
    }
    return arrey;
}

string[] SortingLength(string[] arrey)
{
    string[] arreyNew = new string[5];
    int counter = 0;
    for (int i = 0; i < arrey.Length; i++)
    {
        int text = arrey[i].Length;
        if (text < 4)
        {
            arreyNew[counter] = arrey[i];
            counter++;
        }
    }
    return arreyNew;
}

double value = Prompt("Для выбора режима введите 1(ручной ввод) или 2(автоматический): ");

string[] arrey = new string[5];

CrieteArrey(arrey, value);
Console.WriteLine();
Console.WriteLine("Массив строк:");
PrintArrey(arrey);
Console.WriteLine("Сумма символов, меньше либо равными 3");
PrintArrey(SortingLength(arrey));