// Write a program that takes a three-digit number as input and outputs the second digit of that number.
Console.Clear();

int num = new Random().Next(100, 1000);
Console.WriteLine($"Our number is {num}");
int a1 = num / 100;
Console.WriteLine($"First digit is {a1}");
int a3 = num % 10;
Console.WriteLine($"Third digit is {a3}");
int result = (num - (a1*100 + a3))/10;
Console.WriteLine($"Output without first and third digit is {result}");
