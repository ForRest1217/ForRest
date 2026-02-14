int a = int.Parse(Console.ReadLine());
List<(int start, int end)> b = new List<(int start, int end)>();
for (int i = 0; i < a; i++)
{
    int[] aa = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    b.Add((aa[0], aa[1]));
}


b = b.OrderBy(x => x.end).ThenBy(x => x.start).ToList();
int c = 0;
int d = 0;
foreach ((int start, int end) bb in b)
{
    if (bb.start >= d)
    {
        d = bb.end;
        c++;
    }
}

Console.WriteLine(c);