using System.Text;

StringBuilder sb = new StringBuilder();
Queue<int> queue = new Queue<int>();
int a = int.Parse(Console.ReadLine());

int[] b = new int[a];
int[] bb = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
for (int i = 0; i < a; i++)
    b[i] = bb[i];

int[] c = new int[a];
int[] cc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
for (int i = 0; i < a; i++)
    c[i] = cc[i];

for (int i = a - 1; i >= 0; i--)
    if (b[i] == 0)
        queue.Enqueue(c[i]);

int d = int.Parse(Console.ReadLine());
int[] dd = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

for (int i = 0; i < d; i++)
{
    queue.Enqueue(dd[i]);
    sb.Append(queue.Dequeue());
    if (i != d - 1)
        sb.Append(' ');
}

Console.WriteLine(sb.ToString());