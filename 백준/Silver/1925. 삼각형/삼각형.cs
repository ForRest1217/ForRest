long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
long[] b = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
long[] c = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

if ((b[0] - a[0]) * (c[1] - a[1]) - (b[1] - a[1]) * (c[0] - a[0]) == 0)
{
    Console.WriteLine("X");
    return;
}

long ab = (a[0] - b[0]) * (a[0] - b[0]) + (a[1] - b[1]) * (a[1] - b[1]);
long bc = (b[0] - c[0]) * (b[0] - c[0]) + (b[1] - c[1]) * (b[1] - c[1]);
long ca = (c[0] - a[0]) * (c[0] - a[0]) + (c[1] - a[1]) * (c[1] - a[1]);
long[] d = { ab, bc, ca };
Array.Sort(d);

if (d[0] == d[1] && d[1] == d[2])
    Console.WriteLine("JungTriangle");
else if (d[0] == d[1] || d[1] == d[2])
    Console.WriteLine(
        d[0] + d[1] == d[2] ? "Jikkak2Triangle" :
        d[0] + d[1] < d[2] ? "Dunkak2Triangle" :
                                        "Yeahkak2Triangle");
else
    Console.WriteLine(
        d[0] + d[1] == d[2] ? "JikkakTriangle" :
        d[0] + d[1] < d[2] ? "DunkakTriangle" :
                                        "YeahkakTriangle");