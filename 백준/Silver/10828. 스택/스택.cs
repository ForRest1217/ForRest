using System.Text;

int a = int.Parse(Console.ReadLine());
int[] stack = new int[a];
int c = -1; 
StringBuilder sb = new StringBuilder();
for (int i = 0; i < a; i++)
{

    string[] d = Console.ReadLine().Split();

    switch (d[0])
    {
        case "push":
            c++;
            stack[c] = int.Parse(d[1]);
            break;

        case "pop":
            if (c == -1)
                sb.AppendLine("-1");
            else
            {
                sb.AppendLine(stack[c].ToString());
                c--;
            }
            break;

        case "size":
            sb.AppendLine((c + 1).ToString());
            break;

        case "empty":
            sb.AppendLine(c == -1 ? "1" : "0");
            break;

        case "top":
            sb.AppendLine(c == -1 ? "-1" : stack[c].ToString());
            break;
    }
}
Console.Write(sb.ToString());