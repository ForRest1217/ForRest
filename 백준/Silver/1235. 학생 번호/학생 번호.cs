int a = int.Parse(Console.ReadLine());
string[] b = new string[a];
for (int i = 0; i < a; i++)
{
    b[i] = Console.ReadLine();
}

int c = b[0].Length;
for (int i = 1; i <= c; i++)
{
    HashSet<string> hashSet = new HashSet<string>();
    bool isit = true;

    for (int j = 0; j < a; j++)
    {
        string d = b[j].Substring(c - i);
        if (!hashSet.Add(d))
        {
            isit = false;
            break;
        }
    }

    if (isit)
    {
        Console.WriteLine(i);
        break;
    }
}