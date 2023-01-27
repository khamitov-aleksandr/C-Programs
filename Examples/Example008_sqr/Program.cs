// Input multiple in squere
Console.Clear();
Console.Write("Enter a number ");
int number = int.Parse(Console.ReadLine()!);

int sqr = number * number;
double sqr2 = Math.Pow(number, 2);

Console.WriteLine($"sqr of {number} equil {sqr}");
Console.WriteLine($"sqr of {number} equil {sqr2}");