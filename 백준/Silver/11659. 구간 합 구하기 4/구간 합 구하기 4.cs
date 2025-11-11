using System.Text;

int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] c = new int[a[0] + 1];
StringBuilder sb = new StringBuilder();

for (int i = 1; i <= a[0]; i++)
{
    c[i] = c[i - 1] + b[i - 1];
}


for (int i = 0; i < a[1]; i++)
{
    int[] d = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    sb.AppendLine((c[d[1]] - c[d[0] - 1]).ToString());
}

Console.Write(sb.ToString());