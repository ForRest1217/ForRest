int a = int.Parse(Console.ReadLine());
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int c = 1;
int d = 1;
int dd = 1;
for (int i = 1; i < a; i++)
{
    if (b[i] >= b[i - 1])
        d++;
    else
        d = 1;

    if (b[i] <= b[i - 1])
        dd++;
    else
        dd = 1;

    c = Math.Max(c, Math.Max(d, dd));
}

Console.WriteLine(c);