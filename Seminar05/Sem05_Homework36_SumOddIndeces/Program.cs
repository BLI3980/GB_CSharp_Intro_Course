//Task: Create one-dimension array filled with random numbers. Sum up all numbers under odd indices of the array.
//Examples: 
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int n = new Random().Next(2,11); // Randomly select how many elements will be in the array between 2 and 10
int[] array = new int [n];

void FillPrintArray (int [] arr) // Randomly fill out the array and print it to the terminal
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100, 101);
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

int SumEven (int [] arr) // Sum up all numbers under odd indices ([1], [3], [5], etc)
{
    int sum = 0;
    // for (int i = 0; i < arr.Length; i++) // Summing only odd numbers through the loop
    // {
    //     if (i % 2 != 0) 
    //     {
    //         sum = sum + arr[i];
    //     }
    // }
    for (int i = 1; i < arr.Length; i+=2) // The other way of summing, by increasing a step in the loop
    {
         sum = sum + arr[i];
    }
    return sum;
}

FillPrintArray(array);

Console.WriteLine($"The sum of all numbers under odd indices equals to: {SumEven(array)}");
Console.WriteLine();


