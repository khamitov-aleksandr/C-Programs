﻿// Specify a one-dimensional array filled with random numbers.
// Find the sum of elements in odd positions.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int[] array = GetArray(5, 100, 1000);
Console.Write(String.Join(", ", array));

int OddArray(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        result += array[i];
    }
    return result;
}

int result = OddArray(array);
Console.Write($" -> {result}");