int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();

int c = 0;
int d = 0;
int e = b.Max();

while (c <= e)
{
    int cc = (c + e) / 2;
    long dd = 0;

    foreach (int bb in b)
    {
        if (bb > cc)
            dd += bb - cc;
    }

    if (dd >= a[1])
    {
        d = cc;
        c = cc + 1;
    }
    else
    {
        e = cc - 1;
    }
}

Console.WriteLine(d);