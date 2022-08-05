//Two numbers are entered. The output compares which number is larger

Console.WriteLine("Enter the first number: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
double b = Convert.ToDouble(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"{a} is larger than {b}");
}
else
{
    Console.WriteLine($"{b} is larger than {a}");
}
