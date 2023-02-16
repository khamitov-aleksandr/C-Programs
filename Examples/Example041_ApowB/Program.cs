// Write a loop that takes two numbers (A and B) as input and raises A to the power of B
Console.Clear();
int Prompt(string message)
{
    Console.Write(message);
    string readInput = (Console.ReadLine()!);
    int result = int.Parse(readInput);
    return result;
}

int Power(int powerBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }
    return power;
}

bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
        Console.WriteLine("It should't be less than zero");
        return false;
    }
    return true;
}

int powerBase = Prompt("Enter base: ");
int exponent = Prompt("Enter indicator: ");
if (ValidateExponent(exponent))
{
    Console.WriteLine($"Number {powerBase} raise pow exponentiation {exponent} equals {Power(powerBase, exponent)}");
}
