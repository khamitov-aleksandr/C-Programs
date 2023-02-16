// Input: number A,output: sum from 1 to A

int GetSum(int A)
{
    int sum = 0;
    for(int i = 1; i <=A; i++)
    {
        sum += i;
    }
    return sum;
}
Console.Clear();
Console.Write("Write a number: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Sum from 1 to {N} equil to {GetSum(N)}");