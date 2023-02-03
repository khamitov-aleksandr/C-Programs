// Task #21 Write a program that takes the coordinates of two points as input
// and finds the distance between them in 2D space. ● A(3.6); B(2,1) -> 5.09 ● A(7,-5); B(1,-1) -> 7.21
// AB = √((xb - xa)^2 + (yb - ya)^2).

Console.Clear();

Console.Write("Enter coordinates of point Xa: ");
double Xa = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Enter coordinates of point Ya: ");
double Ya = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Enter coordinates of point Xb: ");
double Xb = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Enter coordinates of point Yb: ");
double Yb = Convert.ToDouble(Console.ReadLine()!);

double x = Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2);

double len = Math.Sqrt(x);

Console.WriteLine($"{len:f2}");
