using System.Text;

int a = int.Parse(Console.ReadLine());
int[] b = new int[a];
StringBuilder sb = new StringBuilder();
Dictionary<int, int> dic = new Dictionary<int, int>();

for (int i = 0; i < a; i++)
{
    b[i] = int.Parse(Console.ReadLine());
}
Array.Sort(b);


int mean = (int)Math.Round(b.Sum() / (double)a, MidpointRounding.AwayFromZero);
sb.AppendLine(mean.ToString());

sb.AppendLine((b[a / 2]).ToString());

foreach (int c in b)
{
    if (dic.ContainsKey(c))
        dic[c]++;
    else
        dic[c] = 1;
}
int max = dic.Values.Max();
var modes = dic.Where(x => x.Value == max).Select(x => x.Key).OrderBy(x => x).ToList();
if (modes.Count > 1)
    sb.AppendLine((modes[1]).ToString());
else
    sb.AppendLine((modes[0]).ToString());

sb.AppendLine((b[a - 1] - b[0]).ToString());

Console.WriteLine(sb.ToString());