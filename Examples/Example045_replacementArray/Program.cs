// Task 32: Write a program for replacing array elements: replace positive elements
// with the corresponding negative ones, and vice versa.
Console.Clear();

int[] GetArray(int size, int MinValue, int MaxValue)
{
    int[] Result = new int[size];

    for (int i = 0; i < size; i++)
    {
        Result[i] = new Random().Next(MinValue, MaxValue + 1);
    }
    return Result;
}

void SigChange(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}

int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(", ", array));
SigChange(array);
Console.WriteLine(String.Join(", ", array));
