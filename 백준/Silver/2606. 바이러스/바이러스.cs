int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
List<int>[] c = new List<int>[a + 1];
Queue<int> queue = new Queue<int>();
for (int i = 1; i <= a; i++)
    c[i] = new List<int>();

for (int i = 0; i < b; i++)
{
    int[] aa = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    c[aa[0]].Add(aa[1]);
    c[aa[1]].Add(aa[0]);
}

bool[] isit = new bool[a + 1];
isit[1] = true;
queue.Enqueue(1);

int e = 0;
while (queue.Count > 0)
{
    int ee = queue.Dequeue();
    foreach (int cc in c[ee])
    {
        if (!isit[cc])
        {
            isit[cc] = true;
            e++;
            queue.Enqueue(cc);
        }
    }
}

Console.WriteLine(e);