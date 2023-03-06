Console.Clear();

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void GetSqrArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i += 2)
    {
        for (int j = 0; j < array2D.GetLength(1); j += 2)
        {
            array2D[i, j] *= array2D[i, j];
        }
    }
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.Write("Enter number of rows of array: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Enter number of colums of array: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array2D = GetArray(row, col, -10, 10);
PrintArray(array2D);
Console.WriteLine();
GetSqrArray(array2D);
PrintArray(array2D);
