//Task: A number is entered through the console. The output
Console.WriteLine("Enter a positive integer number more than zero");
int a = Convert.ToInt32(Console.ReadLine());

int numDigits = 0;
int count = 0;

for (numDigits = a; numDigits > 0; count++)
{
    numDigits = numDigits / 10;
}
Console.WriteLine($"There are {count} digits in your number");
