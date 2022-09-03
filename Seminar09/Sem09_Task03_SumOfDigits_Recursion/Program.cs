//A number is entered through the console. Find out the sum of its digits.

Console.WriteLine("Enter the number: ");
int m = Convert.ToInt32(Console.ReadLine());


int SumOfDigits(int i)
{
    int sum = 0;
    if (i == 0) return sum;
    return sum = i % 10 + SumOfDigits(i / 10);
}

Console.WriteLine(SumOfDigits(m));















