//Task: Numbers M and N is entered through the console. Create a program which outputs the range of numbers from M to N.

Console.WriteLine("Enter the starting number of the range:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the ending number of the range: ");
int n = Convert.ToInt32(Console.ReadLine());


void RangeN(int m, int n)
{
    if (m > n) return;
    Console.Write($"{m} ");
    RangeN(m + 1, n);
}

RangeN(m, n);
