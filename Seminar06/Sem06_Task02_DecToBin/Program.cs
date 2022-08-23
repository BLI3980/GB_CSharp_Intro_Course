//Task: Convert a decimal number to a binary number
//In order to convert dec to bin, the number needs to be divided by two; the quotients are also to be divided by two until the last quotient is equal 0
//Then all remainders lined up in reverse order are the number in binary system
//23(dec) -> 10111(bin) => 23/2 - r[0] = 1, q[0] = 11; 11/2 - r[1] = 1, q[1] = 5; 5/2 - r[2] = 1, q[2] = 2; 2/2 - r[3] = 0, q[3] = 1; 1/2 - r[4] = 1, q[4] = 0.

Console.WriteLine("Enter a decimal number:");
int a = Convert.ToInt32(Console.ReadLine());

string bin = String.Empty; // Declare an empty string

while (a >= 1)
{
    bin = a % 2 + bin; // Add a digit-character to the left of existing string. Then output "bin"
    Console.Write(a % 2); // Just to show which digit-character outputs at each iteration (reverse order of numbers)
    a = a / 2;
}
Console.WriteLine();
Console.Write(bin);