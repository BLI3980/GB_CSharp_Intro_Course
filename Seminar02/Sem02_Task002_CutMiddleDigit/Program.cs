//Task: A random three digit number in the rage from 100 to 999 inclusive is taken. The middle digit is cut out and the first digit put in front of the third digit.

int a = new Random().Next(100,1000);

Console.WriteLine("Random number is "+ a);

int FirstDigit = a / 100;
int SecondDigit = a % 10;

int NewNumber = 10 * FirstDigit + SecondDigit;

Console.WriteLine("Two digit number is "+ NewNumber);



