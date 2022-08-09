//A number representing a day of week is entered through the console. The output shows if the number corresponds to weekend or not.

Console.WriteLine("Enter a number from 1 to 7 representing a day of week (where 1 is Monday): ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 0 && a < 8)
{ 
    if (a == 6)
    {
        Console.WriteLine("It's Saturday");
    }
    else if (a == 7)
    {
        Console.WriteLine("It's Sunday");
    }
    else
    {
        Console.WriteLine("It's not a weekend! Go back to work!");
    }
}
else
{
    Console.WriteLine("The number you entered does not represent a day of week.");
}