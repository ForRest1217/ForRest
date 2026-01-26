int a = int.Parse(Console.ReadLine());
List<(int country, int number, int score)> b = new List<(int country, int number, int score)>();
for (int i = 0; i < a; i++)
{
    int[] aa = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    b.Add((aa[0], aa[1], aa[2]));
}

b = b.OrderByDescending(s => s.score).ToList();

Dictionary<int, int> c = new Dictionary<int, int>();
int d = 0;
foreach (var bb in b)
{
    if (!c.ContainsKey(bb.country))
        c[bb.country] = 0;

    if (c[bb.country] < 2)
    {
        Console.WriteLine($"{bb.country} {bb.number}");
        c[bb.country]++;
        d++;

        if (d == 3)
            break;
    }
}