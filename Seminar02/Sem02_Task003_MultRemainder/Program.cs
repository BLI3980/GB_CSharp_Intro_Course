// A number is entered through the console. Check if the number divides without remainder by 7 and by 23.

Console.WriteLine("Enter the number: ");
int a = Convert.ToInt32(Console.ReadLine());

if ((a % 7 == 0) & (a % 23 == 0))
{
    Console.WriteLine($"{a} divides both by 7 and 23");
}
else
{
    Console.WriteLine($"{a} does NOT divide both by 7 and 23");
}
