// Randomly fill a 2D array of m x n size. Find elements which have both indices as even numbers and replace those elements by their squares

Console.Clear();

Console.WriteLine("Enter the amount of row and columns of the array: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

void Fill2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void Print2DArray(int[,] arr)
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
Console.WriteLine("Original array: ");
Print2DArray(array);
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i += 2)
{
    for (int j = 0; j < array.GetLength(1); j += 2)
    {
        array[i, j] = array[i, j] * array[i, j];
    }
}
Console.WriteLine("Result array: ");
Print2DArray(array);