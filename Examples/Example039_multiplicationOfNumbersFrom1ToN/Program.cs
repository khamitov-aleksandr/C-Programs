// Write a program that takes a number N as input and outputs the product of numbers from 1 to N.

Console.Clear();

int Multi(int number)
{
    int prod = 1;

    for (int i = 2; i <= number; i++)
    {
        prod *= i; // prod = prod * i
    }
    return prod;
}

Console.Write("Enter the number: ");
int N = int.Parse(Console.ReadLine()!);

System.Console.WriteLine($"Multiplication of numbers from 1 to {N} equals to {Multi(N)}");
