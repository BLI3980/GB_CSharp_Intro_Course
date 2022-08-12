//Task: A five digit number is entered. The output is to check if the number is palindrome or not.

Console.WriteLine("Enter an integer five-digit number: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine())); 

if ((n < 100000) && (n >= 10000))
{
    if ((n / 10000 == n % 10) && ((n / 1000) % 10 == (n % 100) /10))
    {
        Console.Write("The number is a palindrome.");
    }
    else
    {
        Console.Write("The number is NOT a palindrome.");
    }
}
else
{
    Console.Write("The number you've entered in NOT a five-digit number. Try again.");
}
