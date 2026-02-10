HashSet<char> hashSet = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

while (true)
{
    string a = Console.ReadLine();
    if (a == "end") 
        break;

    bool b = false;
    bool bb = true;

    int c = 0;
    int cc = 0;

    char d = '\0';

    foreach (char aa in a)
    {
        if (hashSet.Contains(aa))
        {
            b = true;
            c++;
            cc = 0;
        }
        else
        {
            cc++;
            c = 0;
        }

        if (c == 3 || cc == 3)
        {
            bb = false;
            break;
        }

        if (d == aa && aa != 'e' && aa != 'o')
        {
            bb = false;
            break;
        }

        d = aa;
    }

    if (!b)
        bb = false;

    if (bb)
        Console.WriteLine($"<{a}> is acceptable.");
    else
        Console.WriteLine($"<{a}> is not acceptable.");
}