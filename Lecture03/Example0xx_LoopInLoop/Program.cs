//Using loop in loop for creating Multiplication Table as an example.


for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}