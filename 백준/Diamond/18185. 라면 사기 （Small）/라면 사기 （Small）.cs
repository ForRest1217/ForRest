 int a = int.Parse(Console.ReadLine());
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
long c = 0;
for (int i = 0; i < a; i++)
{
    if (i + 2 < a)
    {
        if (b[i + 1] > b[i + 2])
        {
            int aa = Math.Min(b[i], b[i + 1] - b[i + 2]);
            b[i] -= aa;
            b[i + 1] -= aa;
            c += 5 * aa;
        }

        int aaa = Math.Min(b[i], Math.Min(b[i + 1], b[i + 2]));
        b[i] -= aaa;
        b[i + 1] -= aaa;
        b[i + 2] -= aaa;
        c += 7 * aaa;
    }

    if (i + 1 < a)
    {
        int aa = Math.Min(b[i], b[i + 1]);
        b[i] -= aa;
        b[i + 1] -= aa;
        c += 5 * aa;
    }

    c += 3 * b[i];

    b[i] = 0;
}

Console.WriteLine(c);