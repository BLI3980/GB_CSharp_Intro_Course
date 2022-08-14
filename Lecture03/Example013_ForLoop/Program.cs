//====FOR loop =====
string Method4(int count, char c)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}
string res = Method4(10, 'a');
Console.WriteLine(res);