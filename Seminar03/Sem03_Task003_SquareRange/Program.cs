//Task: A number N is entered through the console. The output is the range of numbers from 1 to N squared and comma separated.

Console.WriteLine("Enter an integer number: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int count = 1;

while( count <= n)
{
    Console.Write(count*count);
    if (count < n)
    {
        Console.Write(", ");
    }
    count++;
}
