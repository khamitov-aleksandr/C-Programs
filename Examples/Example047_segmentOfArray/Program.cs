// Task 35: Set up a one-dimensional array of 123 random numbers.
// Find the number of array elements whose values lie in the segment [10,99].
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

int CountElements(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item > 9 && item < 100)
        {
            count++;
        }
    }
    return count;
}

int[] array = GetArray(123, -9, 150);
Console.WriteLine(string.Join(",", array));
int end = CountElements(array);
Console.Write($"The number of array elements satisfying the condition is {end} ");