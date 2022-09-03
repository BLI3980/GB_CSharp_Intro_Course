//Task: Create random 2D array. Write a program which sorts elements of each row in descending order.

Console.Clear();
//Console.WriteLine("Enter how many rows there will be in the array: ");
int m = Convert.ToInt32(new Random().Next(3, 5));
//Console.WriteLine("Enter how many columns there will be in the array: ");
int n = Convert.ToInt32(new Random().Next(3, 5));
Console.WriteLine();

int[,] array = new int[m, n];

void FillPrint2DArray(int[,] arr) // Randomly fill out 2D array with integers and print it to the terminal
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-10, 11);
            Console.Write("{0,4}", arr[i, j]);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortArray(int[,] arr) // Sort each row elements in descending order.
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, k] > arr[i, j])
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = temp;
                }
            }

        }
    }
}

void Print2DArray(int[,] arr) // Print 2D array inside curly brackets and comma separated.
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0,4}", arr[i, j]);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine($"Original array with {m} rows and {n} columns:");
FillPrint2DArray(array);
SortArray(array);
Console.WriteLine($"The array after sorting row elements in descending order:");
Print2DArray(array);

//==============================================================================