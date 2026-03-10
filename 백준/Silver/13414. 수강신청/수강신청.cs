using System.Text;

int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
List<string> list = new List<string>(a[1]);
StringBuilder sb = new StringBuilder();
for (int i = 0; i < a[1]; i++)
    list.Add(Console.ReadLine());

HashSet<string> hashSet = new HashSet<string>();
List<string> listwo = new List<string>();

for (int i = a[1] - 1; i >= 0; i--)
{
    if (hashSet.Add(list[i]))
    {
        listwo.Add(list[i]);
    }
}

listwo.Reverse();
int c = Math.Min(a[0], listwo.Count);

for (int i = 0; i < c; i++)
    sb.AppendLine(listwo[i]);

Console.Write(sb.ToString());