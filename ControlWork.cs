string[] names = new string[7] { "Олег", "Егор", "Оля", "Яло", "Никита", "Света", "Джо" };
string[] namesChange = new string[names.Length];

int step = 0;

void ChangeArrayIf(string[] names, string[] namesChange)
{
    for (int i = 0; i < names.Length; i++)
    {
        if (names[i].Length <= 3)
        {
            namesChange[step] = names[i];
            step++;
        }
    }
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

ChangeArrayIf(names, namesChange);
Console.Write("Массив из строк, длина которых меньше, либо равна 3: ");
PrintArray(namesChange);