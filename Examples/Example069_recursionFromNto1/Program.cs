// Task 64: Set the value to N.
// Write a program that prints all natural numbers between N and 1.
// Execute with recursion.
// // N = 5 -> "5, 4, 3, 2, 1"
// // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Clear();
string NumberFor(int N)
{
    if (N == 1) return $"{N}";
    return $"{N} ," + NumberFor(N - 1);
}
Console.Write("Write N = ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(NumberFor(N));