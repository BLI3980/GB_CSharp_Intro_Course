// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// An integer number is entered through the console. The output is the third digit of the number or message that there is no third digit.

Console.WriteLine("Enter a number: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a/100 != 0) //Check if entered number is three or more digit number
{
    int ThirdDigit = Math.Abs((a % 1000) / 100); //Third digit of the number in its absolute value.
    Console.WriteLine("The third digit of your number is: " + ThirdDigit);
}
else
{
    Console.WriteLine("There is no third digit in your number");
}