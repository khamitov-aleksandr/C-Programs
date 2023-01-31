// Is the second number a multiple of the first?
Console.WriteLine("Write first number");
int firstnumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write second number");
int secondnumber = int.Parse(Console.ReadLine()!);
int c = firstnumber % secondnumber;

if (c == 0)
{
    Console.WriteLine("Yes, multiplied");
}
else
{
    Console.WriteLine($"No, rest is {c}");
}
