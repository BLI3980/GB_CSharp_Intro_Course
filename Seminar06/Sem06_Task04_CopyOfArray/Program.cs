//Task: Create a program which makes a copy of an input array.

Console.WriteLine("Define the length of the array:");
int length = Convert.ToInt32(Console.ReadLine());

int[] array1 = new int[length]; // Define an initial array

void FillArray(int[] arr) // Method to fill the initial array
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] arr) // Method to print out any array
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

int[] CopyArray(int[] array1) // Method to create a copy of an input array
{
    int[] array2 = new int[length];
    for (int i = 0; i < array2.Length; i++)
    {
        array2[i] = array1[i];
    }
    return array2;
}

FillArray(array1);
Console.WriteLine("Your initial array: ");
PrintArray(array1);
Console.WriteLine("The copy of your initial array: ");
PrintArray(CopyArray(array1));