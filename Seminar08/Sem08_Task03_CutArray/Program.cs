// Task: Given is a random 2D array. Create new array, in which the crossing of a row and a column containing minimum element of the original array, is cut out.

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
            if (arr[i, j] < 0) Console.Write(arr[i, j] + "	");
            else Console.Write(" " + arr[i, j] + "	");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Print2DArray(int[,] arr) // Print 2D array with tab as columns delimiter.
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 0) Console.Write(arr[i, j] + "	");
            else Console.Write(" " + arr[i, j] + "	");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    Console.WriteLine();
}

int row = 0;
int col = 0;

int MinElement(int[,] arr, out int row, out int col)
{
    int min = arr[0, 0];
    row = 0;
    col = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min)
            {
                min = array[i, j];
                row = i;
                col = j;
            }
        }
    }
    return min;
}

int[,] CutArray(int[,] arr, int row, int col)
{
    int[,] arr1 = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            int shiftI = 0;
            int shiftJ = 0;
            if (i < row) shiftI = 0; else shiftI = 1;
            if (j < col) shiftJ = 0; else shiftJ = 1;
            arr1[i, j] = arr[i + shiftI, j + shiftJ];


            // // OPTION 2 CONDITIONS
            // if (i < row || j < col) arr1[i, j] = arr[i, j]; 
            // if (i >= row) arr1[i, j] = arr[i + 1, j];
            // if (j >= col) arr1[i, j] = arr[i, j + 1];
            // if (i >= row && j >= col) arr1[i, j] = arr[i + 1, j + 1];
        }
    }
    return arr1;
}




FillPrint2DArray(array);
MinElement(array, out row, out col);
Console.WriteLine(row);
Console.WriteLine(col);
Console.WriteLine();
Print2DArray(CutArray(array, row, col));
