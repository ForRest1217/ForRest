using System.Text;

int a = int.Parse(Console.ReadLine());
Stack<int> stack = new Stack<int>();
StringBuilder sb = new StringBuilder();
int c = 1;
bool can = true;

for (int i = 0; i < a; i++)
{
    int b = int.Parse(Console.ReadLine());

    if (b >= c)
    {
        for (; c <= b; c++)
        {
            stack.Push(c);
            sb.AppendLine("+");
        }

        stack.Pop();
        sb.AppendLine("-");
    }
    else
    {
        if (stack.Peek() != b || stack.Count == 0)
        {
            can = false;
            break;
        }
        else
        {
            while (stack.Count > 0 && stack.Peek() >= b)
            {
                int d = stack.Pop();
                sb.AppendLine("-");
                if (d == b)
                    break;
            }
        }
    }
}

if (can)
    Console.WriteLine(sb.ToString());
else
    Console.WriteLine("NO");