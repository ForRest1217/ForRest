int a = int.Parse(Console.ReadLine());
int[] c = new int[a];
int[] d = new int[a];
int[] e = new int[a];
for (int i = 0; i < a; i++)
{
    int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    c[i] = b[0];
    d[i] = b[1];
}
for (int i = 0; i < a; i++)
{
    int f = 1;
    for (int j = 0; j < a; j++)
    {
        if (i == j)
        {
            continue;
        }
        else if (c[j] > c[i] && d[j] > d[i])
        {
            f++;
        }
    }
    e[i] = f;
}
foreach (int i in e)
{
    Console.Write(i + " ");
}