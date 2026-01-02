int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
LinkedList<int> b = new LinkedList<int>();
for (int i = 1; i <= a[0]; i++)
    b.AddLast(i);

int[] c = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int d = 0;
foreach (int cc in c)
{
    int dd = 0;
    for (var i = b.First; i.Value != cc; i = i.Next)
        dd++;

    while (b.First.Value != cc)
    {
        if (dd <= b.Count / 2)
        {
            b.AddLast(b.First.Value);
            b.RemoveFirst();
        }
        else
        {
            b.AddFirst(b.Last.Value);
            b.RemoveLast();
        }
        d++;
        dd = (dd + b.Count) % b.Count;
    }
    b.RemoveFirst();
}

Console.WriteLine(d);