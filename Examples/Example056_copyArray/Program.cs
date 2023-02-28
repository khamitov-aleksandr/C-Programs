// Write a program that will create a
// copy of the given array using element-by-element copying.
Console.Clear();

int[] CopyArray(int[] arr)
{
    int[] newArr = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
}

int[] array = { 1, 2, 3, 55 };

int[] newArray = CopyArray(array);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine();
Console.WriteLine(String.Join(", ", newArray));
