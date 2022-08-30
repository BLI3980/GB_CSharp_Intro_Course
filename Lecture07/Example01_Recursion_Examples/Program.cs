//Task 1 ===========================================================
//Compile a string with numbers from a to b, a<=b

// string NumbersFor(int a, int b) //Iterative method
// {
//     string result = String.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
// }


// string NumbersRec(int a, int b) //Recursive method
// {
//     if (a <= b) return $" {a} " + NumbersRec(a + 1, b);
//     else return String.Empty;
// }


// string NumbersRec(int a, int b) //Recursive method
// {
//     if (a < b) return $" {a} " + NumbersRec(a + 1, b);
//     else return Convert.ToString(b);
// }

// Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
// Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10

//==================================================================
//Task 2 ===========================================================
//Compile a string with numbers from a to b, a>=b

// string NumbersFor(int a, int b) //Iterative method
// {
//     string result = String.Empty;
//     for (int i = a; i >= b; i--)
//     {
//         result += $"{i} ";
//     }
// }


// string NumbersRec(int a, int b) //Recursive method
// {
//     if (a >= b) return NumbersRec(a + 1, b) + $" {a} ";
//     else return String.Empty;
// }


// Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
// Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10

//==================================================================
//Task 3 ===========================================================
//Sum of numbers from 1 to n

// int SumFor(int n) //Iterative method
// {
//     int result = 0;
//     for (int i = 1; i <= n; i++) result += i;
//     return result;
// }

// int SumRec(int n)
// {
//     if (n == 0) return 0;
//     else return n + SumRec(n - 1);
// }

// Console.WriteLine(SumFor(10)); // 55
// Console.WriteLine(SumRec(10)); // 55

//==================================================================
//Task 4 ===========================================================
//Factorial n

// int FactorialFor(int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= i;
//     return result;
// }

// int FactorialRec(int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }

// Console.WriteLine(FactorialFor(10)); // 3628800
// Console.WriteLine(FactorialRec(10)); // 3628800

//==================================================================
//Task 5 ===========================================================
// Find a^n

// int PowerFor(int a, int n)
// {
//     int result = 1;
//     for (int i = 1; i < n; i++) result *= a;
//     return result;
// }

// int PowerRec(int a, int n)
// {
//     if (n ==0) return 1;
//     else return PowerRec(a, n - 1) * a;
// }

// int PowerRec(int a, int n)
// {
//     return n == 0 ? 1 : PowerRec(a, n - 1) * a;
// }

// int PowerRecMath(int a, int n)
// {
//     if (n == 0) return 1;
//     else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
//     else return PowerRec(a, n - 1) * a;
// }

// Console.WriteLine(PowerFor(2, 10)); // 1024
// Console.WriteLine(PowerRec(2, 10)); // 1024
// Console.WriteLine(PowerRecMath(2, 10)); // 1024

//Task 5 ===========================================================
// Given are letters a, i, c, b. List all variations of combinations with T number of letters in a combination.

// char[] s = { 'a', 'i', 's', 'b' };

// int count = s.Length;
// int n = 1;

// for (int i = 0; i < count; i++) // For 1 letter combination
// {
//     Console.WriteLine($"{n++,-5}{s[i]}");
// }

// for (int i = 0; i < count; i++) // For 2 letters combination
// {
//     for (int j = 0; j < count; j++)
//     {
//         Console.WriteLine($"{n++,-10}{s[i]}{s[j]}"); //-10 is the amount of spaces after n
//     }
// }

int n = 1;

void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("aicb", new char[4]);
//==================================================================