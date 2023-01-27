// №7. Input three-digit number and output show last the last digit of this number.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Input three-digit number ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(n % 10);