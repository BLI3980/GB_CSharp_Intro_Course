//Task: Three numbers are entered. The output gives the largest of three.
Console.WriteLine("Enter the first number: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the third number: ");
double c = Convert.ToDouble(Console.ReadLine());

double max = a;
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
    
Console.WriteLine($"{max} is the largest of given three numbers");
// Can also add checks if any two or three of three are equal
