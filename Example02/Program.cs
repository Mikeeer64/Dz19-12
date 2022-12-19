//получает число с консоли.
int GetNamber(string message)
{
    int count = 0;
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out count))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }
    return count;
}

//создаёт и заполняет массив.
int [,] GetArray(int x, int y)
{
    int[,] Array = new int[x, y];
    Random asd = new Random();

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = asd.Next(1, 10);
        }
    }
    return Array;
}

//вывод массива.
void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} "); 
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

//ищет элемент по вводным значениям.
int PrintOtvet(int x, int y, int[,] arr)
{
    int count = -1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(x == i && y == j)
            {
                count = arr[i, j];
                break;
            }
        }
    }
    return count;
}

//выводит ответ.
void Proverka(int index)
{
    if(index == -1)
    {
        Console.WriteLine("Элемента с такими индексами нет.");
    }
    else
    {
        Console.WriteLine($"Ответ: {index}");
    }
}

int x = 10;
int y = 10;
int[,] Array = GetArray(x, y);
PrintArray(Array);

int SK = GetNamber("Введите строку: ");
int SB = GetNamber("Введите столбец: ");

Console.WriteLine();
int otvet = PrintOtvet(SK, SB, Array);
Proverka(otvet);

