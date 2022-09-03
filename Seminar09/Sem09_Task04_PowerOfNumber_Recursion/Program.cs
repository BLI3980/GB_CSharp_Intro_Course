//Numbers A and B are entered through the console. Find A to the power of B

Console.WriteLine("Enter the number: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the power: ");
int n = Convert.ToInt32(Console.ReadLine());

int Power(int i, int j)
{
    if (j == 0) return 1;
    if (j == 1) return i;
    return i * Power(i, j - 1);
}

Console.WriteLine(Power(m, n));
