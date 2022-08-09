// ??????????????

int a = new Random().Next(10, 100);

Console.WriteLine("Random number is "+ a);

int FirstDigit = a / 10;
int SecondDigit = a %10;

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