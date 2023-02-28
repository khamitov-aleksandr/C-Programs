// Write a program that will find the point of intersection
// of two lines given by the equations
// y = k1 * x + b1, y = k2 * x + b2;
// the values b1, k1, b2 and k2 are set by the user.
// =================================
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0.5; -0.5)
// =================================
// y = k1 * x + b1, y = k2 * x + b2
// k1 * x + b1 = k2 * x + b2
// (k1 - k2) * x = b2 - b1
// x = (b2 - b1) / (k1 - k2)
// y = k1 * x + b1
Console.Clear();
double ResaltX(double b1, double k1, double b2, double k2)
{
    double x1 = b2 - b1;
    double x2 = k1 -k2;
    double x = x1 / x2;
    return x;
}

double ResaltY(int k1, int b1, double x)
{
    double y = (k1 * x) + b1;
    return y;
}

Console.Write("Enter b1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter k1: ");
int k1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter b2: ");
int b2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter k2: ");
int k2 = int.Parse(Console.ReadLine()!);

double x = ResaltX(b1, k1, b2, k2);
double y = ResaltY(k1, b1, x);

Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y}) ");

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)