//Write a program to calculate the Ackermann function using recursion.
// Two non-negative numbers m and n are given.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();
int FuncAkk(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return FuncAkk(m - 1, 1);
    else return FuncAkk(m - 1, FuncAkk(m, n - 1));
}
Console.Write("Enter M = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Enter N = ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(FuncAkk(m, n));