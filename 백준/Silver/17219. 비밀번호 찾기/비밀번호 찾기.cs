using System.Text;

int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Dictionary<string, string> dic = new Dictionary<string, string>();
StringBuilder sb = new StringBuilder();
for (int i = 0; i < a[0]; i++)
{
    string[] b = Console.ReadLine().Split();
    dic[b[0]] = b[1];
}
for (int i = 0; i < a[1]; i++)
{
    string b = Console.ReadLine();
    sb.AppendLine(dic[b]);
}
Console.WriteLine(sb.ToString());