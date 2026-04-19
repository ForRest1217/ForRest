int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

if (a[0] >= a[1])
{
    Console.WriteLine(a[0] - a[1]);
    return;
}

bool[] visited = new bool[100001];
Queue<(int pos, int time)> queue = new Queue<(int, int)>();

queue.Enqueue((a[0], 0));
visited[a[0]] = true;

while (queue.Count > 0)
{
    var (pos, time) = queue.Dequeue();

    if (pos == a[1])
    {
        Console.WriteLine(time);
        return;
    }

    int[] b = { pos - 1, pos + 1, pos * 2 };

    foreach (var bb in b)
    {
        if (bb >= 0 && bb <= 100000 && !visited[bb])
        {
            visited[bb] = true;
            queue.Enqueue((bb, time + 1));
        }
    }
}