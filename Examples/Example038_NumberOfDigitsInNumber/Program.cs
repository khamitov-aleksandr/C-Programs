// task: how many digits in number, input: number, output: digits
Console.Clear();
int DigitCount(int A)
{
    int count = 0;
    while (A != 0)
    {
        A/= 10;
        count++;
    }
    return count;
}

Console.Write("Write a number: ");
int N = int.Parse(Console.WriteLine()!);

Console.WriteLine(DigitCount(N));
