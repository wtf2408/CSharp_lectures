Console.Clear();
string Method1 (int count, string text)
{
    string result = String.Empty; 

    for (int i=0; i<count; i++)
    {
        result = result + text;
    }

    return result;
}

string res = Method1(100, "хаХа");
Console.WriteLine(res);
