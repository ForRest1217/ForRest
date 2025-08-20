using System.Text;

int a = int.Parse(Console.ReadLine());
var list = new List<(int x, int y)>();
StringBuilder sb = new StringBuilder();
for (int i = 0; i < a; i++)
{
    int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    list.Add((b[0], b[1]));
}

var d = list.OrderBy(p => p.y).ThenBy(p => p.x);
foreach (var e in d)
{
    sb.AppendLine($"{e.x} {e.y}");
}
Console.WriteLine(sb.ToString());