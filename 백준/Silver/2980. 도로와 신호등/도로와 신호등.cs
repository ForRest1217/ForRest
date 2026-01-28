int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int b = 0;
int c = 0;

for (int i = 0; i < a[0]; i++)
{
    int[] aa = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    b += aa[0] - c;
    c = aa[0];

    int d = b % (aa[1] + aa[2]);

    if (d < aa[1])
        b += aa[1] - d;
}

b += a[1] - c;

Console.WriteLine(b);