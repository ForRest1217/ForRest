int a = int.Parse(Console.ReadLine());
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int c = int.MaxValue;
int d = int.MinValue;

foreach (int e in b)
{
    if (e < c)
        c = e;
    if (e > d)
        d = e;
}

Console.WriteLine(c * d);