internal class Program
{
    static List<int>[] b;
    static bool[] visited;

    static void Main()
    {
        int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        b = new List<int>[a[0] + 1];
        visited = new bool[a[0] + 1];

        for (int i = 1; i <= a[0]; i++)
            b[i] = new List<int>();

        for (int i = 0; i < a[1]; i++)
        {
            int[] aa = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            b[aa[0]].Add(aa[1]);
            b[aa[1]].Add(aa[0]);
        }

        int c = 0;
        for (int i = 1; i <= a[0]; i++)
        {
            if (!visited[i])
            {
                DFS(i);
                c++;
            }
        }

        Console.WriteLine(c);
    }

    static void DFS(int i)
    {
        visited[i] = true;

        foreach (int bb in b[i])
        {
            if (!visited[bb])
                DFS(bb);
        }
    }
}