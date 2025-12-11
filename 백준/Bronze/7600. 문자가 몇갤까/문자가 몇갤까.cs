while (true)
{
    string a = Console.ReadLine();

    if (a == null)
        return;
    if (a == "#")
        break;

    bool[] b = new bool[26];

    foreach (char aa in a)
    {
        if (char.IsLetter(aa))
        {
            int c = char.ToLower(aa) - 'a';
            if (c >= 0 && c < 26)
            {
                b[c] = true;
            }
        }
    }

    int d = 0;
    for (int i = 0; i < 26; i++)
    {
        if (b[i]) d++;
    }

    Console.WriteLine(d);
}