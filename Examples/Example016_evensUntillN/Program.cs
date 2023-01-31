// Input is a number N, output is evems from 1 to N
Console.Clear();
Console.WriteLine("Write a number ");
int N = int.Parse(Console.ReadLine()!);
int k = 2;
while (k <= N)
{
    Console.WriteLine($"{k} ");
    k = k + 2;
}
