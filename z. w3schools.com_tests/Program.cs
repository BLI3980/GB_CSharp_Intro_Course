﻿// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
// foreach (string i in cars) 
// {
//   Console.WriteLine(i);
// }

// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
// Array.Sort(cars);
// foreach (string i in cars)
// {
// Console.WriteLine(i);
// } 

// public class CustomMath(arg1, arg2) 
// {
//     public static int multiply(int a, int b); 
//     return a b;
// }

Console.WriteLine("Enter a number:");
int num = Convert.ToInt32(Console.ReadLine());

int digitIndex = 2;
int digit = num.ToString()[digitIndex] - '0';

Console.WriteLine(digit);