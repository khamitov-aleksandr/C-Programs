//Task 15: Write a program that takes as input a number representing the day of the week
// and checks if that day is a holiday

Console.Clear();
Console.Write("Write a number for the day of the week: ");
int day = int.Parse(Console.ReadLine()!);
if (day == 6 || day == 7)
{
  Console.WriteLine("Yes");
}
else if (day < 1 || day > 7)
{
  Console.WriteLine("Please write a number between 1 to 7");
}
else if (day > 0 && day <= 5)
{
  Console.WriteLine("No");
}
else
{
  Console.WriteLine("Smth wrong. Try again with another number");
}

