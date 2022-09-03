//Task: A number N is entered through the console. Create a program which outputs the range of numbers from 1 to N.

Console.WriteLine("Enter a positive integer number: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 1;

void RangeN(int n)
{
    if (i > n) return;
    Console.Write($"{i} ");
    i++;
    RangeN(n);
}

RangeN(n);

