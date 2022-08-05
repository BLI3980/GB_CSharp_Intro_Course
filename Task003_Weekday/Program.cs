Console.Write("Введите число дня недели: ");
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
}
/**/
