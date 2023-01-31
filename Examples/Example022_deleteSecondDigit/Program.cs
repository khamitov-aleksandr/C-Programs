// random 3-digit number shoud be shown without second digit
Console.Clear();

int num = new Random().Next(100, 1000);
Console.WriteLine($"Our number is {num}");
int a1 = num / 100;
int a2 = num % 10;
int result = a1*10 + a2;
Console.WriteLine($"Output without second digit is {result}");
