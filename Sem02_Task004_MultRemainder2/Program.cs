// ??????????????

Console.WriteLine("Enter the number: ");
int a = Convert.ToInt32(Console.ReadLine());


if ((a % 7 == 0) & (a % 23 == 0))
{
    Console.WriteLine($"{a} divides both to 7 and 23");
}
else
{
    Console.WriteLine($"{a} does NOT divide both to 7 and 23");
}
