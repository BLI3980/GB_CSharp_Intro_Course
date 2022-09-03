// Task: Given are two 2D arrays - A and B. Create new array C, which is a multiplication of A and B in the following way:
// C[i, j] is the sum of products of elements in "i" row of array A to elements in "j" column of array B
// Example:
// A: 2 4    B: 3 4
//    3 2       3 3
// C:
// C (0,0) = A(0,0)xB(0,0) + A(0,1)xB(1,0)
// C (0,1) = A(0,0)xB(0,1) + A(0,1)xB(1,1)
// C (1,0) = A(1,0)xB(0,0) + A(1,1)xB(1,0)
// C (1,1) = A(1,0)xB(0,1) + A(1,1)xB(1,1)
// Note: In order to have multiplication work, amount of columns in array A must match the amount of rows in array B.
// If A[k, l], B[m, n] => C[k, n]

Console.Clear();

int rowsA = Convert.ToInt32(new Random().Next(2, 5)); // Randomly select how many rows will be in array A
int colsA = Convert.ToInt32(new Random().Next(2, 5)); // Randomly select how many columns will be in array A
int rowsB = colsA; // Amount of rows in array B must match the amount of columns in array A for multiplication to work
int colsB = Convert.ToInt32(new Random().Next(2, 5)); // Randomly select how many columns will be in array A
Console.WriteLine();

int[,] arrA = new int[rowsA, colsA];
int[,] arrB = new int[rowsB, colsB];


void FillPrint2DArray(int[,] arr, int randomMin, int randomMax) // Randomly fill out 2D array with integers and print it to the terminal
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write("----");
    }
    Console.Write("-");
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(randomMin, randomMax);
            Console.Write("{0,4}", arr[i, j] + " |");
        }
        Console.WriteLine();
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("----");
        }
        Console.Write("-");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Print2DArray(int[,] arr) // Print 2D array with tab as columns delimiter.
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write("----");
    }
    Console.Write("-");
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0,4}", arr[i, j] + " |");
        }
        Console.WriteLine();
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("----");
        }
        Console.Write("-");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ArrayC(int[,] arrA, int[,] arrB) // Multiply Array A to Array B in the specified way to derive Array C
{
    int[,] arrC = new int[arrA.GetLength(0), arrB.GetLength(1)];
    for (int i = 0; i < arrC.GetLength(0); i++)
    {
        for (int j = 0; j < arrC.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arrA.GetLength(1); k++)
            {
                sum += arrA[i, k] * arrB[k, j];
            }
            arrC[i, j] = sum;
        }
    }
    return arrC;
}



Console.WriteLine($"\nArray \"A\" with {rowsA} rows and {colsA} columns: ");
FillPrint2DArray(arrA, 1, 6);
Console.WriteLine($"Array \"B\" with {rowsB} rows and {colsB} columns: ");
FillPrint2DArray(arrB, 1, 6);
Console.WriteLine($"Array \"C\" with {rowsA} rows and {colsB} columns: ");
Print2DArray(ArrayC(arrA, arrB));

