 using System.Text;

int a = int.Parse(Console.ReadLine());
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
LinkedList<(int idx, int move)> deque = new LinkedList<(int, int)>();
StringBuilder sb = new StringBuilder();
for (int i = 0; i < a; i++)
{
    deque.AddLast((i + 1, b[i]));
}

while (deque.Count > 0)
{
    (int idx, int move) c = deque.First.Value;
    sb.Append($"{c.idx} ");
    deque.RemoveFirst();

    if (deque.Count == 0)
        break;

    if (c.move > 0)
    {
        int d = (c.move - 1) % deque.Count;
        for (int i = 0; i < d; i++)
        {
            (int idx, int move) e = deque.First.Value;
            deque.RemoveFirst();
            deque.AddLast(e);
        }
    }
    else
    {
        int d = (-c.move) % deque.Count;
        for (int i = 0; i < d; i++)
        {
            (int idx, int move) e = deque.Last.Value;
            deque.RemoveLast();
            deque.AddFirst(e);
        }
    }
}

Console.WriteLine(sb.ToString());