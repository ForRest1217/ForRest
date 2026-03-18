int a = int.Parse(Console.ReadLine()!);
int[] b = new int[10];
int c = 1;
int cc = a;
int d = 1;

while (c <= cc)
{
    while (c % 10 != 0 && c <= cc)
    {
        int bb = c;
        while (bb > 0)
        {
            b[bb % 10] += d;
            bb /= 10;
        }
        c++;
    }

    if (c > cc)
        break;

    while (cc % 10 != 9 && c <= cc)
    {
        int bb = cc;
        while (bb > 0)
        {
            b[bb % 10] += d;
            bb /= 10;
        }
        cc--;
    }

    int bbb = (cc - c + 1) / 10;

    for (int i = 0; i < 10; i++)
        b[i] += bbb * d;

    c /= 10;
    cc /= 10;
    d *= 10;
}

Console.WriteLine(string.Join(" ", b));