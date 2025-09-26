using System.Text;

int a = int.Parse(Console.ReadLine());
Stack<int> stack = new Stack<int>();
StringBuilder sb = new StringBuilder();

for (int i = 0; i < a; i++)
{
    int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    switch (b[0])
    {
        case 1:
            stack.Push(b[1]);
            break;
        case 2:
            if (stack.Count > 0)
                sb.AppendLine(stack.Pop().ToString());
            else
                sb.AppendLine("-1");
            break;
        case 3:
            sb.AppendLine(stack.Count.ToString());
            break;
        case 4:
            sb.AppendLine(stack.Count == 0 ? "1" : "0");
            break;
        case 5:
            if (stack.Count > 0)
                sb.AppendLine(stack.Peek().ToString());
            else
                sb.AppendLine("-1");
            break;
    }
}
Console.WriteLine(sb.ToString());