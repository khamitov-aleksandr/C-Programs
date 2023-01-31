// Write a program that displays the third digit of a given number,
// or reports that there is no third digit.
Console.Clear();
Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine()!);
int n = 10;
while (num > 999)
{
    num = num / n;
}
int res = num % n;
if (num < 99)
{
    Console.WriteLine($"This number doesn't have a third digit"!);
}
else
{
    Console.WriteLine($"Third digit is {res}");
}






