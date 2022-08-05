//An integer number n is entered. The output is the range of numbers -n, -n+1,...,n.
/*Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int n2 = -n1;
int e = 0;

if (n2 > n1)
{
    e = n1;
    while ( e <= n2 )
    {
        Console.Write(e);
        e++;
    }
}
else
{
       e = n2;
       while ( e <= n1 )
    {
        Console.Write(e);
        e++;
    }
}*/

int n = 0;
Console.WriteLine("Enter a number: ");
n = Convert.ToInt32(Console.ReadLine());

for (int i = -n; i <= n; i++)
{
    Console.Write( i + " ");//Outputs a number followed by a space
    //i++;
}