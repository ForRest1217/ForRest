using System.Text;

int a = int.Parse(Console.ReadLine());
var c = new (int x, int y)[a];
StringBuilder sb = new StringBuilder();
for (int i = 0; i < a; i++)
{
    int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    c[i] = (b[0], b[1]);
}
var d = c.OrderBy(p => p.x).ThenBy(p => p.y);
foreach (var e in d)
{
    sb.AppendLine($"{e.x} {e.y}");
}
Console.WriteLine(sb.ToString());