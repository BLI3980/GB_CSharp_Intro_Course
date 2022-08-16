//Task: Find a factorial of a number entered through the console.

Console.WriteLine("Enter a positive integer number");
int a = Convert.ToInt32(Console.ReadLine());

int factorial = 1;

if (a == 0) Console.WriteLine($"Factorial is 1");
else
{
    for ( int count = 1; count <= a ; count++)
    {
        factorial = factorial*count;
        Console.WriteLine(factorial);
    }
Console.WriteLine($"Factorial is {factorial}");
}


