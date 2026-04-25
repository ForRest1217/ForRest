internal class Program
{
    static int result = -1;

    static void Main()
    {
        string[] input = Console.ReadLine()!.Split();
        string start = input[0];
        int K = int.Parse(input[1]);

        BFS(start, K);

        Console.WriteLine(result);
    }

    static void BFS(string start, int K)
    {
        Queue<(string number, int depth)> queue = new Queue<(string, int)>();
        queue.Enqueue((start, 0));
        HashSet<int>[] visited = new HashSet<int>[K + 1];
        for (int i = 0; i <= K; i++)
            visited[i] = new HashSet<int>();

        visited[0].Add(int.Parse(start));

        while (queue.Count > 0)
        {
            var (current, depth) = queue.Dequeue();

            if (depth == K)
            {
                result = Math.Max(result, int.Parse(current));
                continue;
            }

            char[] arr = current.ToCharArray();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    char[] temp = (char[])arr.Clone();
                    char t = temp[i];
                    temp[i] = temp[j];
                    temp[j] = t;

                    if (temp[0] == '0') 
                        continue;

                    int cc = int.Parse(new string(temp));

                    if (!visited[depth + 1].Contains(cc))
                    {
                        visited[depth + 1].Add(cc);
                        queue.Enqueue((cc.ToString(), depth + 1));
                    }
                }
            }
        }
    }
}