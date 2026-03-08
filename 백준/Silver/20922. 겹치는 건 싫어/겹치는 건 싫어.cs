int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Dictionary<int, int> c = new Dictionary<int, int>();
int d = 0;
int e = 0;
for (int i = 0; i < a[0]; i++)
{
    if (!c.ContainsKey(b[i]))
        c[b[i]] = 0;

    c[b[i]]++;

    while (c[b[i]] > a[1])
    {
        c[b[d]]--;
        d++;
    }

    e = Math.Max(e, i - d + 1);
}

Console.WriteLine(e);