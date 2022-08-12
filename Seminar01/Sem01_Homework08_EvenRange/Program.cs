//An integer number is entered. The output shows the range of numbers from 1 till the number entered.

Console.Write("Enter an integer number: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 1)
{
    Console.WriteLine($"No positive even numbers from 1 to {N}");
}
else
{
    int i = 2;
    while (i <= N)
    {
        Console.Write(i + " ");
        i += 2; 
    }
}