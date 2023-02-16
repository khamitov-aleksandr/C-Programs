// Write a program that takes a number as input and returns the sum of the digits in the number
Console.Clear();
int Prompt(string message)
{
    Console.Write(message);
    string readInput = (Console.ReadLine()!);
    int result = int.Parse(readInput);
    return result;
}

int SumAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

int number = Prompt("Enter a number: ");
Console.WriteLine($"the sum of the all digits in the number {number} = {SumAllDigit(number)}");
