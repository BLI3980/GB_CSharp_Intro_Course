// Task: An integer number is entered through the console. The output is the third digit of the number or message that there is no third digit.

//Using long type of variables for situations with high digit numbers (more than 10 digits).

Console.WriteLine("Enter a number: ");

long a = Math.Abs(Convert.ToInt64(Console.ReadLine())); // An absolute value of entered number

if (a/100 > 0) //Check if entered number is three or more digit number
{
    while (a/1000 > 0) //Run the loop until the third digit of the number
    {
        a = a/10;
    }
    Console.WriteLine($"The third digit of your number is: {a % 10}"); //Extract the third digit from the number
}
else
{
    Console.WriteLine("There is no third digit in your number");
}