int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
bool ok = true;

for (int i = c; i <= 100; i++)
{
    int d = a[0] * i + a[1];
    int e = b * i;

    if (d > e)
    {
        ok = false;
        break;
    }
}

Console.WriteLine(ok ? 1 : 0);