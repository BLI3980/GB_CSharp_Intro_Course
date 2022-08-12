//Checking if given number is even or odd

Console.WriteLine("Enter a number: ");
double a = Convert.ToDouble(Console.ReadLine());

if ( a % 2 == 0)
{
    Console.WriteLine($"Number {a} is the Even number");
}
else
{
    Console.WriteLine($"Number {a} is the Odd number");
}