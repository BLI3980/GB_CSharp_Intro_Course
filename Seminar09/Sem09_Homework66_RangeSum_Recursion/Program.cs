// //Task: Numbers M and N are entered through the console. 
// Create a program which outputs the sum of the numbers from M to N.

Console.WriteLine("Enter the starting number of the range: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the ending number of the range:");
int n = Convert.ToInt32(Console.ReadLine());


int SumRange(int i, int j)
{
    if (i > j)
    {
        int sum = i;
        if (i == j) return sum;
        return sum + SumRange(i - 1, j);
    }
    else
    {
        int sum = i;
        if (i == j) return sum;
        return sum + SumRange(i + 1, j);
    }
}

Console.WriteLine($"The sum of the numbers from {m} to {n} is: {SumRange(m, n)}");


