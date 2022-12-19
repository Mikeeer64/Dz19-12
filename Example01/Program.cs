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
double [,] GetArray(int x, int y)
{
    double [,] Array = new double[x, y];
    Random asd = new Random();

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = (double)asd.Next(-100, 100) / 10;
        }
    }
    return Array;
}

//вывод массива.
void PrintArray(double[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]}  "); 
        }
        Console.WriteLine();
    }
}

int x = GetNamber("Введите кол строк: ");
int y = GetNamber("Введите кол столбцов: ");
double [,] Array = GetArray(x, y);
PrintArray(Array);
