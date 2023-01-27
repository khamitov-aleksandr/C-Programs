// input 2 numbers and check is first number is sqr 

Console.WriteLine("Write number one ");
int firstnumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write second number ");
int secondnumber = int.Parse(Console.ReadLine()!);
if (secondnumber * secondnumber == firstnumber)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
