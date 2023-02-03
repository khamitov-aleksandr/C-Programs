// Write a program that takes the coordinates of two points as input and
// finds the distance between them in 3D space.
// A(3,6,8); B(2,1,-7), -> 15.84
// A(7,-5, 0); B(1,-1,9) -> 11.53

Console.Clear();

Console.Write("Enter coordinates of point Xa: ");
double Xa = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Enter coordinates of point Ya: ");
double Ya = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Enter coordinates of point Za: ");
double Za = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Enter coordinates of point Xb: ");
double Xb = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Enter coordinates of point Yb: ");
double Yb = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Enter coordinates of point Zb: ");
double Zb = Convert.ToDouble(Console.ReadLine()!);

double x = Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2) + Math.Pow(Zb - Za, 2);

double len = Math.Sqrt(x);

Console.WriteLine($"{len:f2}");