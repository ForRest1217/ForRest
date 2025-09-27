using System.Text;

int a = int.Parse(Console.ReadLine());
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int aa = int.Parse(Console.ReadLine());
int[] bb = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

HashSet<int> set = new HashSet<int>(b);
StringBuilder sb = new StringBuilder();

foreach (int c in bb)
{
    if (set.Contains(c))
        sb.Append("1 ");
    else
        sb.Append("0 ");
}

Console.WriteLine(sb.ToString().TrimEnd());