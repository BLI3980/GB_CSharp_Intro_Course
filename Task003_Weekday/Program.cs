//Enter a number between 1 and 7 representing weekdays. The output is the name of the weekday.

//First Version of the code
/*Console.Write("Введите число дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n == 1) 
{
    Console.Write("Понедельник");
}
if(n == 2) 
{
    Console.Write("Вторник");
}
if(n == 3) 
{
    Console.Write("Среда");
}
if(n == 4) 
{
    Console.Write("Четверг");
}
if(n == 5) 
{
    Console.Write("Пятница");
}
if(n == 6) 
{
    Console.Write("Суббота");
}
if(n == 7) 
{
    Console.Write("Воскресение");
}
if(n > 7 || n < 1)
{
    Console.Write("Неверное значение");
}*/

//Second Version of the code.
Console.Write("Введите число дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());
switch (n)
{
    case 1:
    {
        Console.WriteLine("Понедельник");
        break;
    }
    case 2:
    {
        Console.WriteLine("Вторник");
        break;
    }
    case 3:
    {
        Console.WriteLine("Среда");
        break;
    }
    case 4:
    {
        Console.WriteLine("Четверг");
        break;
    }
    case 5:
    {
        Console.WriteLine("Пятница");
        break;
    }
    case 6:
    {
        Console.WriteLine("Суббота");
        break;
    }
    case 7:
    {
        Console.WriteLine("Воскресенье");
        break;
    }

}