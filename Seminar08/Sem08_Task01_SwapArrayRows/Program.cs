// Task: Given is a random 2D array. Swap elements of the first row with the elements of the last row.

Console.Clear();

int m = Convert.ToInt32(new Random().Next(3, 5)); // Randomly select how many rows will be in array
int n = Convert.ToInt32(new Random().Next(3, 5)); //Randomly select how many columns will be in array
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

void Swap(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1) - 1; j++)
    {
        int temp = 0;
        temp = arr[0, j];
        arr[0, j] = arr[arr.GetLength(0) - 1, j];
        arr[arr.GetLength(0) - 1, j] = temp;
    }
}

void Print2DArray(int[,] arr) // Print 2D array with tab as columns delimiter.
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

FillPrint2DArray(array);
Swap(array);
Print2DArray(array);