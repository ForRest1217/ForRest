int a = int.Parse(Console.ReadLine());
HashSet<string> b = new HashSet<string>();
int c = 0;

for (int i = 0; i < a; i++)
{
    string aa = Console.ReadLine();

    if (aa == "ENTER")
    {
        b.Clear(); 
    }
    else
    {
        if (!b.Contains(aa))
        {
            b.Add(aa);
            c++;
        }
    }
}

Console.WriteLine(c);