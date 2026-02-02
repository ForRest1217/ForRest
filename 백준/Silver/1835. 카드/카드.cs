using System.Text;
int a = int.Parse(Console.ReadLine()!);
StringBuilder sb = new StringBuilder();
LinkedList<int> linkedList = new LinkedList<int>();

for (int i = a; i > 0; i--)
{
    linkedList.AddFirst(i);

    for (int j = 0; j < i; j++)
    {
        if (linkedList.Count > 0)
        {
            int c = linkedList.Last!.Value;
            linkedList.RemoveLast();
            linkedList.AddFirst(c);
        }
    }
}

foreach (int value in linkedList)
{
    sb.Append(value).Append(' ');
}
Console.Write(sb.ToString());