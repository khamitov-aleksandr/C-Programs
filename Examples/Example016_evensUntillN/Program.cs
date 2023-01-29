// Input is a number N, output is evems from 1 to N
Console.Clear();
Console.WriteLine("Write a number ");
int N = int.Parse(Console.ReadLine()!);
int k = 1;
while (k <= N)
{
    if (k%2 == 0)
    {
        Console.WriteLine($"{k} ");
    }
    k++;
}
