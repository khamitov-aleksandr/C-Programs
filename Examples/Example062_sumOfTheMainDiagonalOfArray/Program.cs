﻿// Task 51: Define a two-dimensional array. Find the sum of the elements that are on the main diagonal (with indices (0,0); (1;1), etc.
// For example, given an array:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// The sum of the elements of the main diagonal: 1+9+2 = 12

int[,] GetArray(int row, int col, int minValue, int maxValue)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
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
            Console.Write($"{inArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}


int GetSumOfMainDiog(int[,] array2d)
{
    int sum = 0;
    int size = array2d.GetLength(0) > array2d.GetLength(1) ? array2d.GetLength(1) : array2d.GetLength(0);
    for (int i = 0; i < size; i++)
    {
        sum += array2d[i, i];
    }
    return sum;
}

Console.Clear();

int[,] myArray = GetArray(3, 4, 1, 9);
PrintArray(myArray);
int result = GetSumOfMainDiog(myArray);
Console.WriteLine();
Console.WriteLine(result);