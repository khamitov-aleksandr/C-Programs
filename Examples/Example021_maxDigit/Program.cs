// Write a number from [10,99] and find a max digit
Console.Clear();

int num = new Random().Next(10, 100); // 10-99
int a1 = num / 10;
int a2 = num % 10;

int max = a1;
if (a2 > max)
{
    max = a2;
}
Console.WriteLine($"max number of {num}, equil to {max}");
