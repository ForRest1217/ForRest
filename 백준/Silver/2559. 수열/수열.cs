int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int c = 0;
for (int i = 0; i < a[1]; i++)
{
    c += b[i];
}


int d = c;
for (int i = a[1]; i < a[0]; i++)
{
    c += b[i] - b[i - a[1]];
    if (c > d)
        d = c;
}

Console.WriteLine(d);