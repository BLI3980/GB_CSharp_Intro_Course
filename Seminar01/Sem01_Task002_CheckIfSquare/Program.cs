//Task: Two numbers are entered from console. A comparison is made to see if the first number is the square of the second. If yes - output "Yes", if not - output "No".

//First version of the code
Console.WriteLine("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b*b == a)
{
    Console.WriteLine("First number is a square of second number");
}
else
{
    Console.WriteLine("First number is NOT a square of second number");
}

//Second version of the code
/*int a = 0;
int b = 0;
Console.WriteLine("Enter first number: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
b = Convert.ToInt32(Console.ReadLine());

if (b*b == a)
{
    Console.WriteLine("First number is a square of second number");
}
else
{
    Console.WriteLine("First number is NOT a square of second number");
}*/