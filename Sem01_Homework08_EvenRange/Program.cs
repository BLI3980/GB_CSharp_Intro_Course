Console.Write("Enter an integer number: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 1)
{
    Console.WriteLine("No even numbers for in this case");
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