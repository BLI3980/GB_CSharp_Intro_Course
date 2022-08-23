// Task: Finding Fibonacci sequence without usage of recursion method:

// OPTION 1: Using an array
Console.WriteLine("Enter an integer number:");
int n = Convert.ToInt32(Console.ReadLine());

int[] Fibonacci = new int[n];

Fibonacci[0] = 0;
Fibonacci[1] = 1;

for (int i = 2; i < n; i++)
{
    Fibonacci[i] = Fibonacci[i - 1] + Fibonacci[i - 2];
}

for (int i = 0; i < n; i++)
{
    Console.Write(Fibonacci[i]);
}

// OPTION 2: Using a sting
// Console.WriteLine("Enter an integer number:");
// int n = Convert.ToInt32(Console.ReadLine());

// int firstElem = 0;
// int secondElem = 1;

// Console.WriteLine("The Fibonacci sequence is :");
// Console.WriteLine("1. " + firstElem);
// Console.WriteLine("2. " + secondElem);


// for (int i = 3; i <= n; i++)
// {
//     int nextElem = firstElem + secondElem;
//     Console.WriteLine($"{i}. {nextElem}");
//     firstElem = secondElem;
//     secondElem = nextElem;
// }

