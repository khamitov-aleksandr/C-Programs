// one number is the square of the another?
Console.Clear();
Console.WriteLine("Write a firs number");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write a second number");
int b = int.Parse(Console.ReadLine()!);

if (a * a == b || b * b == a)
{
 Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}