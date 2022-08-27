//Task: Create a 2D array of m x n size, filled it with random real numbers.

Console.Clear();
Console.WriteLine("Enter the size of the dimensions of 2D array: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


double[,] array = new double[m, n];


void FillPrint2DArray(double[,] arr, int rangeMin, int rangeMax) // Randomly fill and print 2D array inside curly brackets and comma separated.
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("{");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(new Random().NextDouble() * (rangeMax - rangeMin) + rangeMin, 2);
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

FillPrint2DArray(array, -10, 10);
Console.WriteLine();
