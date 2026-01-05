int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int b = int.MaxValue;
int c = int.MaxValue;
for (int i = 0; i < a[1]; i++)
{
    int[] bc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    b = Math.Min(b, bc[0]);
    c = Math.Min(c, bc[1]);
}

int d = (a[0] + 5) / 6 * b;
int dd = a[0] * c;
int ddd = a[0] / 6 * b + a[0] % 6 * c;

Console.WriteLine(Math.Min(d, Math.Min(ddd, dd)));