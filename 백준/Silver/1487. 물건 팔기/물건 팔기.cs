int a = int.Parse(Console.ReadLine());
List<(int p, int s)> b = new List<(int, int)>();

for (int i = 0; i < a; i++)
{
    int[] c = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    b.Add((c[0], c[1]));
}

int d = 0;
int dd = 0;
foreach (var bb in b)
{
    int e = bb.p;
    int ee = 0;
    foreach (var bbb in b)
    {
        if (bbb.p >= e && e - bbb.s > 0)
        {
            ee += e - bbb.s;
        }
    }

    if (ee > d || (ee == d && e < dd))
    {
        d = ee;
        dd = e;
    }
}

Console.WriteLine(dd);