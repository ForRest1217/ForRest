int a = int.Parse(Console.ReadLine());
int[] b = new int[a + 1];
int[] c = new int[a + 1];
int[] d = new int[a + 2];

for (int i = 1; i <= a; i++)
{
    int[] aa = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    b[i] = aa[0];
    c[i] = aa[1];
}

for (int i = a; i >= 1; i--)
{
    if (i + b[i] <= a + 1)
        d[i] = Math.Max(c[i] + d[i + b[i]], d[i + 1]);
    else
        d[i] = d[i + 1];
}

Console.WriteLine(d[1]);