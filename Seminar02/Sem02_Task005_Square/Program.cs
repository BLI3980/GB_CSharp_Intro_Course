//Task: Two numbers are entered through console. Check if one of them is the square of the other.

Console.WriteLine("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());
// Can also try to do the same with random numbers

if (( a == b * b) || ( b == a * a))
{
    Console.WriteLine("One number is square of the other");
}
else
{
    Console.WriteLine("None of two is square of the other");
}

