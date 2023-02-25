// Specify an array of real numbers.
// Find the difference between the maximum and minimum elements of the array.
// [3 7 22 2 78] -> 76
Console.Clear();

double[] GetArray(int size, double MinValue, double MaxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble() * (MaxValue - MinValue) + MinValue;
    }
    return result;
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
double[] array = GetArray(5, 1, 100);
Console.WriteLine(string.Join(", ", array));
double MaxMin = FindMax(array) - FindMin(array);
Console.WriteLine($"{MaxMin}");