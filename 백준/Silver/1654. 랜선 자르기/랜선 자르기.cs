int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
long[] b = new long[a[0]];
for (int i = 0; i < a[0]; i++)
    b[i] = long.Parse(Console.ReadLine());

long c = 1;
long d = 0;
foreach (var bb in b)
    if (bb > d)
        d = bb;

long e = 0;

while (c <= d)
{
    long f = (c + d) / 2;
    long ff = 0;

    foreach (var bbb in b)
        ff += bbb / f;

    if (ff >= a[1])
    {
        e = f;
        c = f + 1;
    }
    else
    {
        d = f - 1;
    }
}

Console.WriteLine(e);