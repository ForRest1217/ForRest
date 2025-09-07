string a = Console.ReadLine().ToUpper();
Dictionary<char, int> dic = new Dictionary<char, int>();
int b = 0;
char d = '?';

foreach (char c in a)
{
    if (dic.ContainsKey(c))
        dic[c]++;
    else
        dic[c] = 1;
}

foreach (var c in dic)
{
    if (c.Value > b)
    {
        b = c.Value;
        d = c.Key;
    }
    else if (c.Value == b)
    {
        d = '?';
    }
}

Console.WriteLine(d);