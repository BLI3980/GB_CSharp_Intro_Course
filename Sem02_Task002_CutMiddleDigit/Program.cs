// ??????????????

int a = new Random().Next(100,1000);

Console.WriteLine("Random number is "+ a);

int FirstDigit = a / 100;
int SecondDigit = a % 10;

int NewNumber = 10 * FirstDigit + SecondDigit;

Console.WriteLine("Two digit number is "+ NewNumber);



