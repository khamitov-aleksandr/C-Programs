// Without using recursion, print the first N Fibonacci numbers.
// The first two Fibonacci numbers are 0 and 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
Console.Clear();
int[] arrayFib(int N)
{
    int[] array = new int[N];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

Console.Write("Enter your Number: ");
int nFib = int.Parse(Console.ReadLine()!);
Console.WriteLine(String.Join(", ", arrayFib(nFib)));
