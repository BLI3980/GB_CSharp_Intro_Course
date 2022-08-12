//Task: A number representing XY coordinates quadrant is entered through the console. The output is the range of X and Y.

Console.WriteLine("Enter a quadrant of XY coordinate: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n <= 4)
{
    if (n <= 2)
    {
        if (n < 2)
        {
            Console.WriteLine(" X > 0, Y > 0 ");
        }
        else
        {
            Console.WriteLine(" X < 0, Y > 0 ");
        }
    }
    else if (n > 3)
    {
        Console.WriteLine(" X > 0, Y < 0 ");
    }
    else
    {
        Console.WriteLine(" X < 0, Y < 0 ");
    }
}

    

