using System.Text;
int a = int.Parse(Console.ReadLine());
List<int>[] b = new List<int>[a + 1];
Queue<int> c = new Queue<int>();
StringBuilder sb = new StringBuilder();
for (int i = 1; i <= a; i++)
    b[i] = new List<int>();

for (int i = 0; i < a - 1; i++)
{
    int[] bb = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    b[bb[0]].Add(bb[1]);
    b[bb[1]].Add(bb[0]);
}

int[] d = new int[a + 1];
d[1] = -1;
c.Enqueue(1);

while (c.Count > 0)
{
    int dd = c.Dequeue();

    foreach (int bbb in b[dd])
    {
        if (d[bbb] == 0)
        {
            d[bbb] = dd;
            c.Enqueue(bbb);
        }
    }
}

for (int i = 2; i <= a; i++)
    sb.AppendLine(d[i].ToString());

Console.WriteLine(sb.ToString());