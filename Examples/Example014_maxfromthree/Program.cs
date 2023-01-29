// Task 4: Write a program that takes three numbers as input and outputs the maximum of these numbers
Console.WriteLine("Write first number");
int firstnumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write second number: ");
int secondnumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write third number: ");
int thirdnumber = int.Parse(Console.ReadLine()!);
int max = firstnumber;

if  (firstnumber > max) max = firstnumber;
if  (secondnumber > max) max = secondnumber;
if  (thirdnumber > max) max = thirdnumber;

Console.WriteLine(max);
