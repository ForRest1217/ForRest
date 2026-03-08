int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

long c = 1;
long cc = b.Max();
long d = 0;
while (c <= cc)
{
    long e = 0;
    long ee = (c + cc) / 2;

    foreach (int bb in b)
        e += bb / ee;

    if (e >= a[0])
    {
        d = ee;
        c = ee + 1;
    }
    else
        cc = ee - 1;
}

Console.WriteLine(d);