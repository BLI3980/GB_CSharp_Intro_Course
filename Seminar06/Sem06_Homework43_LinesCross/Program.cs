//Task: Write a program which find the cross point of two lines derived from equations y = k1*x + b1 and y = k2*x + b2. k1, b1, k2, b2 are given by user entry.

Console.WriteLine("Given equations are y = k1*x + b1 and y = k2*x + b2.");
Console.WriteLine("Enter k1, b1, k2 and b2 coefficients: ");
double b1 = Convert.ToDouble(Console.ReadLine());
double k1 = Convert.ToDouble(Console.ReadLine());
double b2 = Convert.ToDouble(Console.ReadLine());
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

if (k1 == k2)
{
    Console.WriteLine("The two lines are parallel to each other, therefore have no cross points.");
}
if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("The two lines overlay each other, therefore have infinite amount of cross points.");
}
else
{
    Console.WriteLine($"The cross point of given two lines has these coordinates: x({x}), y({y})");
}