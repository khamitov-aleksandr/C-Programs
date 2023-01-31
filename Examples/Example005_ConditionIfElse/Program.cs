Console.Write("Write your name: ");
string username = (Console.ReadLine()!);

if (username.ToLower() == "alex")
{
    Console.WriteLine("Yes, it is Alex!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}
