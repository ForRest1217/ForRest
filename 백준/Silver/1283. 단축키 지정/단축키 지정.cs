int a = int.Parse(Console.ReadLine());
HashSet<char> hashSet = new HashSet<char>();

for (int i = 0; i < a; i++)
{
    string aa = Console.ReadLine();
    bool c = false;

    for (int j = 0; j < aa.Length; j++)
    {
        if (j == 0 || aa[j - 1] == ' ')
        {
            char d = char.ToLower(aa[j]);

            if (!hashSet.Contains(d))
            {
                hashSet.Add(d);
                c = true;

                aa = aa.Substring(0, j) + "[" + aa[j] + "]" + aa.Substring(j + 1);

                break;
            }
        }
    }

    if (!c)
    {
        for (int j = 0; j < aa.Length; j++)
        {
            if (aa[j] == ' ') 
                continue;

            char d = char.ToLower(aa[j]);

            if (!hashSet.Contains(d))
            {
                hashSet.Add(d);

                aa = aa.Substring(0, j) + "[" + aa[j] + "]" + aa.Substring(j + 1);

                break;
            }
        }
    }

    Console.WriteLine(aa);
}