//Three numbers are entered through the console. Find out if a triangle with entered three peaks would exist.

Console.WriteLine("Enter three integer numbers:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a + b > c && b + c > a && a + c > b)
{
    Console.WriteLine("This is a valid triangle");
}
else
{
    Console.WriteLine("This is an invalid triangle");
}
