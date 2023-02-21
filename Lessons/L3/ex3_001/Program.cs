Console.Clear();

string Method(int count, string text)
{
    string result = String.Empty;
    
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }

    return result;
}

string res = Method(10, "z");
Console.WriteLine(res);