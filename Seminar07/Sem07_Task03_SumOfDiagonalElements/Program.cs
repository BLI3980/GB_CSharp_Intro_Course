//Task: Create a random 2D array of m x n size. Find out a sum of all elements that are placed on the main diagonal.

Console.Clear();

Console.WriteLine("Enter the amount of row and columns of the array: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

void Fill2DArray(int[,] arr) // Randomly fill 2D array
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void Print2DArray(int[,] arr) // Print 2D array inside curly brackets and comma separated.
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("{");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j < arr.GetLength(1) - 1)
            {
                Console.Write(arr[i, j] + ", ");
            }
            else
            {
                Console.Write(arr[i, j]);
            }
        }
        Console.Write("}");
        Console.WriteLine();
    }
}

Fill2DArray(array);
Print2DArray(array);
Console.WriteLine();

int sum = 0;

for (int i = 0; i < array.GetLength(0); i++) // Sum up all elements that are placed on the main diagonal.
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i == j) sum = sum + array[i, j];
    }
}

Console.WriteLine("The sum of all elements placed on the main diagonal is: " + sum);