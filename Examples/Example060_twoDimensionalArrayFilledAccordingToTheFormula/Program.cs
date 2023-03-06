// Set up a two-dimensional array of size m by n,
// each element in the array is found by the formula: Aij = i+j.
// Display the resulting array on the screen.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


Console.Clear();
int[,] GetArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
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

Console.Write("Enter row of array: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Enter column of array: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, col);
PrintArray(array);
