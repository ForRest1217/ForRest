using System.Text;

int a = int.Parse(Console.ReadLine());
int[] b = new int[a];
for (int i = 0; i < a; i++)
{
    b[i] = int.Parse(Console.ReadLine());
}
Array.Sort(b);
StringBuilder sb = new StringBuilder();
for (int i = 0; i < a; i++)
{
    sb.AppendLine(b[i].ToString());
}
Console.Write(sb.ToString());