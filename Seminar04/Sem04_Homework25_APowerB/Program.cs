//Task: A and B are input integer numbers through the console. Find A to the power of B.
//Намеренно не используем встроенный метод Math.Pow, чтобы решить с помощью цикла.

Console.WriteLine("Enter your numbers A and B:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int powAB = 1;

for (int i = 0; i < b; i++)
{
    powAB = powAB * a;
}
Console.WriteLine($"A to the power of B equals {powAB}");