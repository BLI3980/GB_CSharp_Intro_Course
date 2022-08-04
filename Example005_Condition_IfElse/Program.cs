Console.Write("Enter you name: ");
string username = Console.ReadLine();
if(username.ToLower() == "dude")
{
    Console.WriteLine("Hey, DUDE!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}