//Task: A random two digit number in the range from 10 to 99 inclusive is taken. The first and the second digits of the number are compared to see which one is larger.

int a = new Random().Next(10, 100);

Console.WriteLine("Random number is "+ a);

int FirstDigit = a / 10;
int SecondDigit = a % 10;

if (FirstDigit > SecondDigit)
{
    Console.WriteLine("Highest Digit is "+ FirstDigit);
}
else if (FirstDigit == SecondDigit)
{
    Console.WriteLine("Both digits are equal");
}
else
{
    Console.WriteLine("Highest Digit is "+ SecondDigit);
}