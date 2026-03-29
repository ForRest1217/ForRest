int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
int[,] b = new int[a[0], a[1]];

for (int i = 0; i < a[0]; i++)
{
    int[] aa = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    for (int j = 0; j < a[1]; j++)
        b[i, j] = aa[j];
}

int c = int.MaxValue;
int cc = 0;
for (int i = 0; i <= 256; i++)
{
    int d = 0;
    int dd = a[2];
    for (int j = 0; j < a[0]; j++)
    {
        for (int k = 0; k < a[1]; k++)
        {
            int e = b[j, k] - i;
            if (e > 0)
            {
                d += e * 2;
                dd += e;
            }
            else if (e < 0)
            {
                d += -e;
                dd += e;
            }
        }
    }

    if (dd >= 0)
    {
        if (d < c)
        {
            c = d;
            cc = i;
        }
        else if (d == c && i > cc)
        {
            cc = i;
        }
    }
}

Console.WriteLine($"{c} {cc}");