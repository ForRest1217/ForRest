using System.Text;


int a = int.Parse(Console.ReadLine());
LinkedList<int> deque = new LinkedList<int>();
StringBuilder sb = new StringBuilder();

for (int i = 0; i < a; i++)
{
    string[] b = Console.ReadLine().Split();

    switch (b[0])
    {
        case "push_front":
            deque.AddFirst(int.Parse(b[1]));
            break;

        case "push_back":
            deque.AddLast(int.Parse(b[1]));
            break;

        case "pop_front":
            if (deque.Count == 0)
                sb.AppendLine("-1");
            else
            {
                sb.AppendLine(deque.First.Value.ToString());
                deque.RemoveFirst();
            }
            break;

        case "pop_back":
            if (deque.Count == 0)
                sb.AppendLine("-1");
            else
            {
                sb.AppendLine(deque.Last.Value.ToString());
                deque.RemoveLast();
            }
            break;

        case "size":
            sb.AppendLine(deque.Count.ToString());
            break;

        case "empty":
            sb.AppendLine(deque.Count == 0 ? "1" : "0");
            break;

        case "front":
            if (deque.Count == 0)
                sb.AppendLine("-1");
            else
                sb.AppendLine(deque.First.Value.ToString());
            break;

        case "back":
            if (deque.Count == 0)
                sb.AppendLine("-1");
            else
                sb.AppendLine(deque.Last.Value.ToString());
            break;
    }
}
Console.Write(sb.ToString());