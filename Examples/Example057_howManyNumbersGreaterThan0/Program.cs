// The user enters M numbers from the keyboard.
// Count how many numbers greater than 0 the user entered.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 3
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

int GetPozitive(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result++;
        }
    }
    return result;
}

Console.WriteLine("Enter how many random numbers do you need: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = GetArray(size, -99, 99);

Console.WriteLine(String.Join(", ", array));
Console.WriteLine("Numbers greater then zero: ");
Console.WriteLine(String.Join(", ", GetPozitive(array)));
