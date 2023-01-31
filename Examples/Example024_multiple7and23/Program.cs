//is number multiplied by 7 and 23?
Console.Clear();
Console.WriteLine("Write a number");
int number = int.Parse(Console.ReadLine()!);

int b = 7;
int c = 23;

int res1 = number % b;
int res2 = number % c;

if (res1 == 0 && res2 == 0)
{
    Console.WriteLine($"Yes, it's multipled by {b} and {c}");
}
else
{
    Console.WriteLine($"{number} is not multiplied by {b} and {c}");
}

