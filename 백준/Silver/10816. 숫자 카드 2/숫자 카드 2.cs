using System.Text;

int a = int.Parse(Console.ReadLine());
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int c = int.Parse(Console.ReadLine());
int[] d = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Dictionary<int, int> dic = new Dictionary<int, int>();
StringBuilder sb = new StringBuilder();

foreach (int e in b)
{
    if (dic.ContainsKey(e))
        dic[e]++;
    else
        dic[e] = 1;
}
foreach (int f in d)
{
    if (dic.ContainsKey(f))
        sb.Append(dic[f] + " ");
    else
        sb.Append("0 ");
}

Console.WriteLine(sb.ToString().TrimEnd());