﻿//Set an array of 12 elements filled with random numbers from the interval [-9, 9].
//Find the sum of negative and positive array elements.

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

int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(", ", array));

int positiveSum = 0;
int negativeSum = 0;

foreach (int element in array)
{
    positiveSum += element > 0 ? element : 0;
    // if (el > 0)
    // {
    // positiveSum += el;
    // }
    negativeSum += element < 0 ? element : 0;
}

Console.WriteLine($"The sum of positive numbers is {positiveSum}, and negative is {negativeSum}");