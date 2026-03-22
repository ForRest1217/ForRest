internal class Program
{
    static List<int>[] graph;
    static bool[] visited;

    static void Main()
    {
        int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        graph = new List<int>[a[0]];
        visited = new bool[a[0]];
        for (int i = 0; i < a[0]; i++)
            graph[i] = new List<int>();

        for (int i = 0; i < a[1]; i++)
        {
            int[] aa = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            graph[aa[0] - 1].Add(aa[1] - 1);
            graph[aa[1] - 1].Add(aa[0] - 1);
        }

        for (int i = 0; i < a[0]; i++)
            graph[i].Sort();

        DFS(a[2] - 1);

        Console.Write("\n");

        visited = new bool[a[0]];

        BFS(a[2] - 1);
    }

    static void DFS(int v)
    {
        visited[v] = true;
        Console.Write(v + 1 + " ");

        foreach (int value in graph[v])
        {
            if (!visited[value])
                DFS(value);
        }
    }

    static void BFS(int v)
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(v);
        visited[v] = true;

        while (queue.Count > 0)
        {
            int a = queue.Dequeue();
            Console.Write(a + 1 + " ");

            foreach (int value in graph[a])
            {
                if (!visited[value])
                {
                    visited[value] = true;
                    queue.Enqueue(value);
                }
            }
        }
    }
}