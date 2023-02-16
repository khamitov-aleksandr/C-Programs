// 1 method
void Method1()
{
    Console.WriteLine("Method 1");
}
Method1();

// 2 method
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Method 2");

// 3 method
void Method3(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method3(msg: "Method 3", count: 1);
Method3(count: 1, msg: "Method 3");

int Method4()
{
    return DateTime.Now.Year;
}
int year = Method4();
Console.WriteLine($"Method 4: {year}");

string Method5(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method5(1, "Method 5");
Console.WriteLine(res);

// for

string Method6(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string newresult = Method6(1, "Method 6");
Console.WriteLine(newresult);

for (int i = 2; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}

// task separate text

Console.Clear();
string text = "несет самостоятельную ответственность по своим обязательствам, может от своего имени"
            + " приобретать и осуществлять имущественные и личные неимущественные права, исполнять"
            + " обязанности, быть истцом и ответчиком в суде. НКФО имеет самостоятельный баланс";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');

newText = Replace(newText, 'k', 'K');
newText = Replace(newText, 'c', 'C');
newText = Replace(newText, 'к', 'К');
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);

// task array

int [] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);