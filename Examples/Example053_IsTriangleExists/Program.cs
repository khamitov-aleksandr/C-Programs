// Write a program that takes three numbers as input and checks
// if a triangle with sides of that length can exist.
Console.Clear();

Console.Clear();

bool CheckTriangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

Console.Write("Enter number a: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Enter number b: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Enter number c: ");
int c = int.Parse(Console.ReadLine()!);

if (CheckTriangle(a, b, c))
{
    Console.WriteLine("Triangle with this sides can exist");
}
else
{
    Console.WriteLine("Triangle with this sides can't exist");
}
