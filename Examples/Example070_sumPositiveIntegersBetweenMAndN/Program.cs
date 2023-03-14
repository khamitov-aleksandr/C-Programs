// Task 66: Set M and N values.
// Write a program that will find the sum of natural elements between M and N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
int NumberRec(int M, int N)
{
    if (M == N) return M;
    return NumberRec(M, N - 1) + N;
}
Console.Write("Enter M = ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Enter N = ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(NumberRec(M, N));