int a = int.Parse(Console.ReadLine());
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Array.Sort(b);

int c = 0;
int cc = a - 1;

int d = int.MaxValue;
int dd = 0;
int ddd = 0;


while (c < cc)
{
    int aa = b[c] + b[cc];

    if (Math.Abs(aa) < d)
    {
        d = Math.Abs(aa);
        dd = b[c];
        ddd = b[cc];
    }

    if (aa < 0)
        c++;
    else
        cc--;
}

Console.WriteLine(dd + " " + ddd);