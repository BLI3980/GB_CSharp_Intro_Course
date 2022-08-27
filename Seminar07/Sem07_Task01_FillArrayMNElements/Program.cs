//Task: Create 2D array of m x n size where each element value equals m + n.

Console.Clear();

Console.WriteLine("Enter the amount of row and columns of the array: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

void Fill2DArray(int[,] arr) // Fill the array as required
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i + j;
        }
    }
}

void Print2DArray(int[,] arr) // Print the array
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}


Fill2DArray(array);
Print2DArray(array);

