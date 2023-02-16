// Write a program that takes an array of 8 elements and prints them to the screen.
Console.Clear();
int Prompt(string message)
{
    Console.Write(message);
    string ReadInput = (Console.ReadLine()!);
    int result = int.Parse(ReadInput);
    return result;
}

int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}

int length = Prompt("Array length: ");
int min = Prompt("Initial value for random number range: ");
int max = Prompt("End value for a range of random number: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);