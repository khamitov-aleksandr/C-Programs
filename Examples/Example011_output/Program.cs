// Write a nimber N and in output you will see all numbers between this number untill -N
Console.WriteLine("Write a number ");
int N = int.Parse(Console.ReadLine()!);
int k = -N;
while (k <= N)
{
    Console.WriteLine($"{k} ");
    k++;
}
