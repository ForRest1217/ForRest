int a = int.Parse(Console.ReadLine());
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int c = -1;
for (int i = 0; i <= a; i++)
{
    int aa = 0;

    foreach (int bb in b)
    {
        if (bb == i)
            aa++;
    }

    if (aa == i)
        c = Math.Max(c, i);
}

Console.WriteLine(c);