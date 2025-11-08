using System.Text;

int a = int.Parse(Console.ReadLine());
PriorityQueue<int, (int, int)> pq = new PriorityQueue<int, (int, int)>();
StringBuilder sb = new StringBuilder();


for (int i = 0; i < a; i++)
{
    int b = int.Parse(Console.ReadLine());

    if (b != 0)
    {
        pq.Enqueue(b, (Math.Abs(b), b));
    }
    else
    {
        if (pq.Count == 0)
            sb.AppendLine("0");
        else
            sb.AppendLine(pq.Dequeue().ToString());
    }
}

Console.Write(sb.ToString());