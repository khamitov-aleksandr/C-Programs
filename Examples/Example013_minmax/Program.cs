// Write a program that takes two numbers as input and outputs which number is greater and which is less.
Console.WriteLine("Write first number: ");
int firstnumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write second number: ");
int secondnumber = int.Parse(Console.ReadLine()!);
if (firstnumber > secondnumber)
{
    Console.WriteLine($"max = {firstnumber}");
}
else if (firstnumber < secondnumber)
{
    Console.WriteLine($"max = {secondnumber}");
}
else if (firstnumber == secondnumber)
{
    Console.WriteLine($"You wrote same numbers, anyway max = {firstnumber}");
}
else
{
    Console.WriteLine("Please write numbers again");
}