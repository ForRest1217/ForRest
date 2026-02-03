using System.Text;

int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] c = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

HashSet<int> hashSet = new HashSet<int>(c);
List<int> list = new List<int>();
StringBuilder sb = new StringBuilder();

foreach (int bb in b)
{
    if (!hashSet.Contains(bb))
        list.Add(bb);
}

if (list.Count == 0)
{
    Console.WriteLine(0);
    return;
}

list.Sort();

sb.AppendLine(list.Count.ToString());
sb.AppendLine(string.Join(" ", list));
Console.Write(sb.ToString());