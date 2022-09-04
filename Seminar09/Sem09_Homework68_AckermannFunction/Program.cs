// //Task: Non-negative numbers M and N are entered through the console. 
// Create a program which calculates Ackermann function for M and N arguments.

Again:
Console.WriteLine("Enter the first argument: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second argument: ");
int n = Convert.ToInt32(Console.ReadLine());


if ((m > 4) || (m >= 4 && n > 0) || (m >= 3 && n > 10))
{
    Console.WriteLine();
    Console.WriteLine("Sorry, the result will be so huge that this little program ");
    Console.WriteLine("will choke up in the flood of the calculations :((. ");
    Console.WriteLine("It's called stack overflow. So, please try smaller input numbers.");
    Console.WriteLine();
    goto Again;
}
else
{
    int result = 0;
    int Ackermann(int m, int n)
    {
        if (m == 0) result = n + 1;
        // Console.WriteLine($"1: {n + 1}");
        if (m > 0 && n == 0) Ackermann(m - 1, 1);
        // Console.WriteLine($"2: {m - 1}, 1");
        if (m > 0 && n > 0) Ackermann(m - 1, Ackermann(m, n - 1));
        // Console.WriteLine($"3: {m - 1}, Ackermann(m, n - 1)");
        return result;
    }
    Console.WriteLine($"The Ackermann function returns: {Ackermann(m, n)}");
    Console.WriteLine();
}


