// Task: Create rectangular 2D array. Make a program which finds a row with smallest sum of elements in each row.

//Two loops.
//Outer loop goes through rows
//Inner loop goes through columns and sums all elements

//Need a comparison of all sums and assignment of a row in each comparison

Console.Clear();

int m = Convert.ToInt32(new Random().Next(3, 5)); // Randomly select how many rows will be in array
int n = m + Convert.ToInt32(new Random().Next(3, 5)); //Randomly select how many columns will be in array, which is larger than m
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

int FindSmallestRow(int[,] arr)
{
    int sum = 0;
    for (int i = 0, j = 0; j < arr.GetLength(1); j++)
    {
        sum = sum + arr[i, j];
    }
    int minSum = sum;
    int rowOfMinSum = 0;
    Console.WriteLine($"row {0}, sum {sum}, minSum {minSum}, rowOfMinSum {rowOfMinSum}");

    for (int i = 1; i < arr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum; rowOfMinSum = i;
        }
        Console.WriteLine($"row {i}, sum {sum}, minSum {minSum}, rowOfMinSum {rowOfMinSum}");
    }
    return rowOfMinSum;
}



Console.WriteLine($"Array with {m} rows and {n} columns:");
FillPrint2DArray(array);
int result = FindSmallestRow(array);
Console.WriteLine();
Console.WriteLine($"The index of the row with the smallest sum of all elements in the row is: {result}");
Console.WriteLine();


