//Task: A positive number N is entered through the console. The output is the sum of the digits from 1 to N.

Console.WriteLine("Enter a positive integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

int sum = 0;

for (int count = 1; count <= a; count++)
{
    sum = sum + count;
}
Console.WriteLine($"The sum of the digits from 1 to {a} is equal to {sum}");
