//Task: Create randomly filled 2D array. Find average value of elements in each column.

Console.Clear();

int m = new Random().Next(2, 6); // Randomly select the amount of row indices of the array
int n = new Random().Next(2, 6); // Randomly select the amount of column indices of the array
Console.WriteLine();

int[,] array = new int[m, n];

void FillPrint2DArray(int[,] arr, int rangeMin, int rangeMax) // Randomly fill out 2D array with integers and print it to the terminal
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("{");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(rangeMin, rangeMax);
            if (j < arr.GetLength(1) - 1) // Define spacing between columns in order to arrange them nicely straight
            {
                if (arr[i, j] == -10) Console.Write($"{arr[i, j]}, ");
                if ((arr[i, j] >= -9) && (arr[i, j] < 0)) Console.Write($"{arr[i, j]},  ");
                if (arr[i, j] == 10) Console.Write($" {arr[i, j]}, ");
                if ((arr[i, j] <= 9) && (arr[i, j] >= 0)) Console.Write($" {arr[i, j]},  ");
            }
            else // Spacing for the last column
            {
                if (arr[i, j] == -10) Console.Write($"{arr[i, j]} ");
                if ((arr[i, j] >= -9) && (arr[i, j] < 0)) Console.Write($"{arr[i, j]}  ");
                if (arr[i, j] == 10) Console.Write($" {arr[i, j]} ");
                if ((arr[i, j] <= 9) && (arr[i, j] >= 0)) Console.Write($" {arr[i, j]}  ");
            }
        }
        Console.Write("}");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine($"Given randomly sized array of {m} rows and {n} columns is: ");
FillPrint2DArray(array, rangeMin: -2, rangeMax: 4);

void AverageOfColumn(int[,] arr) // Find the average value of elements in each column
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        double average = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum = sum + arr[i, j];
        }
        average = Math.Round(sum / arr.GetLength(0), 2);
        Console.WriteLine($"column {j} average is: {sum}/{arr.GetLength(0)} = {average}");
    }
    Console.WriteLine();
}

AverageOfColumn(array);
