//Task: A number N is entered through the console. 
// Create a program which outputs the range of numbers from N to 1.

Console.WriteLine("Enter any integer number: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = n;

void RangeN(int rangeNumber)
{
    if (n > 0)
    {
        if (i < 1) return;
        Console.Write($"{i} ");
        i--;
        RangeN(rangeNumber);
    }
    else
    {
        if (i > 1) return;
        Console.Write($"{i} ");
        i++;
        RangeN(rangeNumber);
    }
}
RangeN(n);