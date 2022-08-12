//Task: Two numbers are entered through the console. Check is the first is a multiple of the second.

Console.WriteLine("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a % b == 0)
{
    Console.WriteLine($"{a} is a multiple of {b}");
}
else
{
    Console.WriteLine($"{a} is NOT a multiple of {b}");
}
