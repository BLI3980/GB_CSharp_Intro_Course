//Three numbers are entered through the console. Find out if a triangle with entered three peaks would exist.


//OPTION 1.============================================
// Console.WriteLine("Enter three integer numbers:");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());

// if (a + b > c && b + c > a && a + c > b)
// {
//     Console.WriteLine("This is a valid triangle");
// }
// else
// {
//     Console.WriteLine("This is an invalid triangle");
// }

// OPTION 2.============================================

bool IsTriangleExist(int a, int b, int c)
{
    if (a + b > c && b + c > a && a + c > b)
    {
        return true;
    }
    return false;
}
//Console.Clear();
Console.WriteLine("Enter three integer numbers:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

bool result = IsTriangleExist(a, b, c);

if (result == true)
{
    Console.WriteLine("This is a valid triangle");
}
else
{
    Console.WriteLine("This is an invalid triangle");
}
