// Task 33: Define an array. Write a program that determines if a given number is present in an array.
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

bool FindElement(int number, int[] collection)
{
    foreach (int el in collection)
    {
        if (el == number)
        {
            return true;
        }
    }
    return false;
}
int[] array = GetArray(12, -9, 9);
Console.WriteLine(string.Join(",", array));
Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine()!);
if (FindElement(n, array))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}