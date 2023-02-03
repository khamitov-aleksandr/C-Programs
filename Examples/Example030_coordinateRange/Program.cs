// Write a program that, at a given number,
// quarters, shows the range of possible coordinates
// points in this quarter (x and y).
Console.Clear();

Console.Write("Enter number of quarter: ");
int quarter = int.Parse(Console.ReadLine()!);

switch (quarter)
{
    case 1:
        Console.Write("X>0 , Y>0 ");
        break;

    case 2:
        Console.Write("X<0 , Y>0 ");
        break;
    case 3:
        Console.Write("X<0 , Y<0 ");
        break;
    case 4:
        Console.Write("X>0 , Y<0 ");
        break;
    default:
        Console.Write("Please, enter a number from 1 to 4 ");
        break;

}