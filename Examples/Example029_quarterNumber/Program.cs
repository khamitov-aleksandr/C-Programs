// Write a program that takes as input the coordinates
// of a point (X and Y), with X ≠ 0 and Y ≠ 0,
// and returns the number of the quarter of the plane
// in which this point is located.

Console.Clear();

Console.Write("Enter X: ");
int X = int.Parse(Console.ReadLine()!);

Console.Write("Enter Y: ");
int Y = int.Parse(Console.ReadLine()!);

if (Y > 0)
{
    if (X > 0)
    {
        Console.WriteLine("First quarter");
    }
    else
    {
        Console.WriteLine("Second quarter");
    }
}
else
{
    if (X > 0)
    {
        Console.WriteLine("Fourth quarter");
    }
    else
    {
        Console.WriteLine("Third quarter");
    }
}