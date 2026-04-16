internal class Program
{
    static void Main()
    {
        int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        List<int>[] b = new List<int>[a[0] + 1];
        for (int i = 1; i <= a[0]; i++)
            b[i] = new List<int>();

        for (int i = 0; i < a[1]; i++)
        {
            int[] aa = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            b[aa[0]].Add(aa[1]);
            b[aa[1]].Add(aa[0]);
        }

        int c = 0;
        int cc = int.MaxValue;
        for (int i = 1; i <= a[0]; i++)
        {
            int d = BFS(a[0], b, i);

            if (d < cc)
            {
                cc = d;
                c = i;
            }
        }

        Console.WriteLine(c);
    }

    static int BFS(int a, List<int>[] b, int aa)
    {
        int[] aaa = new int[a + 1];
        bool[] visited = new bool[a + 1];

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(aa);
        visited[aa] = true;

        while (queue.Count > 0)
        {
            int cur = queue.Dequeue();

            foreach (int next in b[cur])
            {
                if (!visited[next])
                {
                    visited[next] = true;
                    aaa[next] = aaa[cur] + 1;
                    queue.Enqueue(next);
                }
            }
        }

        int c = 0;
        for (int i = 1; i <= a; i++)
            c += aaa[i];

        return c;
    }
}