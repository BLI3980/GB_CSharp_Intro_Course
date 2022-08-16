//Task: An integer number is entered through the console. The output is the sum of the digits of the number.

Console.WriteLine("Enter an integer number:");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int num = 0;
int sum = 0;

for (int i = 0; a > 0; i++) 
{
    num = a % 10;
    sum = sum + num;
    a = a / 10;
}
Console.WriteLine("The sum of all digits of this number is " + sum);

