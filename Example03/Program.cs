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

//вывод двумерного массива.
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
}

//находит среднее арифмитическое.
double [] GetQtvet(int[,] arr)
{
    double [] x = new double [arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            x[j] += Convert.ToDouble(arr[i, j]);
        }
    }
    for (int i = 0; i < x.Length; i++)
    {
        x[i] /= arr.GetLength(0);
    }
    return x;
}

//вывод одномерного массива.
void PrintArray2(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Среднее арифмитическое элементов {i} столбца: {arr[i]:F1}");
    }
    Console.WriteLine();
}

int x = GetNamber("Введите количество строк: ");
int y = GetNamber("Введите количество столбцов: ");
int[,] Array = GetArray(x, y);
PrintArray(Array);
Console.WriteLine();

double [] wroyt = GetQtvet(Array);
PrintArray2(wroyt);

