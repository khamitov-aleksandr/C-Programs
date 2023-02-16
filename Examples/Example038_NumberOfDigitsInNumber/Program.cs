// task: how many digits in number, input: number, output: digits
Console.Clear();
int DigitCount(int A)
{
    int count = 0;
    if (A == 0)
    {
        count = 1;
    }
    else
    {
        while (A != 0)
        {
            A /= 10;
            count++;
        }
    }
    return count;
}

Console.Write("Write a number: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Number of digits of number {N} equals to {DigitCount(N)}");