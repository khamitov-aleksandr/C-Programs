﻿// Write a program to convert decimal to binary.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();

string ConvertDecToBin(int number)
{
    string result = String.Empty;
    while (number != 0)
    {
        result = (number % 2).ToString() + result;
        number /= 2;
    }
    return result;
}

Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(ConvertDecToBin(n));
