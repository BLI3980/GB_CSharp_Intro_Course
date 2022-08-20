//Task: Create one-dimension array of double-type randomly filled numbers. Find out the difference between max and min elements of the array.
//Example: 
//[3 7 22 2 78] -> 78 - 2 = 76

int n = new Random().Next(2,11); // Randomly select how many elements will be in the array between 2 and 10
double[] array = new double [n];

void FillPrintDouble(double[] arr) // Randomly fill out the array with doubles and print it to the terminal
{
    Random rand = new Random();
    double min = -100;
    double max = 100;
    double range = max - min;
    for (int i = 0; i < arr.Length; i++)
    {
        double sample = rand.NextDouble();
        double scaled = (sample * range) + min;
        arr[i] = Math.Round(scaled,2);
        Console.Write(arr[i] + "   ");

    }
    Console.WriteLine();
    Console.WriteLine();
}


double MinMaxDiff (double [] arr) // Calculate difference between the largest and the smallest element of the array
{
    double diff = 0;
    double min = arr[0];
    double max = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    diff = max - min;
    return diff;
}

FillPrintDouble(array);

Console.WriteLine($"The difference between max and min elements of the array is: {MinMaxDiff(array)}");
Console.WriteLine();


