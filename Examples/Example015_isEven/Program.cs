// is the number even
Console.WriteLine("Write a number");
int number = int.Parse(Console.ReadLine()!);

if  (number %2 == 0)
{
    Console.WriteLine($"the number {number} is even, yes");
}
else
{
    Console.WriteLine($"the number {number} is odd, no");
}
