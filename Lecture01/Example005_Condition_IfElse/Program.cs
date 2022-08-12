Console.Write("Enter your name: ");
string username = Console.ReadLine();
if(username.ToLower() == "dude")
{
    Console.WriteLine("Hey, DUDE! What's up?");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username); 
}