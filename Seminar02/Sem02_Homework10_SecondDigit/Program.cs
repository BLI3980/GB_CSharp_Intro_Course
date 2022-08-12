// Task: A three digit integer number is entered through the console. The output is the second digit of the number.

Console.WriteLine("Enter a three digit number from 100 to 999: ");
int a = Convert.ToInt32(Console.ReadLine());

if ((a / 1000 == 0) && (a / 100 != 0)) //Check if entered number is three digit number
{
    int SecondDigit = Math.Abs((a % 100) / 10); //Second digit of the three digit number in its absolute value.
    Console.WriteLine("The second digit of your number is: " + SecondDigit);
}
else
{
    Console.WriteLine("The number you entered is NOT a three digit number");
}