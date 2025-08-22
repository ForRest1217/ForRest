using System.Text;

int a = int.Parse(Console.ReadLine());
Queue<int> queue = new Queue<int>();
StringBuilder sb = new StringBuilder();
for (int i = 0; i < a; i++)
{
    string[] b = Console.ReadLine().Split();
    switch (b[0])
    {
        case "push":
            queue.Enqueue(int.Parse(b[1]));
            break;
        case "pop":
            sb.AppendLine(queue.Count == 0 ? "-1" : queue.Dequeue().ToString());
            break;
        case "size":
            sb.AppendLine(queue.Count.ToString());
            break;
        case "empty":
            sb.AppendLine(queue.Count == 0 ? "1" : "0");
            break;
        case "front":
            sb.AppendLine(queue.Count == 0 ? "-1" : queue.Peek().ToString());
            break;
        case "back":
            sb.AppendLine(queue.Count == 0 ? "-1" : queue.ToArray()[queue.Count - 1].ToString());
            break;
    }
}
Console.Write(sb.ToString());