using System.Collections.Generic;
using System.Text;     

int a = int.Parse(Console.ReadLine());
string[] b = Console.ReadLine().Split();
HashSet<int> bb = new HashSet<int>();
for (int i = 0; i < a; i++)
{
    bb.Add(int.Parse(b[i]));
}

int c = int.Parse(Console.ReadLine());
string[] d = Console.ReadLine().Split();

StringBuilder sb = new StringBuilder();
for (int i = 0; i < c; i++)
{
    if(bb.Contains(int.Parse(d[i])))
    {
        sb.AppendLine("1");
    }
    else
    {
        sb.AppendLine("0");
    }
}
Console.Write(sb.ToString());