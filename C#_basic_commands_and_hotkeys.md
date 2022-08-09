# Syntax

| Syntax | Description |
|---------|------------|
| \|\| | - "Or" operation|
|&&| - "And" operation|
|//| - To comment a text or code. Have to be put at the beginning of commented part or at the beginning of a line if commenting an entire row. |
|/\* ... \*/| - To comment multiple continuous lines. /* at the beginning of commented part, */ at the end of the commented part|
|$" ... {output} ..."| - To insert an output into a text in parenthesis of the command *Console.WriteLine()*, like this *Console.WriteLine($" a text {output} a text")* |
|||

# Hotkeys

|Hotkey | Description |
|---------|------------|
| Ctrl+K, Ctrl+C |- To comment multiple lines with //, highlight the section you need and press these two hotkey commands; to uncomment Ctrl+K, Ctrl+U|
| Ctrl+C, Ctrl+V |- To copy and paste an entire line, just put a cursor on the line, do not need to highlight the line|
| Ctrl+~ | - To switch between panels of VSC |
| Ctrl+F2 | - To rename a file or folder in VSC |
|Alt+cursor| - Put cursor in multiple places after the same symbols which you want to replace with another symbol; Backspace and type |
|||
|||

# From Sergey Kamyaneckiy
# =============================
https://t.me/c/1745662062/46002

Разница у типов
float, double в объеме занимаемой памяти и диапазоне значений.
decimal используется там, где нужна большая точность.Этот тип позволяет хранить до 30 знаков, в т ч дробной части.

Детали читать в документации (https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types) 

var - это не тип данных, а инструкция чтобы компилятор сам назначил тип

Т е var a =1; у переменной а будет int
var b = 1.0; у b будет double

Object - это базовый тип для всего в с#, т е переменную такого типа можно положить все что угодно. Читаем «распаковка» «запаковка» типов. (Справедливо это, кстати, не только для шарпа..

Чтобы объяснить dynamic нужно понимать работу с рефлексией, в нем может храниться всё основанное на базовых и пользовательских типах

На старте изучения object и dynamic я бы отложил.
# =============================

# From w3schools.com
# =============================
## Switch

    int day = 3;
    switch = day;
    {
        case 1:
            Console.WriteLine("Today is Saturday");
            break;
        case 2:
            Console.WriteLine("Today is Sunday");
            break;
        default:
            Console.WriteLine("Looking forward to the Weekend");
            break; 
    }

## Loops
> Do, For, While

================

    int i = 1;
    do
    {
        Console.WriteLine (i);
        i++;
    }
    while i < 6;
================

    for (int i = 0, i < 5, i++)
    {
        Console.WriteLine("Yes");
    }
================

    for (int i = 0, i < 10, i++)
    {
        if (i == 5)
        {
            break; //stop outputing i if i becomes equal to 5.
        }
        Console.WriteLine(i);
    }
================

    for (int i = 0, i < 10, i++)
    {
        if (i == 4)
        {
            continue; //if i becomes equal to 4, jump to next value.
        }
        Console.WriteLine(i);
    }

## Arrays
================

    string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
    foreach (string i in cars) 
    {
    Console.WriteLine(i); //outputs each element of the array
    }
================

    string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
    Array.Sort(cars);
    foreach (string i in cars)
    {
    Console.WriteLine(i); //sorts the elements of the array, then outputs.
    } 
