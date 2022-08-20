//Task: Create an array filled with random positive three-digit numbers. Find out how many elements of the array are even numbers
//Example: [345, 897, 568, 234] -> 2

int n = new Random().Next(2,11); // Randomly select how many elements will be in the array
int[] array = new int [n];

void FillPrintArray (int [] arr) // Randomly fill out the array with positive three-digit numbers and print it to the terminal
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

int CountEven (int [] arr) // Count even numbers of the array
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

FillPrintArray(array);

Console.WriteLine($"The array contains {CountEven(array)} even number(s)");
Console.WriteLine();

