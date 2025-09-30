using System.Text;

StringBuilder sb = new StringBuilder();
int a = int.Parse(Console.ReadLine());
LinkedList<int> deque = new LinkedList<int>();

for (int i = 0; i < a; i++)
{
    int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    switch (b[0])
    {
        case 1:
            {
                deque.AddFirst(b[1]);
            }
            break;
        case 2:
            {
                deque.AddLast(b[1]);
            }
            break;
        case 3:
            {
                if (deque.Count == 0)
                    sb.AppendLine("-1");
                else
                {
                    sb.AppendLine(deque.First.Value.ToString());
                    deque.RemoveFirst();
                }
            }
            break;
        case 4:
            {
                if (deque.Count == 0)
                    sb.AppendLine("-1");
                else
                {
                    sb.AppendLine(deque.Last.Value.ToString());
                    deque.RemoveLast();
                }
            }
            break;
        case 5:
            sb.AppendLine(deque.Count.ToString());
            break;
        case 6:
            sb.AppendLine(deque.Count == 0 ? "1" : "0");
            break;
        case 7:
            {
                if (deque.Count == 0)
                    sb.AppendLine("-1");
                else
                    sb.AppendLine(deque.First.Value.ToString());
            }
            break;
        case 8:
            {
                if (deque.Count == 0)
                    sb.AppendLine("-1");
                else
                    sb.AppendLine(deque.Last.Value.ToString());
            }
            break;
    }
}
Console.WriteLine(sb.ToString());