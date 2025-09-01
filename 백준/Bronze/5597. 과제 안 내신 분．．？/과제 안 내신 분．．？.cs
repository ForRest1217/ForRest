using System.Text;

int[] a = new int[28];
int[] b = new int[30];
StringBuilder sb = new StringBuilder();

for (int i = 1; i <= b.Length; i++)
{
    b[i - 1] += i;
}

for (int i = 1; i < a.Length + 1; i++)
{
    int input = int.Parse(Console.ReadLine());
    a[i - 1] += input;
}

foreach (int c in b)
{
    if (!a.Contains(c))
    {
        sb.AppendLine(c.ToString());
    }
}

Console.WriteLine(sb.ToString());