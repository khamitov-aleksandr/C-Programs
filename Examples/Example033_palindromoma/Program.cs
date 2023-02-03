// Write a program that takes a five-digit number as input and
// checks if it is a palindrome.
// 14212 -> no
// 12821 -> yes
// 23432 -> yes

Console.Clear();
Console.WriteLine("Enter your five-digit number: ");
int num = int.Parse(Console.ReadLine()!);
int num1 = num / 10000;
int num2 = num/1000  % 10;
int num4 = num/10 % 10;
int num5 = num % 10;
if (num1 == num5 && num2 == num4)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
