//====Type 1: No input, no return =====
void Method1()
{
    Console.WriteLine("Example");
}
//Method(); //To call such method

//====Type 2: Some input, no return =====
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("the text of a message"); 

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Text", 4); 
//Method21(msg: "Text", count: 4); //other way to call such method
//Method21(count: 4, msg: "Text"); //no need to keep the order of arguments

//====Type 3: No input, some return =====
int Method3()
{
    return DateTime.Now.Year; // returns current year
}
int year = Method3(); //To call such method, can either create new variable or to call without variable
//Console.WriteLine(year);

//====Type 4: Some input, some return =====
string Method4(int count, char c)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + c; //Characters can be added to string without convertion from char to string.
        i++;
    }
    return result;
}
string res = Method4(10, 'a');
Console.WriteLine(res);