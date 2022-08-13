//Task: A number N is entered through the console. The output is the range of numbers from 1 to N to the power of 3 each and comma separated.

 //OPTION 1. WITH ONE "FOR" LOOP =====================
Console.WriteLine("Enter an integer number: ");
int n = Convert.ToInt32(Console.ReadLine()); 

int stopCycle = Math.Abs(n);

Console.WriteLine($"The range of numbers from 1 to {n}, raised to the power of 3, is as follows: ");

if (n <= 0) Console.Write("1, 0, ");

for ( int count = 1; count <= stopCycle; count++)
{
    if (n <= 0)
    {
        Console.Write(-Math.Pow(count,3));
    }
    else
    {
        Console.Write(Math.Pow(count,3));
    }
    if (count < stopCycle)
    {
        Console.Write(", ");
    }
}

 //=============================================

/* //OPTION 2. WITH TWO "FOR" LOOPS ==============
Console.WriteLine("Enter an integer number: ");
int n = Convert.ToInt32(Console.ReadLine()); 

int count = 1;

Console.WriteLine($"The range of numbers from 1 to {n}, raised to the power of 3, is as follows: ");

if (n <= 0) 
{
    for (count = 1; count >= n; count--)
    {
        Console.Write(Math.Pow(count,3));
        if (count > n)
        {
        Console.Write(", ");
        }
    }
    
}
else
{
    for (count = 1; count <= n; count++)
    {
        Console.Write(Math.Pow(count,3));
        if (count < n)
        {
        Console.Write(", ");
        }
    }
    
}
*/ //=============================================

/* //OPTION 3. WITH TWO "WHILE" LOOPS ============
Console.WriteLine("Enter an integer number: ");
int n = Convert.ToInt32(Console.ReadLine()); 

int count = 1;

Console.WriteLine($"The range of numbers from 1 to {n}, raised to the power of 3, is as follows: ");

if (n <= 0) 
{
    while (count >= n)
    {
        Console.Write(Math.Pow(count,3));
        if (count > n)
        {
        Console.Write(", ");
        }
        count--;
    }
    
}
else
{
    while (count <= n)
    {
        Console.Write(Math.Pow(count,3));
        if (count < n)
        {
        Console.Write(", ");
        }
        count++;
    }
}   
*/ //=============================================