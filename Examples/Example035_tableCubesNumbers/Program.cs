// Write a program that takes a number (N) as input and
// produces a table of cubes of numbers from 1 to N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Enter your number: ");
int N = int.Parse(Console.ReadLine()!);
int a = 1;
while (a <= N)
{
    int result = a * a * a;
    Console.Write($"{Math.Pow(a, 3)} ");
    Console.WriteLine($"The square of {a} is {result}");
    a++;
}