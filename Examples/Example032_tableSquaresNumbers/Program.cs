// Write a program that takes a number (N) as input and
//produces a table of squares of numbers from 1 to N.
//• 5 -> 1, 4, 9, 16, 25.
//• 2 -> 1.4

Console.Clear();
Console.WriteLine("Enter your number: ");
int N = int.Parse(Console.ReadLine()!);
int a = 1;
while (a <= N)
{
    int result = a * a;
    Console.Write($"{Math.Pow(a, 2)} ");
    Console.WriteLine($"The square of {a} is {result}");
    a++;
}