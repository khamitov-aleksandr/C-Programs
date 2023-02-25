// Specify an array filled with random positive three-digit numbers.
// Write a program to show the number of even numbers in an array.
//[345, 897, 568, 234] -> 2
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
int EvenNumberArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++ )
    {
        if (array[i] % 2 == 0) result++;
    }
    return result;
}

int[] array = GetArray(5, 100, 1000);
Console.WriteLine(String.Join(",", array));

int result = EvenNumberArray(array);
Console.WriteLine($" -> {result}");
