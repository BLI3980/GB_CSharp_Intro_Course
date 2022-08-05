//A three digit number is entered. The output is the last digit of the number

//The first version of the code.
/*Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
//int m = n % 10; Console.Write(m);
Console.Write(n % 10);*/

//The second version of the code
int N = 0;
Console.WriteLine("Введите трехзначное число: ");
N = Convert.ToInt32(Console.ReadLine());

if (N >=100 && N <=999)
{
    int lastDigit = N % 10;
    Console.WriteLine("Последняя цифра числа = " + lastDigit);
}
else
{
    Console.WriteLine("Это не трехзначное число");
}